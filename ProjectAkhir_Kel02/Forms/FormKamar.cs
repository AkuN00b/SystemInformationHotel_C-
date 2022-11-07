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
    public partial class FormKamar : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id;

        int pageNumber = 1;
        IPagedList<LoadKamar> list;

        public FormKamar()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<LoadKamar>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities17 db = new SI_HotelEntities17())
                {
                    return db.LoadKamars.OrderBy(p => p.id_kamar).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void FormKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sI_HotelDataSet2.JenisKamar' table. You can move, or remove it, as needed.
            this.jenisKamarTableAdapter.Fill(this.sI_HotelDataSet2.JenisKamar);
            // TODO: This line of code loads data into the 'sI_HotelDataSet1.KelasKamar' table. You can move, or remove it, as needed.
            this.kelasKamarTableAdapter.Fill(this.sI_HotelDataSet1.KelasKamar);
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGKamar.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            cbKelasKamar.Text = "-- Pilih Kelas Kamar --";
            cbJenisKamar.Text = "-- Pilih Jenis Kamar --";

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGKamar.Columns[0].HeaderCell.Value = "ID Kamar";
                cobaDGKamar.Columns[1].HeaderCell.Value = "Kelas Kamar";
                cobaDGKamar.Columns[2].HeaderCell.Value = "Jenis Kamar";
                cobaDGKamar.Columns[3].HeaderCell.Value = "Status Kamar";

                cobaDGKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                cobaDGKamar.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGKamar.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGKamar.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGKamar.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
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
                    SqlCommand view = new SqlCommand("sp_LoadKamar", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsKamar.DataSource = bindingSource1;
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                IDOtomatis a = new IDOtomatis();
                string sp = "sp_IdKamar";
                a.setID("KMR", sp);

                id = a.getID();

                if (cbKelasKamar.Text == "-- Pilih Kelas Kamar --" || cbJenisKamar.Text == "-- Pilih Jenis Kamar --")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    string kelas = cbKelasKamar.SelectedValue.ToString();
                    string jenis = cbJenisKamar.SelectedValue.ToString();

                    SqlCommand insert = new SqlCommand("sp_InsertKamarAutoID", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    // insert.Parameters.AddWithValue("id_kamar", id);
                    insert.Parameters.AddWithValue("id_kelas_kamar", kelas);
                    insert.Parameters.AddWithValue("id_jenis_kamar", jenis);
                    insert.Parameters.AddWithValue("status_kamar", 1);

                    connection.Open();
                    insert.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Insert data kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
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
            d = MessageBox.Show("Apakah ingin menghapus data kamar?", "Hapus Data Kamar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (id == "")
            {
                MessageBox.Show("Harap isikan data kamar, tidak boleh ada yang kosong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (d == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand delete = new SqlCommand("sp_DeleteKamar", connection);
                    delete.CommandType = CommandType.StoredProcedure;
                    delete.Parameters.AddWithValue("id_kamar", id);

                    try
                    {
                        delete.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Data kamar berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data kamar batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string kelas = cbKelasKamar.SelectedValue.ToString();
                string jenis = cbJenisKamar.SelectedValue.ToString();

                if (kelas == "" || jenis == "")
                {
                    MessageBox.Show("Harap isikan data kamar, tidak boleh ada yang kosong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand Update = new SqlCommand("sp_UpdateKamar", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_kamar", id);
                    Update.Parameters.AddWithValue("id_kelas_kamar", kelas);
                    Update.Parameters.AddWithValue("id_jenis_kamar", jenis);

                    connection.Open();
                    Update.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Update data kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsKamar_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    SqlCommand view = new SqlCommand("sp_CariKamar", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGKamar.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGKamar.Columns[0].HeaderCell.Value = "ID Kamar";
                cobaDGKamar.Columns[1].HeaderCell.Value = "Kelas Kamar";
                cobaDGKamar.Columns[2].HeaderCell.Value = "Jenis Kamar";

                cobaDGKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    // mengambil semua baris
                    DataGridViewRow row = this.dsKamar.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    cbKelasKamar.Text = row.Cells[1].Value.ToString();
                    cbJenisKamar.Text = row.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    cobaDGKamar.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariKamar", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGKamar.DataSource = bindingSource1;
                        connection.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGKamar.Columns[0].HeaderCell.Value = "ID Kamar";
                cobaDGKamar.Columns[1].HeaderCell.Value = "Kelas Kamar";
                cobaDGKamar.Columns[2].HeaderCell.Value = "Jenis Kamar";

                cobaDGKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
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
                    cobaDGKamar.DataSource = list.ToList();
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
                    cobaDGKamar.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGKamar_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGKamar.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    cbKelasKamar.Text = row.Cells[1].Value.ToString();
                    cbJenisKamar.Text = row.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
