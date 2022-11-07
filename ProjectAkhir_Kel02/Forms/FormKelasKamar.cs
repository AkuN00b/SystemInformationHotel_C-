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
    public partial class FormKelasKamar : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id = "";

        int pageNumber = 1;
        IPagedList<KelasKamar> list;

        public FormKelasKamar()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<KelasKamar>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities19 db = new SI_HotelEntities19())
                {
                    return db.KelasKamars.OrderBy(p => p.id_kelas_kamar).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void FormKelasKamar_Load(object sender, EventArgs e)
        {
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGKelasKamar.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaKelasKamar.Text = "";
            tbDeskripsiKelasKamar.Text = "Masukkan Deskripsi Kelas Kamar";
            tbHargaKelasKamar.Text = "Masukkan Harga Kelas Kamar";

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGKelasKamar.Columns[0].HeaderCell.Value = "ID Kelas Kamar";
                cobaDGKelasKamar.Columns[1].HeaderCell.Value = "Nama Kelas Kamar";
                cobaDGKelasKamar.Columns[2].HeaderCell.Value = "Deskripsi Kelas Kamar";
                cobaDGKelasKamar.Columns[3].HeaderCell.Value = "Harga Kelas Kamar";
                cobaDGKelasKamar.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGKelasKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGKelasKamar.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGKelasKamar.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGKelasKamar.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGKelasKamar.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
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
                SqlCommand view = new SqlCommand("sp_LoadKelasKamar", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsKelasKamar.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int a = 1;

            string nama = tbNamaKelasKamar.Text;
            string deskripsi = tbDeskripsiKelasKamar.Text;
            string harga = tbHargaKelasKamar.Text;

            foreach (DataGridViewRow rows in dsKelasKamar.Rows)
            {
                string data2 = rows.Cells[1].Value?.ToString();

                if (tbNamaKelasKamar.Text.ToString().Equals(data2))
                {
                    MessageBox.Show("Nama Kelas Kamar sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    a = 0;
                    return;
                }
            }

            if (a != 0)
            {
                if (nama == "" || deskripsi == "Masukkan Deskripsi Kelas Kamar" || harga == "Masukkan Harga Kelas Kamar")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand insert = new SqlCommand("sp_InsertKelasKamar", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("nama_kelas_kamar", nama);
                    insert.Parameters.AddWithValue("deskripsi_kelas_kamar", deskripsi);
                    insert.Parameters.AddWithValue("harga_kelas_kamar", harga);

                    try
                    {
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Insert data kelas kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            d = MessageBox.Show("Apakah ingin menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteKelasKamar", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id_kelas_kamar", id);
                try
                {
                    delete.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data kelas kamar berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string nama = tbNamaKelasKamar.Text;
                string deskripsi = tbDeskripsiKelasKamar.Text;
                string harga = tbHargaKelasKamar.Text;

                if (nama == "" || deskripsi == "Masukkan Deskripsi Kelas Kamar" || harga == "Masukkan Harga Kelas Kamar")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand Update = new SqlCommand("sp_UpdateKelasKamar", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_kelas_kamar", id);
                    Update.Parameters.AddWithValue("nama_kelas_kamar", nama);
                    Update.Parameters.AddWithValue("deskripsi_kelas_kamar", deskripsi);
                    Update.Parameters.AddWithValue("harga_kelas_kamar", harga);

                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Update data kelas kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            clear();
        }

        private void dsKelasKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsKelasKamar.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaKelasKamar.Text = row.Cells[1].Value.ToString();
                    tbDeskripsiKelasKamar.Text = row.Cells[2].Value.ToString();
                    tbHargaKelasKamar.Text = row.Cells[3].Value.ToString();

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

        private void tbNamaKelasKamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbHargaKelasKamar_KeyPress(object sender, KeyPressEventArgs e)
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
                    SqlCommand view = new SqlCommand("sp_CariKelasKamar", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGKelasKamar.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGKelasKamar.Columns[0].HeaderCell.Value = "ID Kelas Kamar";
                cobaDGKelasKamar.Columns[1].HeaderCell.Value = "Nama Kelas Kamar";
                cobaDGKelasKamar.Columns[2].HeaderCell.Value = "Deskripsi Kelas Kamar";
                cobaDGKelasKamar.Columns[3].HeaderCell.Value = "Harga Kelas Kamar";
                cobaDGKelasKamar.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGKelasKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbDeskripsiKelasKamar_Enter(object sender, EventArgs e)
        {
            if (tbDeskripsiKelasKamar.Text == "Masukkan Deskripsi Kelas Kamar")
            {
                tbDeskripsiKelasKamar.Text = "";
            }
        }

        private void tbDeskripsiKelasKamar_Leave(object sender, EventArgs e)
        {
            if (tbDeskripsiKelasKamar.Text == "")
            {
                tbDeskripsiKelasKamar.Text = "Masukkan Deskripsi Kelas Kamar";
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
                    cobaDGKelasKamar.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariKelasKamar", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGKelasKamar.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGKelasKamar.Columns[0].HeaderCell.Value = "ID Kelas Kamar";
                cobaDGKelasKamar.Columns[1].HeaderCell.Value = "Nama Kelas Kamar";
                cobaDGKelasKamar.Columns[2].HeaderCell.Value = "Deskripsi Kelas Kamar";
                cobaDGKelasKamar.Columns[3].HeaderCell.Value = "Harga Kelas Kamar";
                cobaDGKelasKamar.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGKelasKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbHargaKelasKamar_Enter(object sender, EventArgs e)
        {
            if (tbHargaKelasKamar.Text == "Masukkan Harga Kelas Kamar")
            {
                tbHargaKelasKamar.Text = "";
            }
        }

        private void tbHargaKelasKamar_Leave(object sender, EventArgs e)
        {
            if (tbHargaKelasKamar.Text == "")
            {
                tbHargaKelasKamar.Text = "Masukkan Harga Kelas Kamar";
            }
        }

        private void tbHargaKelasKamar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHargaKelasKamar_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaKelasKamar.Text.Equals(""))
            {
                tbHargaKelasKamar.Text = "";
            }
            else if (!string.IsNullOrEmpty(tbHargaKelasKamar.Text) && tbHargaKelasKamar.Text != "Masukkan Harga Kelas Kamar")
            {
                tbHargaKelasKamar.Text = String.Format("{0:n0}", double.Parse(tbHargaKelasKamar.Text));
                tbHargaKelasKamar.SelectionStart = tbHargaKelasKamar.Text.Length;
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
                    cobaDGKelasKamar.DataSource = list.ToList();
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
                    cobaDGKelasKamar.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGKelasKamar_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGKelasKamar.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaKelasKamar.Text = row.Cells[1].Value.ToString();
                    tbDeskripsiKelasKamar.Text = row.Cells[2].Value.ToString();
                    tbHargaKelasKamar.Text = row.Cells[3].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
