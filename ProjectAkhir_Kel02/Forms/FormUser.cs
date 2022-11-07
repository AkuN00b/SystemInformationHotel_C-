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
using System.Text.RegularExpressions;
using PagedList;

namespace ProjectAkhir_Kel02.Forms
{
    public partial class FormUser : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id;

        int pageNumber = 1;
        IPagedList<LoadUser> list;

        public FormUser()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<LoadUser>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities16 db = new SI_HotelEntities16())
                {
                    return db.LoadUsers.OrderBy(p => p.id_user).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sI_HotelDataSet7.DetailUser' table. You can move, or remove it, as needed.
            this.detailUserTableAdapter.Fill(this.sI_HotelDataSet7.DetailUser);

            // TODO: This line of code loads data into the 'sI_HotelDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.sI_HotelDataSet.Role);

            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGUser.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNama.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbPassword.isPassword = false;
            cbRole.Text = "-- Pilih Role User --";
            cbUser.Text = "-- Pilih User --";
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
                cobaDGUser.Columns[0].HeaderCell.Value = "ID User";
                cobaDGUser.Columns[1].HeaderCell.Value = "Username";
                cobaDGUser.Columns[2].HeaderCell.Value = "Email User";
                cobaDGUser.Columns[3].HeaderCell.Value = "Password User";
                cobaDGUser.Columns[4].HeaderCell.Value = "Role User";
                cobaDGUser.Columns[5].HeaderCell.Value = "Nama User";

                cobaDGUser.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                cobaDGUser.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGUser.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGUser.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGUser.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGUser.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGUser.Columns[5].DefaultCellStyle.ForeColor = Color.Black;
            } catch (Exception ex) { }
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
                    SqlCommand view = new SqlCommand("sp_LoadUser", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsUser.DataSource = bindingSource1;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                IDOtomatis a = new IDOtomatis();
                string sp = "sp_IdUser";
                a.setID("USR", sp);

                id = a.getID();
                string nama = tbNama.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                Regex validateEmailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
                Match match = validateEmailRegex.Match(tbEmail.Text);

                if (nama == "" || email == "" || password == "" || cbRole.Text == "-- Pilih Role User --" || cbUser.Text == "-- Pilih User --")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else if (!(match.Success))
                {
                    MessageBox.Show("Email tidak sesuai format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else if (tbPassword.Text.Length < 7)
                {
                    MessageBox.Show("Password kurang dari 8 karakter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string id_role = cbRole.SelectedValue.ToString();
                    string id_user = cbUser.SelectedValue.ToString();

                    SqlCommand insert = new SqlCommand("sp_InsertUserAutoID", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    // insert.Parameters.AddWithValue("id_user", id);
                    insert.Parameters.AddWithValue("nama_user", nama);
                    insert.Parameters.AddWithValue("email_user", email);
                    insert.Parameters.AddWithValue("password", password);
                    insert.Parameters.AddWithValue("id_role", id_role);
                    insert.Parameters.AddWithValue("id_user", id_user);

                    connection.Open();
                    insert.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Insert data user berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void hapusbtn_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Apakah ingin menghapus data user", "Hapus Data User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (id == "")
            {
                MessageBox.Show("Harap isikan data user, tidak boleh ada yang kosong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (d == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand delete = new SqlCommand("sp_DeleteUser", connection);
                    delete.CommandType = CommandType.StoredProcedure;
                    delete.Parameters.AddWithValue("id_user", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Data user berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data user batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
        }

        private void batalbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNama.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                string id_role = cbRole.SelectedValue.ToString();
                string id_user = cbUser.SelectedValue.ToString();

                if (nama == "" || email == "" || password == "" || id_role == "" || id_user == "")
                {
                    MessageBox.Show("Mohon untuk nengisi seluruh data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand Update = new SqlCommand("sp_UpdateUser", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_user", id);
                    Update.Parameters.AddWithValue("nama_user", nama);
                    Update.Parameters.AddWithValue("email_user", email);
                    Update.Parameters.AddWithValue("password", password);
                    Update.Parameters.AddWithValue("id_role", id_role);
                    Update.Parameters.AddWithValue("id_dt_user", id_user);

                    connection.Open();
                    Update.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Update data user berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    // mengambil semua baris
                    DataGridViewRow row = this.dsUser.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    tbNama.Text = row.Cells[1].Value.ToString();
                    tbEmail.Text = row.Cells[2].Value.ToString();
                    tbPassword.Text = row.Cells[3].Value.ToString();
                    cbRole.Text = row.Cells[4].Value.ToString();
                    cbUser.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
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

                btnNext.Enabled = false;
                btnPrevious.Enabled = false;

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariUser", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGUser.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGUser.Columns[0].HeaderCell.Value = "ID User";
                cobaDGUser.Columns[1].HeaderCell.Value = "Username";
                cobaDGUser.Columns[2].HeaderCell.Value = "Email User";
                cobaDGUser.Columns[3].HeaderCell.Value = "Password User";
                cobaDGUser.Columns[4].HeaderCell.Value = "Role User";
                cobaDGUser.Columns[5].HeaderCell.Value = "Nama User";

                cobaDGUser.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }

        private void btnSeek_Click(object sender, EventArgs e)
        {
            if (tbPassword.isPassword == true)
            {
                tbPassword.isPassword = false;
            }
            else
            {
                tbPassword.isPassword = true;
            }
        }

        private void tbNama_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tbNama_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tbNama_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_Enter(object sender, EventArgs e)
        {

        }

        private void tbNama_Leave(object sender, EventArgs e)
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
                    cobaDGUser.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariUser", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGUser.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }

                    cobaDGUser.Columns[0].HeaderCell.Value = "ID User";
                    cobaDGUser.Columns[1].HeaderCell.Value = "Username";
                    cobaDGUser.Columns[2].HeaderCell.Value = "Email User";
                    cobaDGUser.Columns[3].HeaderCell.Value = "Password User";
                    cobaDGUser.Columns[4].HeaderCell.Value = "Role User";
                    cobaDGUser.Columns[5].HeaderCell.Value = "Nama User";

                    cobaDGUser.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void FormUser_Enter(object sender, EventArgs e)
        {

        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {

        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {

        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {

        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {

        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {

        }

        private void dsUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
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
                    cobaDGUser.DataSource = list.ToList();
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
                    cobaDGUser.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGUser_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    // mengambil semua baris
                    DataGridViewRow row = this.cobaDGUser.Rows[e.RowIndex];

                    // transfer ke text box
                    id = row.Cells[0].Value.ToString();
                    tbNama.Text = row.Cells[1].Value.ToString();
                    tbEmail.Text = row.Cells[2].Value.ToString();
                    tbPassword.Text = row.Cells[3].Value.ToString();
                    cbRole.Text = row.Cells[4].Value.ToString();
                    cbUser.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
