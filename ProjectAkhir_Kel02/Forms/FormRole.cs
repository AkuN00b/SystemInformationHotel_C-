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
    public partial class FormRole : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id;

        int pageNumber = 1;
        IPagedList<Role> list;

        public FormRole()
        {
            InitializeComponent();
        }   

        public async Task<IPagedList<Role>> GetPagedListAsync(int pageNumber = 1, int pageSize = 3)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities14 db = new SI_HotelEntities14())
                {
                    return db.Roles.OrderBy(p => p.id_role).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            clear();
        }   

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGRole.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            tbNamaRole.Text = "";
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
                cobaDGRole.Columns[0].HeaderCell.Value = "ID Role";
                cobaDGRole.Columns[1].HeaderCell.Value = "Nama Role";
                cobaDGRole.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                cobaDGRole.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGRole.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
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

                try
                {
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoadRole", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsRole.DataSource = bindingSource1;
                    connection.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int a = 1;

            try
            {
                string nama = tbNamaRole.Text;

                foreach (DataGridViewRow rows in dsRole.Rows)
                {
                    string data2 = rows.Cells[1].Value?.ToString();

                    if (tbNamaRole.Text.ToString().Equals(data2))
                    {
                        MessageBox.Show("Nama Role sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        a = 0;

                        return;
                    }
                }

                if (a != 0)
                {
                    if (nama == "")
                    {
                        MessageBox.Show("Mohon untuk mengisi seluruh data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        SqlCommand insert = new SqlCommand("sp_InsertRole", connection);
                        insert.CommandType = CommandType.StoredProcedure;
                        insert.Parameters.AddWithValue("nama_role", nama);

                        connection.Open();
                        insert.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Insert data role berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int a = 1;

            try
            {
                string nama = tbNamaRole.Text;

                foreach (DataGridViewRow rows in dsRole.Rows)
                {
                    string data2 = rows.Cells[1].Value?.ToString();

                    if (tbNamaRole.Text.ToString().Equals(data2))
                    {
                        MessageBox.Show("Nama Role sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        a = 0;
                        return;
                    }
                }

                if (a != 0)
                {
                    if (nama == "")
                    {
                        MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand Update = new SqlCommand("sp_UpdateRole", connection);
                        Update.CommandType = CommandType.StoredProcedure;
                        Update.Parameters.AddWithValue("id_role", id);
                        Update.Parameters.AddWithValue("nama_role", nama);

                        connection.Open();
                        Update.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Update data role berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Apakah ingin menghapus data role?", "Hapus Data Role", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (id == "")
            {
                MessageBox.Show("Harap isikan data role, tidak boleh ada yang kosong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (d == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand delete = new SqlCommand("sp_DeleteRole", connection);
                    delete.CommandType = CommandType.StoredProcedure;
                    delete.Parameters.AddWithValue("id_role", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Data role berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data role batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
        }

        private void dsRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    // mengambil semua baris
                    DataGridViewRow row = this.dsRole.Rows[e.RowIndex];

                    // transfer ke textbo
                    id = row.Cells[0].Value.ToString();
                    tbNamaRole.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dsRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbNamaRole_KeyPress(object sender, KeyPressEventArgs e)
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
                    SqlCommand view = new SqlCommand("sp_CariRole", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGRole.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGRole.Columns[0].HeaderCell.Value = "ID Role";
                cobaDGRole.Columns[1].HeaderCell.Value = "Nama Role";
                cobaDGRole.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbNamaRole_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbNamaRole_Leave(object sender, EventArgs e)
        {
            
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void tbSearch_Leave(object sender, EventArgs e)
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
                    cobaDGRole.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariRole", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGRole.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }

                    cobaDGRole.Columns[0].HeaderCell.Value = "ID Role";
                    cobaDGRole.Columns[1].HeaderCell.Value = "Nama Role";
                    cobaDGRole.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    cobaDGRole.DataSource = list.ToList();
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
                    cobaDGRole.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGRole_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGRole.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    tbNamaRole.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tbSearch_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
