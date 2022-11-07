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
using System.Globalization;
using PagedList;

namespace ProjectAkhir_Kel02.Forms
{
    public partial class FormJenisKamar : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id = "";

        int pageNumber = 1;
        IPagedList<JenisKamar> list;

        public FormJenisKamar()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<JenisKamar>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities18 db = new SI_HotelEntities18())
                {
                    return db.JenisKamars.OrderBy(p => p.id_jenis_kamar).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void FormJenisKamar_Load(object sender, EventArgs e)
        {
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGJenisKamar.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaJenisKamar.Text = "";
            tbDeskripsiJenisKamar.Text = "Masukkan Deskripsi Jenis Kamar";
            tbHargaJenisKamar.Text = "Masukkan Harga Jenis Kamar";

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGJenisKamar.Columns[0].HeaderCell.Value = "ID Jenis Kamar";
                cobaDGJenisKamar.Columns[1].HeaderCell.Value = "Nama Jenis Kamar";
                cobaDGJenisKamar.Columns[2].HeaderCell.Value = "Deskripsi Jenis Kamar";
                cobaDGJenisKamar.Columns[3].HeaderCell.Value = "Harga Jenis Kamar";
                cobaDGJenisKamar.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGJenisKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGJenisKamar.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGJenisKamar.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGJenisKamar.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGJenisKamar.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
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
                SqlCommand view = new SqlCommand("sp_LoadJenisKamar", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsJenisKamar.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsFasilitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = tbNamaJenisKamar.Text;
            string deskripsi = tbDeskripsiJenisKamar.Text;
            string harga = tbHargaJenisKamar.Text;

            int a = 1;

            foreach (DataGridViewRow rows in dsJenisKamar.Rows)
            {
                string data2 = rows.Cells[1].Value?.ToString();

                if (tbNamaJenisKamar.Text.ToString().Equals(data2))
                {
                    MessageBox.Show("Nama Jenis Kamar sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    a = 0;
                    return;
                }
            }

            if (a != 0)
            {
                if (nama == "" || deskripsi == "Masukkan Deskripsi Jenis Kamar" || harga == "Masukkan Harga Jenis Kamar")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_InsertJenisKamar", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("nama_jenis_kamar", nama);
                    insert.Parameters.AddWithValue("deskripsi_jenis_kamar", deskripsi);
                    insert.Parameters.AddWithValue("harga_jenis_kamar", harga);

                    try
                    {
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Insert data jenis kamar berhasil !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            d = MessageBox.Show("Apakah ingin menghapus data jenis kamar?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteJenisKamar", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id_jenis_kamar", id);
                try
                {
                    delete.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data jenis kamar berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string nama = tbNamaJenisKamar.Text;
                string deskripsi = tbDeskripsiJenisKamar.Text;
                string harga = tbHargaJenisKamar.Text;

                if (nama == "" || deskripsi == "Masukkan Deskripsi Jenis Kamar" || harga == "Masukkan Harga Jenis Kamar")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand Update = new SqlCommand("sp_UpdateJenisKamar", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_jenis_kamar", id);
                    Update.Parameters.AddWithValue("nama_jenis_kamar", nama);
                    Update.Parameters.AddWithValue("deskripsi_jenis_kamar", deskripsi);
                    Update.Parameters.AddWithValue("harga_jenis_kamar", harga);

                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Update data jenis kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            clear();
        }

        private void dsJenisKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsJenisKamar.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaJenisKamar.Text = row.Cells[1].Value.ToString();
                    tbDeskripsiJenisKamar.Text = row.Cells[2].Value.ToString();
                    tbHargaJenisKamar.Text = row.Cells[3].Value.ToString();

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

        private void tbNamaJenisKamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbHargaJenisKamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
                    SqlCommand view = new SqlCommand("sp_CariJenisKamar", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);     
                    bindingSource1.DataSource = st;
                    cobaDGJenisKamar.DataSource = bindingSource1;
                    connection.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGJenisKamar.Columns[0].HeaderCell.Value = "ID Jenis Kamar";
                cobaDGJenisKamar.Columns[1].HeaderCell.Value = "Nama Jenis Kamar";
                cobaDGJenisKamar.Columns[2].HeaderCell.Value = "Deskripsi Jenis Kamar";
                cobaDGJenisKamar.Columns[3].HeaderCell.Value = "Harga Jenis Kamar";
                cobaDGJenisKamar.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGJenisKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbDeskripsiJenisKamar_Enter(object sender, EventArgs e)
        {
            if (tbDeskripsiJenisKamar.Text == "Masukkan Deskripsi Jenis Kamar")
            {
                tbDeskripsiJenisKamar.Text = "";
            }
        }

        private void tbDeskripsiJenisKamar_Leave(object sender, EventArgs e)
        {
            if (tbDeskripsiJenisKamar.Text == "")
            {
                tbDeskripsiJenisKamar.Text = "Masukkan Deskripsi Jenis Kamar";
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
                    cobaDGJenisKamar.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariJenisKamar", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGJenisKamar.DataSource = bindingSource1;
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGJenisKamar.Columns[0].HeaderCell.Value = "ID Jenis Kamar";
                cobaDGJenisKamar.Columns[1].HeaderCell.Value = "Nama Jenis Kamar";
                cobaDGJenisKamar.Columns[2].HeaderCell.Value = "Deskripsi Jenis Kamar";
                cobaDGJenisKamar.Columns[3].HeaderCell.Value = "Harga Jenis Kamar";
                cobaDGJenisKamar.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGJenisKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbHargaJenisKamar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbHargaJenisKamar_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbHargaJenisKamar.Text == "Masukkan Harga Jenis Kamar")
            {
                tbHargaJenisKamar.Text = "";
            }
        }

        private void tbHargaJenisKamar_Leave(object sender, EventArgs e)
        {
            if (tbHargaJenisKamar.Text == "")
            {
                tbHargaJenisKamar.Text = "Masukkan Harga Jenis Kamar";
            }
        }

        private void tbHargaJenisKamar_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaJenisKamar.Text.Equals(""))
            {
                tbHargaJenisKamar.Text = "";
            }
            else if (!string.IsNullOrEmpty(tbHargaJenisKamar.Text) && tbHargaJenisKamar.Text != "Masukkan Harga Jenis Kamar")
            {
                tbHargaJenisKamar.Text = String.Format("{0:n0}", double.Parse(tbHargaJenisKamar.Text));
                tbHargaJenisKamar.SelectionStart = tbHargaJenisKamar.Text.Length;
            }
        }

        private void tbHargaJenisKamar_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void tbHargaJenisKamar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
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
                    cobaDGJenisKamar.DataSource = list.ToList();
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
                    cobaDGJenisKamar.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGJenisKamar_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGJenisKamar.Rows[e.RowIndex];

                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaJenisKamar.Text = row.Cells[1].Value.ToString();
                    tbDeskripsiJenisKamar.Text = row.Cells[2].Value.ToString();
                    tbHargaJenisKamar.Text = row.Cells[3].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
