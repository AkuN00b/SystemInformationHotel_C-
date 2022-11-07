using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Kel02.Forms.Customer
{
    public partial class FormBeliMenu : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, id_kamar, id_menu, id_customer, hari, id_receptionist, harga_kelas, harga_jenis, id_tr_kamar;
        Double harga, total_harga, tempHarga, a;
        string[] user;

        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchMenu.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariMenuTransaksi", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsMenu.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsMenu.Columns[0].HeaderCell.Value = "ID Menu";
                dsMenu.Columns[1].HeaderCell.Value = "Jenis Menu";
                dsMenu.Columns[2].HeaderCell.Value = "Nama Menu";
                dsMenu.Columns[3].HeaderCell.Value = "Harga Menu";
                dsMenu.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsMenu.Columns[4].HeaderCell.Value = "Deskripsi Menu";
                dsMenu.Columns[5].HeaderCell.Value = "Status Menu";
                dsMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDetailPembelian_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbDetailPembelian.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariDetailTrsMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    view.Parameters.AddWithValue("id_tr_dapur", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsDetailPembelian.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsDetailPembelian.Columns[0].HeaderCell.Value = "ID Transaksi Menu";
                dsDetailPembelian.Columns[1].Visible = false;
                dsDetailPembelian.Columns[2].HeaderCell.Value = "Nama Menu";
                dsDetailPembelian.Columns[3].HeaderCell.Value = "Jumlah";
                dsDetailPembelian.Columns[4].HeaderCell.Value = "Total Harga";
                dsDetailPembelian.Columns[4].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsDetailPembelian.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsDetailPembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTambahMenu.Enabled = false;
            btnEditMenu.Enabled = true;
            btnHapusMenu.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    // mengambil semua baris
                    DataGridViewRow row = this.dsDetailPembelian.Rows[e.RowIndex];

                    // transfer ke textbox
                    id_menu = row.Cells[1].Value.ToString();
                    tbMenu.Text = row.Cells[2].Value.ToString();
                    tbJumlah.Text = row.Cells[3].Value.ToString();
                    tempHarga = Double.Parse(row.Cells[4].Value.ToString());
                    harga = tempHarga / Double.Parse(tbJumlah.Text);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string jumlah = tbJumlah.Text;

                if (jumlah == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    total_harga = Double.Parse(jumlah) * harga;
                    tempHarga = total_harga - tempHarga;
                    a = (tempHarga + Double.Parse(tbTotalHarga.Text));
                    string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                    tbTotalHarga.Text = kembali;

                    SqlCommand Update = new SqlCommand("sp_UpdateDetailTrsMenu", connection);
                    Update.CommandType = CommandType.StoredProcedure;
                    Update.Parameters.AddWithValue("id_tr_dapur", id);
                    Update.Parameters.AddWithValue("id_menu_makanan", id_menu);
                    Update.Parameters.AddWithValue("qty", jumlah);
                    Update.Parameters.AddWithValue("total_harga", total_harga);
                    Update.Parameters.AddWithValue("tempHarga", tempHarga);

                    Update.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data berhasil diupdate dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            btnTambahMenu.Enabled = true;
            btnEditMenu.Enabled = false;
            btnHapusMenu.Enabled = false;
            LoadDetailTrsMenu();
        }

        private void btnHapusMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand Delete = new SqlCommand("sp_DeleteTransaksiMenu", connection);
                Delete.CommandType = CommandType.StoredProcedure;
                Delete.Parameters.AddWithValue("id_tr_dapur", id);
                Delete.Parameters.AddWithValue("id_menu_makanan", id_menu);
                Delete.Parameters.AddWithValue("harga", tempHarga);

                a = (Double.Parse(tbTotalHarga.Text) - tempHarga);
                string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                tbTotalHarga.Text = kembali;

                Delete.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Pembelian Menu berhasil dihapus dengan ID " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            btnTambahMenu.Enabled = true;
            btnEditMenu.Enabled = false;
            btnHapusMenu.Enabled = false;
            connection.Close();
            LoadDetailTrsMenu();
        }

        private void btnTambahMenu_Click(object sender, EventArgs e)
        {
            string jumlah = tbJumlah.Text;

            if (id_menu == "" || jumlah == "" || id_customer == "" || id_kamar == "")
            {
                MessageBox.Show("Harap isikan data dengan benar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                total_harga = Double.Parse(jumlah) * harga;
                SqlCommand insert = new SqlCommand("sp_InsertDetailTrsPembelianCus", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_tr_dapur", id);
                insert.Parameters.AddWithValue("id_tr_kamar", id_tr_kamar);
                insert.Parameters.AddWithValue("id_menu_makanan", id_menu);
                insert.Parameters.AddWithValue("qty", jumlah);
                insert.Parameters.AddWithValue("total_harga", total_harga);
                insert.Parameters.AddWithValue("id_customer", id_customer);
                insert.Parameters.AddWithValue("id_kamar", id_kamar);
                insert.Parameters.AddWithValue("tgl_transaksi", DateTime.Now);

                if (tbTotalHarga.Text == "0")
                {
                    a = (total_harga);
                    string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                    tbTotalHarga.Text = kembali;
                }
                else
                {
                    a = total_harga + Double.Parse(tbTotalHarga.Text);
                    string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                    tbTotalHarga.Text = kembali;
                }

                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data transaksi pembelian berhasil disimpan ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    harga = 0;
                    total_harga = 0;
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Error" + ex);
                }
            }

            tbMenu.Text = "";
            tbJumlah.Text = "";
            connection.Close();
            LoadDetailTrsMenu();
        }

        private void btnHapusSemuaMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand Delete = new SqlCommand("sp_DeleteAllTransaksiMenu", connection);
                Delete.CommandType = CommandType.StoredProcedure;
                Delete.Parameters.AddWithValue("id_tr_dapur", id);

                tbTotalHarga.Text = "0";

                Delete.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Pembelian Menu berhasil dihapus pada ID Transaksi: " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            btnTambahMenu.Enabled = true;
            btnEditMenu.Enabled = false;
            btnHapusMenu.Enabled = false;
            connection.Close();
            LoadDetailTrsMenu();
        }

        private void btnBatalPembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand Delete = new SqlCommand("sp_DeleteTransaksi", connection);
                Delete.CommandType = CommandType.StoredProcedure;
                Delete.Parameters.AddWithValue("id_tr_dapur", id);

                Delete.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Transaksi dibatalkan pada ID Transaksi: " + id, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            clear();
        }

        private void btnTerbayar_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchMenu.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariMenuTransaksi", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsMenu.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsMenu.Columns[0].HeaderCell.Value = "ID Menu";
                dsMenu.Columns[1].HeaderCell.Value = "Jenis Menu";
                dsMenu.Columns[2].HeaderCell.Value = "Nama Menu";
                dsMenu.Columns[3].HeaderCell.Value = "Harga Menu";
                dsMenu.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsMenu.Columns[4].HeaderCell.Value = "Deskripsi Menu";
                dsMenu.Columns[5].HeaderCell.Value = "Status Menu";
                dsMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbDetailPembelian_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbDetailPembelian.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariDetailTrsMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    view.Parameters.AddWithValue("id_tr_dapur", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsDetailPembelian.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsDetailPembelian.Columns[0].HeaderCell.Value = "ID Transaksi Menu";
                dsDetailPembelian.Columns[1].Visible = false;
                dsDetailPembelian.Columns[2].HeaderCell.Value = "Nama Menu";
                dsDetailPembelian.Columns[3].HeaderCell.Value = "Jumlah";
                dsDetailPembelian.Columns[4].HeaderCell.Value = "Total Harga";
                dsDetailPembelian.Columns[4].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsDetailPembelian.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsMenu.Rows[e.RowIndex];

                    //transfer ke textbox
                    tbMenu.Text = row.Cells[2].Value.ToString();
                    id_menu = row.Cells[0].Value.ToString();
                    harga = Double.Parse(row.Cells[3].Value.ToString());

                    if (tbJumlah.Text != "")
                    {
                        total_harga = harga * long.Parse(tbJumlah.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 0 Proses Pemesanan
            // 1 Belum Dibayar
            // 2 Dibayar

            total_harga = Double.Parse(tbTotalHarga.Text);

            SqlCommand insert = new SqlCommand("sp_UpdatePembayaranTransaksiMenu", connection);
            insert.CommandType = CommandType.StoredProcedure;
            insert.Parameters.AddWithValue("id_tr_dapur", id);
            insert.Parameters.AddWithValue("total_harga", total_harga);
            insert.Parameters.AddWithValue("status_transaksi", 1);

            connection.Open();
            insert.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Transaksi berhasil disimpan, status belum dibayar !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        public FormBeliMenu(string[] data)
        {
            InitializeComponent();
            id_customer = data[0];

            user = data;
        }

        private string loading()
        {
            IDOtomatis a = new IDOtomatis();
            string sp = "sp_IDTransaksiPembelian";
            a.setID("TP", sp);
            string id = a.getID();
            return id;

        }

        private void FormBeliMenu_Load(object sender, EventArgs e)
        {
            clear();
        }

        public void LoadCheckIn()
        {
            connection.Open();
            DataTable st = new DataTable();
            SqlCommand view = new SqlCommand("sp_StatusCheckIn", connection);
            view.CommandType = CommandType.StoredProcedure;
            view.Parameters.AddWithValue("id_customer", id_customer);
            SqlDataAdapter adapter = new SqlDataAdapter(view);
            adapter.Fill(st);
            connection.Close();

            if (st.Rows.Count != 0)
            {
                tbCustomer.Text = st.Rows[0][1].ToString();
                tbKamar.Text = st.Rows[0][2].ToString() + " - " + st.Rows[0][3].ToString() + " - " + st.Rows[0][4].ToString();

                id_customer = st.Rows[0][0].ToString();
                id_kamar = st.Rows[0][2].ToString();

                id_tr_kamar = st.Rows[0][5].ToString();
            } else
            {
                MessageBox.Show("Anda sudah checkout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                disabled();
            }
        }

        public void disabled()
        {
            tbJumlah.Enabled = false;
            btnTambahMenu.Enabled = false;
            btnEditMenu.Enabled = false;
            btnHapusMenu.Enabled = false;
            btnHapusSemuaMenu.Enabled = false;
            btnBatalPembayaran.Enabled = false;
            btnSimpan.Enabled = false;
            tbSearchMenu.Enabled = false;
            btnSearchMenu.Enabled = false;
            dsMenu.Enabled = false;
            tbDetailPembelian.Enabled = false;
            btnDetailPembelian.Enabled = false;
            dsDetailPembelian.Enabled = false;
        }

        public void clear()
        {
            tbMenu.Text = "";
            tbJumlah.Text = "";
            btnEditMenu.Enabled = false;
            btnHapusMenu.Enabled = false;
            tbTotalHarga.Text = "0";

            connection.Close();
            id = loading();
            LoadMenu();
            LoadDetailTrsMenu();

            LoadCheckIn();

            dsMenu.Columns[0].HeaderCell.Value = "ID Menu";
            dsMenu.Columns[1].HeaderCell.Value = "Jenis Menu";
            dsMenu.Columns[2].HeaderCell.Value = "Nama Menu";
            dsMenu.Columns[3].HeaderCell.Value = "Harga Menu";
            dsMenu.Columns[3].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsMenu.Columns[4].HeaderCell.Value = "Deskripsi Menu";
            dsMenu.Columns[5].HeaderCell.Value = "Status Menu";
            dsMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsMenu.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsMenu.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsMenu.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsMenu.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dsMenu.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            dsMenu.Columns[5].DefaultCellStyle.ForeColor = Color.Black;

            dsDetailPembelian.Columns[0].HeaderCell.Value = "ID Transaksi Menu";
            dsDetailPembelian.Columns[1].Visible = false;
            dsDetailPembelian.Columns[2].HeaderCell.Value = "Nama Menu";
            dsDetailPembelian.Columns[3].HeaderCell.Value = "Jumlah";
            dsDetailPembelian.Columns[4].HeaderCell.Value = "Total Harga";
            dsDetailPembelian.Columns[4].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsDetailPembelian.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsDetailPembelian.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsDetailPembelian.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsDetailPembelian.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dsDetailPembelian.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
        }

        public void LoadMenu()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadMenuTransaksi", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsMenu.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void LoadDetailTrsMenu()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadDetailTrsMenu", connection);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("id_tr_dapur", id);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsDetailPembelian.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
