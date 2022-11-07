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
    public partial class FormRuangan : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id = "";

        int pageNumber = 1;
        IPagedList<LoadRuangan> list;

        public FormRuangan()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<LoadRuangan>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities25 db = new SI_HotelEntities25())
                {
                    return db.LoadRuangans.OrderBy(p => p.id_ruangan).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FormRuangan_Load(object sender, EventArgs e)
        {
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGRuangan.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaRuangan.Text = "";
            tbHargaRuangan.Text = "Masukkan Harga Ruangan";

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
                cobaDGRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
                cobaDGRuangan.Columns[1].HeaderCell.Value = "Nama Ruangan";
                cobaDGRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
                cobaDGRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
                cobaDGRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGRuangan.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGRuangan.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGRuangan.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGRuangan.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            } catch (Exception ex) { }
        }

        public void LoadData()
        {

            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadRuangan", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsRuangan.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            dsRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
            dsRuangan.Columns[1].HeaderCell.Value = "Nama Ruangan";
            dsRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
            dsRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
        }

        private string loading()
        {
            IDOtomatis a = new IDOtomatis();
            string sp = "sp_IDRuangan";
            a.setID("RN", sp);
            string id = a.getID();
            return id;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id = loading();
            string deskripsi = tbNamaRuangan.Text;
            string harga = tbHargaRuangan.Text;

            if (deskripsi == "" || harga == "Masukkan Harga Ruangan")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand insert = new SqlCommand("sp_InsertRuangan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_ruangan", id);
                insert.Parameters.AddWithValue("deskripsi_ruangan", deskripsi);
                insert.Parameters.AddWithValue("harga_ruangan", harga);
                insert.Parameters.AddWithValue("status_ruangan", 1);

                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Insert data ruangan berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Apakah ingin menghapus data ruangan?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteRuangan", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id_ruangan", id);
                try
                {
                    delete.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data ruangan berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data ruangan batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string deskripsi = tbNamaRuangan.Text;
                string harga = tbHargaRuangan.Text;


                if (deskripsi == "" || harga == "Masukkan Harga Ruangan")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand Update = new SqlCommand("sp_UpdateRuangan", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_ruangan", id);
                    Update.Parameters.AddWithValue("deskripsi_ruangan", deskripsi);
                    Update.Parameters.AddWithValue("harga_ruangan", harga);

                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Update dara ruangan berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            clear();
        }

        private void dsRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsRuangan.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaRuangan.Text = row.Cells[1].Value.ToString();
                    tbHargaRuangan.Text = row.Cells[2].Value.ToString();

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

        private void tbHargaRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
                    SqlCommand view = new SqlCommand("sp_CariRuangan", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGRuangan.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
                cobaDGRuangan.Columns[1].HeaderCell.Value = "Nama Ruangan";
                cobaDGRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
                cobaDGRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
                cobaDGRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbDeskripsiRuangan_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbDeskripsiRuangan_Leave(object sender, EventArgs e)
        {
            
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
                    cobaDGRuangan.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariRuangan", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGRuangan.DataSource = bindingSource1;
                        connection.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
                cobaDGRuangan.Columns[1].HeaderCell.Value = "Nama Ruangan";
                cobaDGRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
                cobaDGRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
                cobaDGRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbHargaRuangan_Enter(object sender, EventArgs e)
        {
            if (tbHargaRuangan.Text == "Masukkan Harga Ruangan")
            {
                tbHargaRuangan.Text = "";
            }
        }

        private void tbHargaRuangan_Leave(object sender, EventArgs e)
        {
            if (tbHargaRuangan.Text == "")
            {
                tbHargaRuangan.Text = "Masukkan Harga Ruangan";
            }
        }

        private void tbHargaRuangan_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHargaRuangan_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaRuangan.Text.Equals(""))
            {
                tbHargaRuangan.Text = "";
            }
            else if (!string.IsNullOrEmpty(tbHargaRuangan.Text) && tbHargaRuangan.Text != "Masukkan Harga Ruangan")
            {
                tbHargaRuangan.Text = String.Format("{0:n0}", double.Parse(tbHargaRuangan.Text));
                tbHargaRuangan.SelectionStart = tbHargaRuangan.Text.Length;
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
                    cobaDGRuangan.DataSource = list.ToList();
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
                    cobaDGRuangan.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGRuangan.Rows[e.RowIndex];

                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaRuangan.Text = row.Cells[1].Value.ToString();
                    tbHargaRuangan.Text = row.Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
