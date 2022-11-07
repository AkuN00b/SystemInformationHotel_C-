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
    public partial class FormDetailFasilitasKamar : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, temp;

        int pageNumber = 1;
        IPagedList<LoadDetailFasilitasKamar> list;

        public FormDetailFasilitasKamar()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<LoadDetailFasilitasKamar>> GetPagedListAsync(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (SI_HotelEntities21 db = new SI_HotelEntities21())
                {
                    return db.LoadDetailFasilitasKamars.OrderBy(p => p.id_dt_fasilitas_kamar).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDetailFasilitasKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sI_HotelDataSet4.Fasilitas' table. You can move, or remove it, as needed.
            this.fasilitasTableAdapter.Fill(this.sI_HotelDataSet4.Fasilitas);
            // TODO: This line of code loads data into the 'sI_HotelDataSet3.KelasKamar' table. You can move, or remove it, as needed.
            this.kelasKamarTableAdapter.Fill(this.sI_HotelDataSet3.KelasKamar);
                
            clear();
        }

        public async void clear()
        {
            pageNumber = 1;
            list = await GetPagedListAsync(1);
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            cobaDGDetailFasilitas.DataSource = list.ToList();
            lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);

            cbKelasKamar.Text = "-- Pilih Kelas Kamar --";
            cbFasilitas.Text = "-- Pilih Fasilitas --";
            tbJumlah.Text = "";

            connection.Close();
            LoadData();

            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            try
            {
                cobaDGDetailFasilitas.Columns[0].HeaderCell.Value = "ID Detail Fasilitas Kamar";
                cobaDGDetailFasilitas.Columns[1].HeaderCell.Value = "Kelas Kamar";
                cobaDGDetailFasilitas.Columns[2].HeaderCell.Value = "Fasilitas";
                cobaDGDetailFasilitas.Columns[3].HeaderCell.Value = "Jumlah";

                cobaDGDetailFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                cobaDGDetailFasilitas.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailFasilitas.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailFasilitas.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                cobaDGDetailFasilitas.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
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
                    SqlCommand view = new SqlCommand("sp_LoadDetailFasilitasKamar", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsDetailFasilitasKamar.DataSource = bindingSource1;
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
                string jumlah = tbJumlah.Text;
                
                if (jumlah == "" || cbKelasKamar.Text == "-- Pilih Kelas Kamar --" || cbFasilitas.Text == "-- Pilih Fasilitas --")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string kelas_kamar = cbKelasKamar.SelectedValue.ToString();
                    string fasilitas = cbFasilitas.SelectedValue.ToString();

                    SqlCommand insert = new SqlCommand("sp_InsertDetailFasilitasKamar", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_kelas_kamar", kelas_kamar);
                    insert.Parameters.AddWithValue("id_fasilitas", fasilitas);
                    insert.Parameters.AddWithValue("qty", jumlah);

                    connection.Open();
                    insert.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Insert Data detail fasilitas kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string jumlah = tbJumlah.Text;
            string id_fasilitas = cbFasilitas.SelectedValue.ToString();

            DialogResult d;
            d = MessageBox.Show("Apakah ingin menghapus data?", "Hapus Data Detail Fasilitas Kamar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (id == "")
            {
                MessageBox.Show("Harap isikan data detail fasilitas kamarr, tidak boleh ada yang kosong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (d == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand delete = new SqlCommand("sp_DeleteFasilitasKamar", connection);
                    delete.CommandType = CommandType.StoredProcedure;
                    delete.Parameters.AddWithValue("id_dt_fasilitas", id);
                    delete.Parameters.AddWithValue("id_fasilitas", id_fasilitas);
                    delete.Parameters.AddWithValue("qty", jumlah);

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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string jumlah = tbJumlah.Text;
                string kelas_kamar = cbKelasKamar.SelectedValue.ToString();
                string fasilitas = cbFasilitas.SelectedValue.ToString();

                if (jumlah == "" || kelas_kamar == "" || fasilitas == "")
                {
                    MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand Update = new SqlCommand("sp_UpdateDetailFasilitasKamar", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_dt_fasilitas", id);
                    Update.Parameters.AddWithValue("id_kelas_kamar", kelas_kamar);
                    Update.Parameters.AddWithValue("id_fasilitas", fasilitas);
                    Update.Parameters.AddWithValue("qty", jumlah);
                    Update.Parameters.AddWithValue("temp", temp);

                    connection.Open();
                    Update.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Ubah data detail fasilitas kamar berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsDetailFasilitasKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    // mengambil semua baris
                    DataGridViewRow row = this.dsDetailFasilitasKamar.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    cbKelasKamar.Text = row.Cells[1].Value.ToString();
                    cbFasilitas.Text = row.Cells[2].Value.ToString();
                    tbJumlah.Text = row.Cells[3].Value.ToString();
                    temp = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
                    cobaDGDetailFasilitas.DataSource = list.ToList();
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
                        SqlCommand view = new SqlCommand("sp_CariDetailFasilitasKamar", connection);
                        view.CommandType = CommandType.StoredProcedure;
                        view.Parameters.AddWithValue("cari", cari);
                        SqlDataAdapter adapter = new SqlDataAdapter(view);
                        adapter.Fill(st);
                        bindingSource1.DataSource = st;
                        cobaDGDetailFasilitas.DataSource = bindingSource1;
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

                cobaDGDetailFasilitas.Columns[0].HeaderCell.Value = "ID Detail Fasilitas Kamar";
                cobaDGDetailFasilitas.Columns[1].HeaderCell.Value = "Kelas Kamar";
                cobaDGDetailFasilitas.Columns[2].HeaderCell.Value = "Fasilitas";
                cobaDGDetailFasilitas.Columns[3].HeaderCell.Value = "Jumlah";

                cobaDGDetailFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
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
                    cobaDGDetailFasilitas.DataSource = list.ToList();
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
                    cobaDGDetailFasilitas.DataSource = list.ToList();
                    lblPageNumber.Text = String.Format("Page {0} / {1}", pageNumber, list.PageCount);
                }
            }
        }

        private void cobaDGDetailFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = this.cobaDGDetailFasilitas.Rows[e.RowIndex];

                    // transfer ke textbox
                    id = row.Cells[0].Value.ToString();
                    cbKelasKamar.Text = row.Cells[1].Value.ToString();
                    cbFasilitas.Text = row.Cells[2].Value.ToString();
                    tbJumlah.Text = row.Cells[3].Value.ToString();
                    temp = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    SqlCommand view = new SqlCommand("sp_CariDetailFasilitasKamar", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    cobaDGDetailFasilitas.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                cobaDGDetailFasilitas.Columns[0].HeaderCell.Value = "ID Detail Fasilitas Kamar";
                cobaDGDetailFasilitas.Columns[1].HeaderCell.Value = "Kelas Kamar";
                cobaDGDetailFasilitas.Columns[2].HeaderCell.Value = "Fasilitas";
                cobaDGDetailFasilitas.Columns[3].HeaderCell.Value = "Jumlah";

                cobaDGDetailFasilitas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


    }
}
