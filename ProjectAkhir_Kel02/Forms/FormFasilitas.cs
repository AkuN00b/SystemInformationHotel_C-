using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using PagedList;

namespace ProjectAkhir_Kel02.Forms
{
    public partial class FormFasilitas : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id = "";

        int pageNumber = 1;
        IPagedList<Fasilita> list;

        public FormFasilitas()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<Fasilita>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities20 db = new SI_HotelEntities20())
                {
                    return db.Fasilitas.OrderBy(p => p.id_fasilitas).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void FormFasilitas_Load(object sender, EventArgs e)
        {
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGFasilitas.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaFasilitas.Text = "";
            tbJumlah.Text = "";
            tbSearch.Text = "";

            connection.Close();
            LoadData();
            loading();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGFasilitas.Columns[0].HeaderCell.Value = "ID Fasilitas";
                cobaDGFasilitas.Columns[1].HeaderCell.Value = "Nama Fasilitas";
                cobaDGFasilitas.Columns[2].HeaderCell.Value = "Kuantitas";
                cobaDGFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGFasilitas.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGFasilitas.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGFasilitas.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex) { }
        }

        public void LoadData()
        {

            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadFasilitas", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsFasilitas.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private string loading()
        {
            IDOtomatis a = new IDOtomatis();
            string sp = "sp_IDFasilitas";
            a.setID("FS", sp);
            string id = a.getID();
            return id;
        }



        private void tbEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dsDetailFasilitasKamar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id = loading();
            string nama = tbNamaFasilitas.Text;
            string jumlah = tbJumlah.Text;

            int a = 1;

            foreach (DataGridViewRow rows in dsFasilitas.Rows)
            {
                string data2 = rows.Cells[1].Value?.ToString();

                if (tbNamaFasilitas.Text.ToString().Equals(data2))
                {
                    MessageBox.Show("Nama Fasilitas sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    a = 0;
                    return;
                }
            }

            if (a != 0)
            {
                if (nama == "" || jumlah == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_InsertFasilitasAutoID", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    // insert.Parameters.AddWithValue("id_fasilitas", id);
                    insert.Parameters.AddWithValue("nama_fasilitas", nama);
                    insert.Parameters.AddWithValue("qty", jumlah);

                    try
                    {
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Insert data fasilitas berhasil ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            }

            clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteFasilitas", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id_fasilitas", id);
                try
                {
                    delete.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNamaFasilitas.Text;
                string jumlah = tbJumlah.Text;

                if (nama == "" || jumlah == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand Update = new SqlCommand("sp_UpdateFasilitas", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_fasilitas", id);
                    Update.Parameters.AddWithValue("nama_fasilitas", nama);
                    Update.Parameters.AddWithValue("qty", jumlah);

                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Update data fasilitas berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            clear();
        }

        private void dsFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsFasilitas.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaFasilitas.Text = row.Cells[1].Value.ToString();
                    tbJumlah.Text = row.Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNamaFasilitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearch.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariFasilitas", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGFasilitas.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGFasilitas.Columns[0].HeaderCell.Value = "ID Fasilitas";
                cobaDGFasilitas.Columns[1].HeaderCell.Value = "Nama Fasilitas";
                cobaDGFasilitas.Columns[2].HeaderCell.Value = "Kuantitas";
                cobaDGFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private async void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearch.Text;

                if (cari == "")
                {
                    pageNumber = 1;
                    list = await GetPagedListAsync(1);
                    btnPrevious.Enabled = list.HasPreviousPage;
                    btnNext.Enabled = list.HasNextPage;
                    cobaDGFasilitas.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
                else
                {
                    btnNext.Enabled = false;
                    btnPrevious.Enabled = false;

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        DataTable st = new DataTable();
                        SqlCommand view = new SqlCommand("sp_CariFasilitas", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGFasilitas.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGFasilitas.Columns[0].HeaderCell.Value = "ID Fasilitas";
                cobaDGFasilitas.Columns[1].HeaderCell.Value = "Nama Fasilitas";
                cobaDGFasilitas.Columns[2].HeaderCell.Value = "Kuantitas";
                cobaDGFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblPageNumber.Text != "label1")
            {
                if (list.HasPreviousPage)
                {
                    list = await GetPagedListAsync(--pageNumber);
                    btnPrevious.Enabled = list.HasPreviousPage;
                    btnNext.Enabled = list.HasNextPage;
                    cobaDGFasilitas.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (lblPageNumber.Text != "label1")
            {
                if (list.HasNextPage)
                {
                    list = await GetPagedListAsync(++pageNumber);
                    btnPrevious.Enabled = list.HasPreviousPage;
                    btnNext.Enabled = list.HasNextPage;
                    cobaDGFasilitas.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.cobaDGFasilitas.Rows[e.RowIndex];

                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaFasilitas.Text = row.Cells[1].Value.ToString();
                    tbJumlah.Text = row.Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
