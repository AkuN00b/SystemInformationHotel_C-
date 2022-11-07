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
    public partial class FormJenisMakanan : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id;

        int pageNumber = 1;
        IPagedList<JenisMenu> list;

        public FormJenisMakanan()
        {
            InitializeComponent();
        }

        private void tbDeskripsiJenisMakanan_OnValueChanged(object sender, EventArgs e)
        {

        }

        public async Task<IPagedList<JenisMenu>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities23 db = new SI_HotelEntities23())
                {
                    return db.JenisMenus.OrderBy(p => p.id_jenis_makanan).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void FormJenisMakanan_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNamaJenisMakanan.Text;
                string deskripsi = tbDeskripsiJenisMakanan.Text;

                if (nama == "" || deskripsi == "Masukkan Deskripsi Jenis Menu")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_InsertJenisMenu", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("nama_jenis_menu", nama);
                    insert.Parameters.AddWithValue("deskripsi_jenis_menu", deskripsi);


                    insert.ExecuteNonQuery();
                    MessageBox.Show("Insert data jenis menu berhasil ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Apakah ingin menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteJenisMakanan", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id_jenis_menu", id);
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

                string nama = tbNamaJenisMakanan.Text;
                string deskripsi = tbDeskripsiJenisMakanan.Text;

                if (nama == "" || deskripsi == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand Update = new SqlCommand("sp_UpdateJenisMenu", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_jenis_menu", id);
                    Update.Parameters.AddWithValue("nama_jenis_menu", nama);
                    Update.Parameters.AddWithValue("deskripsi_jenis_menu", deskripsi);


                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Update Data Jenis Menu Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            clear();
        }

        public void LoadData()
        {

            BindingSource bindingSource1 = new BindingSource();
            try
            {

                connection.Open();
                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadJenisMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsJenisMakanan.DataSource = bindingSource1;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dsJenisMakanan.Columns[0].HeaderCell.Value = "ID Jenis Menu";
                dsJenisMakanan.Columns[1].HeaderCell.Value = "Nama Jenis Menu";
                dsJenisMakanan.Columns[2].HeaderCell.Value = "Deskripsi Jenis Menu";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void dsJenisMakanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsJenisMakanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsJenisMakanan.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaJenisMakanan.Text = row.Cells[1].Value.ToString();
                    tbDeskripsiJenisMakanan.Text = row.Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");

            }
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGJenisMenu.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaJenisMakanan.Text = "";
            tbDeskripsiJenisMakanan.Text = "Masukkan Deskripsi Jenis Menu";

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGJenisMenu.Columns[0].HeaderCell.Value = "ID Jenis Menu";
                cobaDGJenisMenu.Columns[1].HeaderCell.Value = "Nama Jenis Menu";
                cobaDGJenisMenu.Columns[2].HeaderCell.Value = "Deskripsi Jenis Menu";
                cobaDGJenisMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGJenisMenu.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGJenisMenu.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGJenisMenu.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex) { }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();    
        }

        private void tbNamaJenisMakanan_KeyPress(object sender, KeyPressEventArgs e)
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
                    SqlCommand view = new SqlCommand("sp_CariJenisMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGJenisMenu.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGJenisMenu.Columns[0].HeaderCell.Value = "ID Jenis Menu";
                cobaDGJenisMenu.Columns[1].HeaderCell.Value = "Nama Jenis Menu";
                cobaDGJenisMenu.Columns[2].HeaderCell.Value = "Deskripsi Jenis Menu";
                cobaDGJenisMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbDeskripsiJenisMakanan_Enter(object sender, EventArgs e)
        {
            if (tbDeskripsiJenisMakanan.Text == "Masukkan Deskripsi Jenis Menu")
            {
                tbDeskripsiJenisMakanan.Text = "";
            }
        }

        private void tbDeskripsiJenisMakanan_Leave(object sender, EventArgs e)
        {
            if (tbDeskripsiJenisMakanan.Text == "")
            {
                tbDeskripsiJenisMakanan.Text = "Masukkan Deskripsi Jenis Menu";
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
                    cobaDGJenisMenu.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariJenisMenu", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGJenisMenu.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGJenisMenu.Columns[0].HeaderCell.Value = "ID Jenis Menu";
                cobaDGJenisMenu.Columns[1].HeaderCell.Value = "Nama Jenis Menu";
                cobaDGJenisMenu.Columns[2].HeaderCell.Value = "Deskripsi Jenis Menu";
                cobaDGJenisMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
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
                    cobaDGJenisMenu.DataSource = list.ToList();
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
                    cobaDGJenisMenu.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGJenisMenu_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGJenisMenu.Rows[e.RowIndex];

                    //transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    tbNamaJenisMakanan.Text = row.Cells[1].Value.ToString();
                    tbDeskripsiJenisMakanan.Text = row.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
