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
    public partial class FormDetailUser : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id = "";

        int pageNumber = 1;
        IPagedList<DetailUser> list;

        public FormDetailUser()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<DetailUser>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities15 db = new SI_HotelEntities15())
                {
                    return db.DetailUsers.OrderBy(p => p.id).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void tbAlamatUser_Click(object sender, EventArgs e)
        {
            
        }

        private void tbAlamatUser_Enter(object sender, EventArgs e)
        {
            if (tbAlamatUser.Text == "Masukkan Alamat User")
            {
                tbAlamatUser.Text = "";
            }
        }

        private void tbAlamatUser_Leave(object sender, EventArgs e)
        {
            if (tbAlamatUser.Text == "")
            {
                tbAlamatUser.Text = "Masukkan Alamat User";
            }
        }

        private void FormDetailUser_Load(object sender, EventArgs e)
        {
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGDetailUser.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaUser.Text = "";
            tbNIKUser.Text = "Masukkan NIK User";
            dpTanggalLahir.Value = DateTime.Today.Date;
            tbUmur.Text = "";
            tbAlamatUser.Text = "Masukkan Alamat User";
            tbSearch.Text = "";

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGDetailUser.Columns[0].HeaderCell.Value = "ID User";
                cobaDGDetailUser.Columns[1].HeaderCell.Value = "Nama User";
                cobaDGDetailUser.Columns[2].HeaderCell.Value = "NIK User";
                cobaDGDetailUser.Columns[3].HeaderCell.Value = "Tanggal Lahir";
                cobaDGDetailUser.Columns[4].HeaderCell.Value = "Alamat";
                cobaDGDetailUser.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGDetailUser.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailUser.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailUser.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailUser.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailUser.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            } catch (Exception ex)
            {

            }
        }

        public void LoadData()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadDetailUser", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsDetailUser.DataSource = bindingSource1;
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error" + ex);
            }

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = tbNamaUser.Text;
            string nik = tbNIKUser.Text;
            string alamat = tbAlamatUser.Text;

            if (nama == "" || nik == "" || alamat == "")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand insert = new SqlCommand("sp_InsertDetailUser", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("nama", nama);
                insert.Parameters.AddWithValue("nik", nik);
                insert.Parameters.AddWithValue("tanggal_lahir", dpTanggalLahir.Value);
                insert.Parameters.AddWithValue("alamat", alamat);

                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Insert data detail user berhasil !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            d = MessageBox.Show("Yakin hapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("sp_DeleteDetailUser", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("id", id);

                try
                {
                    delete.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data detail user berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string nama = tbNamaUser.Text;
                string nik = tbNIKUser.Text;
                string alamat = tbAlamatUser.Text;

                if (nama == "" || nik == "" || alamat == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand Update = new SqlCommand("sp_UpdateDetailUser", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id", id);
                    Update.Parameters.AddWithValue("nama", nama);
                    Update.Parameters.AddWithValue("nik", nik);
                    Update.Parameters.AddWithValue("tanggal_lahir", dpTanggalLahir.Value);
                    Update.Parameters.AddWithValue("alamat", alamat);

                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Update data detail user berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            clear();
        }

        private void dsDetailUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsDetailUser.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaUser.Text = row.Cells[1].Value.ToString();
                    tbNIKUser.Text = row.Cells[2].Value.ToString();
                    dpTanggalLahir.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                    tbUmur.Text = hitungUmur(Convert.ToDateTime(row.Cells[3].Value.ToString())).ToString() + " Tahun";
                    tbAlamatUser.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        public int hitungUmur(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age = age - 1;
            }

            return age;
        }

        private void tbNIKUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tbNamaUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearch.Text;

                btnNext.Enabled = false;
                btnPrevious.Enabled = false;

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariDetailUser", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGDetailUser.DataSource = bindingSource1;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGDetailUser.Columns[0].HeaderCell.Value = "ID User";
                cobaDGDetailUser.Columns[1].HeaderCell.Value = "Nama User";
                cobaDGDetailUser.Columns[2].HeaderCell.Value = "NIK User";
                cobaDGDetailUser.Columns[3].HeaderCell.Value = "Tanggal Lahir";
                cobaDGDetailUser.Columns[4].HeaderCell.Value = "Alamat";
                cobaDGDetailUser.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dpTanggalLahir_onValueChanged(object sender, EventArgs e)
        {
            int hasil = hitungUmur(dpTanggalLahir.Value);

            if (hasil < 0)
            {
                MessageBox.Show("Data tanggal lahir tidak boleh melebihi hari ini", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpTanggalLahir.Value = DateTime.Today.Date;
                tbUmur.Text = "";
            } else
            {
                tbUmur.Text = hasil.ToString() + " Tahun";
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
                    cobaDGDetailUser.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                } else
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
                        SqlCommand view = new SqlCommand("sp_CariDetailUser", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGDetailUser.DataSource = bindingSource1;
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }

                    cobaDGDetailUser.Columns[0].HeaderCell.Value = "ID User";
                    cobaDGDetailUser.Columns[1].HeaderCell.Value = "Nama User";
                    cobaDGDetailUser.Columns[2].HeaderCell.Value = "NIK User";
                    cobaDGDetailUser.Columns[3].HeaderCell.Value = "Tanggal Lahir";
                    cobaDGDetailUser.Columns[4].HeaderCell.Value = "Alamat";
                    cobaDGDetailUser.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbNIKUser_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNIKUser_Enter(object sender, EventArgs e)
        {
            if (tbNIKUser.Text == "Masukkan NIK User")
            {
                tbNIKUser.Text = "";
            }
        }

        private void tbNIKUser_Leave(object sender, EventArgs e)
        {
            if (tbNIKUser.Text == "")
            {
                tbNIKUser.Text = "Masukkan NIK User";
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
                    cobaDGDetailUser.DataSource = list.ToList();
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
                    cobaDGDetailUser.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGDetailUser_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGDetailUser.Rows[e.RowIndex];
                    //transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaUser.Text = row.Cells[1].Value.ToString();
                    tbNIKUser.Text = row.Cells[2].Value.ToString();
                    dpTanggalLahir.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                    tbUmur.Text = hitungUmur(Convert.ToDateTime(row.Cells[3].Value.ToString())).ToString() + " Tahun";
                    tbAlamatUser.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
