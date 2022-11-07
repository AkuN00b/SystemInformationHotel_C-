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
    public partial class FormMenuMakanan : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id = "";

        int pageNumber = 1;
        IPagedList<LoadMenu> list;

        public FormMenuMakanan()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<LoadMenu>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities22 db = new SI_HotelEntities22())
                {
                    return db.LoadMenus.OrderBy(p => p.id_menu_makanan).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id_jenis = cbJenisMenu.SelectedValue.ToString();
                string nama = tbNamaMenu.Text;
                string harga = tbHargaMenu.Text;
                string deskripsi = tbDeskripsiMenu.Text;
                string status;
                if (rbTersedia.Checked)
                {
                    status = "1";
                }
                else
                {
                    status = "0";
                }

                if (id_jenis == "" || nama == "" || harga == "Masukkan Harga Menu" || deskripsi == "Masukkan Deskripsi Menu" || status == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand Update = new SqlCommand("sp_UpdateMenu", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_menu", id);
                    Update.Parameters.AddWithValue("id_jenis_menu", id_jenis);
                    Update.Parameters.AddWithValue("nama_menu", nama);
                    Update.Parameters.AddWithValue("harga_menu", harga);
                    Update.Parameters.AddWithValue("deskripsi_menu", deskripsi);
                    Update.Parameters.AddWithValue("status_menu", status);

                    connection.Open();
                    Update.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Update data menu berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tbHargaKelasKamar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDeskripsiJenisMakanan_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Apakah ingin menghapus data?", "Hapus Data User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (id == "")
            {
                MessageBox.Show("Harap isikan data menu, tidak boleh ada yang kosong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (d == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand delete = new SqlCommand("sp_DeleteMenu", connection);
                    delete.CommandType = CommandType.StoredProcedure;
                    delete.Parameters.AddWithValue("id_menu", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                IDOtomatis a = new IDOtomatis();
                string sp = "sp_IdMenu";
                a.setID("MN", sp);

                id = a.getID();
                string nama = tbNamaMenu.Text;
                string harga = tbHargaMenu.Text;
                string deskripsi = tbDeskripsiMenu.Text;
                string status;

                if (rbTersedia.Checked)
                {
                    status = "1";
                } else
                {
                    status = "0";
                }

                if (cbJenisMenu.Text == "-- Pilih Jenis Menu --" || nama == "" || harga == "Masukkan Harga Menu" || deskripsi == "Masukkan Deskripsi Menu" || status == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string id_jenis = cbJenisMenu.SelectedValue.ToString();

                    SqlCommand insert = new SqlCommand("sp_InsertMenu", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_menu", id);
                    insert.Parameters.AddWithValue("id_jenis_menu", id_jenis);
                    insert.Parameters.AddWithValue("nama_menu", nama);
                    insert.Parameters.AddWithValue("harga_menu", harga);
                    insert.Parameters.AddWithValue("deskripsi_menu", deskripsi);
                    insert.Parameters.AddWithValue("status_menu", status);

                    connection.Open();
                    insert.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Insert Data menu berhasil disimpan ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuMakanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sI_HotelDataSet5.JenisMenu' table. You can move, or remove it, as needed.
            this.jenisMenuTableAdapter.Fill(this.sI_HotelDataSet5.JenisMenu);
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGMenu.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            cbJenisMenu.Text = "-- Pilih Jenis Menu --";
            tbNamaMenu.Text = "";
            tbHargaMenu.Text = "Masukkan Harga Menu";
            tbDeskripsiMenu.Text = "Masukkan Deskripsi Menu";
            rbTersedia.Checked = false;
            rbTidakTersedia.Checked = false;

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGMenu.Columns[0].HeaderCell.Value = "ID Menu";
                cobaDGMenu.Columns[1].HeaderCell.Value = "Jenis Menu";
                cobaDGMenu.Columns[2].HeaderCell.Value = "Nama Menu";
                cobaDGMenu.Columns[3].HeaderCell.Value = "Harga Menu";
                cobaDGMenu.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGMenu.Columns[4].HeaderCell.Value = "Deskripsi Menu";
                cobaDGMenu.Columns[5].HeaderCell.Value = "Status Menu";

                cobaDGMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                cobaDGMenu.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGMenu.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGMenu.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGMenu.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGMenu.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGMenu.Columns[5].DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex) { }
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
                    SqlCommand view = new SqlCommand("sp_LoadMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsMenuMakanan.DataSource = bindingSource1;
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

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dsMenuMakanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    // mengambil semua baris
                    DataGridViewRow row = this.dsMenuMakanan.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    cbJenisMenu.Text = row.Cells[1].Value.ToString();
                    tbNamaMenu.Text = row.Cells[2].Value.ToString();
                    tbHargaMenu.Text = row.Cells[3].Value.ToString();
                    tbDeskripsiMenu.Text = row.Cells[4].Value.ToString();
                    string status = row.Cells[5].Value.ToString();

                    if (status == "Tersedia")
                    {
                        rbTersedia.Checked = true;
                    } else
                    {
                        rbTersedia.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tbNamaMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbHargaMenu_KeyPress(object sender, KeyPressEventArgs e)
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
                    SqlCommand view = new SqlCommand("sp_CariMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGMenu.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGMenu.Columns[0].HeaderCell.Value = "ID Menu";
                cobaDGMenu.Columns[1].HeaderCell.Value = "Jenis Menu";
                cobaDGMenu.Columns[2].HeaderCell.Value = "Nama Menu";
                cobaDGMenu.Columns[3].HeaderCell.Value = "Harga Menu";
                cobaDGMenu.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGMenu.Columns[4].HeaderCell.Value = "Deskripsi Menu";
                cobaDGMenu.Columns[5].HeaderCell.Value = "Status Menu";

                cobaDGMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbDeskripsiMenu_Enter(object sender, EventArgs e)
        {
            if (tbDeskripsiMenu.Text == "Masukkan Deskripsi Menu")
            {
                tbDeskripsiMenu.Text = "";
            }
        }

        private void tbDeskripsiMenu_Leave(object sender, EventArgs e)
        {
            if (tbDeskripsiMenu.Text == "")
            {
                tbDeskripsiMenu.Text = "Masukkan Deskripsi Menu";
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
                    cobaDGMenu.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariMenu", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGMenu.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGMenu.Columns[0].HeaderCell.Value = "ID Menu";
                cobaDGMenu.Columns[1].HeaderCell.Value = "Jenis Menu";
                cobaDGMenu.Columns[2].HeaderCell.Value = "Nama Menu";
                cobaDGMenu.Columns[3].HeaderCell.Value = "Harga Menu";
                cobaDGMenu.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                cobaDGMenu.Columns[4].HeaderCell.Value = "Deskripsi Menu";
                cobaDGMenu.Columns[5].HeaderCell.Value = "Status Menu";

                cobaDGMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbHargaMenu_Enter(object sender, EventArgs e)
        {
            if (tbHargaMenu.Text == "Masukkan Harga Menu")
            {
                tbHargaMenu.Text = "";
            }
        }

        private void tbHargaMenu_Leave(object sender, EventArgs e)
        {
            if (tbHargaMenu.Text == "")
            {
                tbHargaMenu.Text = "Masukkan Harga Menu";
            }
        }

        private void tbHargaMenu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHargaMenu_TextChanged(object sender, EventArgs e)
        {
            if (tbHargaMenu.Text.Equals(""))
            {
                tbHargaMenu.Text = "";
            }
            else if (!string.IsNullOrEmpty(tbHargaMenu.Text) && tbHargaMenu.Text != "Masukkan Harga Menu")
            {
                tbHargaMenu.Text = String.Format("{0:n0}", double.Parse(tbHargaMenu.Text));
                tbHargaMenu.SelectionStart = tbHargaMenu.Text.Length;
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
                    cobaDGMenu.DataSource = list.ToList();
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
                    cobaDGMenu.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGMenu_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGMenu.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    cbJenisMenu.Text = row.Cells[1].Value.ToString();
                    tbNamaMenu.Text = row.Cells[2].Value.ToString();
                    tbHargaMenu.Text = row.Cells[3].Value.ToString();
                    tbDeskripsiMenu.Text = row.Cells[4].Value.ToString();
                    string status = row.Cells[5].Value.ToString();

                    if (status == "Tersedia")
                    {
                        rbTersedia.Checked = true;
                    }
                    else
                    {
                        rbTersedia.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
