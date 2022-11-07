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

namespace ProjectAkhir_Kel02.Forms
{
    public partial class FormTransaksiPembelian : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, id_kamar, id_menu, id_customer, hari, id_receptionist, harga_kelas, harga_jenis, id_trs_kamar;
        Double harga, total_harga, tempHarga, a;
        private void btnBatal_Click(object sender, EventArgs e)
        {
            
        }

        private string loading()
        {
            IDOtomatis a = new IDOtomatis();
            string sp = "sp_IDTransaksiPembelian";
            a.setID("TP", sp);
            string id = a.getID();
            return id;
        }

        private void tbJumlah_OnValueChanged(object sender, EventArgs e)
        {
            // total_harga = Double.Parse(tbJumlah.Text) * harga;
        }

        private void dsTrsKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsTrsKamar.Rows[e.RowIndex];

                    //transfer ke textbox
                    id_trs_kamar = row.Cells[0].Value.ToString();
                    id_kamar = row.Cells[4].Value.ToString();
                    id_customer = row.Cells[1].Value.ToString();
                    tbCustomer.Text = row.Cells[2].Value.ToString();
                    tbKamar.Text = row.Cells[4].Value.ToString() + " - " + row.Cells[5].Value.ToString() + " - " + row.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void clear()
        {
            tbCustomer.Text = "";
            tbKamar.Text = "";
            tbMenu.Text = "";
            tbJumlah.Text = "";
            btnEditMenu.Enabled = false;
            btnHapusMenu.Enabled = false;
            tbTotalHarga.Text = "0";

            connection.Close();
            id = loading();
            LoadDataTransaksiKamar();
            LoadMenu();
            LoadDetailTrsMenu();

            dsTrsKamar.Columns[0].HeaderCell.Value = "ID Transaksi Kamar";
            dsTrsKamar.Columns[1].Visible = false;
            dsTrsKamar.Columns[2].HeaderCell.Value = "Customer";
            dsTrsKamar.Columns[3].HeaderCell.Value = "Receptionist";
            dsTrsKamar.Columns[4].HeaderCell.Value = "Kamar";
            dsTrsKamar.Columns[5].HeaderCell.Value = "Kelas Kamar";
            dsTrsKamar.Columns[6].HeaderCell.Value = "Jenis Kamar";
            dsTrsKamar.Columns[7].HeaderCell.Value = "Tgl Transaksi";
            dsTrsKamar.Columns[8].HeaderCell.Value = "Check In";
            dsTrsKamar.Columns[9].HeaderCell.Value = "Check Out";
            dsTrsKamar.Columns[10].HeaderCell.Value = "Total Harga";
            dsTrsKamar.Columns[10].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsTrsKamar.Columns[11].HeaderCell.Value = "Status";
            dsTrsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsTrsKamar.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[5].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[6].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[7].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[8].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[9].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[10].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[11].DefaultCellStyle.ForeColor = Color.Black;

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

        public void LoadDataTransaksiKamar()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadTransaksiKamarMenu", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsTrsKamar.DataSource = bindingSource1;
                connection.Close();
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
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

        private void dsTrsKamar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearchTrsKamar_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchTrsKamar.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariTransaksiKamarMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsTrsKamar.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsTrsKamar.Columns[0].HeaderCell.Value = "ID Transaksi Kamar";
                dsTrsKamar.Columns[1].Visible = false;
                dsTrsKamar.Columns[2].HeaderCell.Value = "Customer";
                dsTrsKamar.Columns[3].HeaderCell.Value = "Receptionist";
                dsTrsKamar.Columns[4].HeaderCell.Value = "Kamar";
                dsTrsKamar.Columns[5].HeaderCell.Value = "Kelas Kamar";
                dsTrsKamar.Columns[6].HeaderCell.Value = "Jenis Kamar";
                dsTrsKamar.Columns[7].HeaderCell.Value = "Tgl Transaksi";
                dsTrsKamar.Columns[8].HeaderCell.Value = "Check In";
                dsTrsKamar.Columns[9].HeaderCell.Value = "Check Out";
                dsTrsKamar.Columns[10].HeaderCell.Value = "Total Harga";
                dsTrsKamar.Columns[10].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsTrsKamar.Columns[11].HeaderCell.Value = "Status";
                dsTrsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

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
                    MessageBox.Show("Data transaksi menu berhasil diperbaharui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Data transaksi menu berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            if (id_menu == "" || jumlah == "" || tbCustomer.Text == "" || tbKamar.Text == "")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                total_harga = Double.Parse(jumlah) * harga;
                SqlCommand insert = new SqlCommand("sp_InsertDetailTrsPembelian", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_tr_dapur", id);
                insert.Parameters.AddWithValue("id_tr_kamar", id_trs_kamar);
                insert.Parameters.AddWithValue("id_menu_makanan", id_menu); 
                insert.Parameters.AddWithValue("qty", jumlah);
                insert.Parameters.AddWithValue("total_harga", total_harga);
                insert.Parameters.AddWithValue("id_customer", id_customer);
                insert.Parameters.AddWithValue("id_receptionist", id_receptionist);
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
                } catch (Exception ex)
                {
                    //MessageBox.Show("Error" + ex);
                }
            }

            tbMenu.Text = "";
            tbJumlah.Text = "";
            connection.Close();
            LoadDetailTrsMenu();
        }

        private void dsDetailPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                MessageBox.Show("Data transaksi menu berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Data Transaksi Menu Dibatalkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            clear();
        }

        private void tbSearchTrsKamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchTrsKamar.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariTransaksiKamarMenu", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsTrsKamar.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsTrsKamar.Columns[0].HeaderCell.Value = "ID Transaksi Kamar";
                dsTrsKamar.Columns[1].Visible = false;
                dsTrsKamar.Columns[2].HeaderCell.Value = "Customer";
                dsTrsKamar.Columns[3].HeaderCell.Value = "Receptionist";
                dsTrsKamar.Columns[4].HeaderCell.Value = "Kamar";
                dsTrsKamar.Columns[5].HeaderCell.Value = "Kelas Kamar";
                dsTrsKamar.Columns[6].HeaderCell.Value = "Jenis Kamar";
                dsTrsKamar.Columns[7].HeaderCell.Value = "Tgl Transaksi";
                dsTrsKamar.Columns[8].HeaderCell.Value = "Check In";
                dsTrsKamar.Columns[9].HeaderCell.Value = "Check Out";
                dsTrsKamar.Columns[10].HeaderCell.Value = "Total Harga";
                dsTrsKamar.Columns[10].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsTrsKamar.Columns[11].HeaderCell.Value = "Status";
                dsTrsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnTerbayar_Click(object sender, EventArgs e)
        {
            SqlCommand insert = new SqlCommand("sp_UpdatePembayaranTransaksiMenu", connection);
            string b = a.ToString();

            if (cbDibayar.Checked)
            {
                total_harga = Double.Parse(tbTotalHarga.Text);

                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_tr_dapur", id);
                insert.Parameters.AddWithValue("total_harga", b);
                insert.Parameters.AddWithValue("status_transaksi", 2);

                connection.Open();
                insert.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Transaksi berhasil disimpan, status sudah dibayar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            } else
            {
                total_harga = Double.Parse(tbTotalHarga.Text);

                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_tr_dapur", id);
                insert.Parameters.AddWithValue("total_harga", b);
                insert.Parameters.AddWithValue("status_transaksi", 1);

                connection.Open();
                insert.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Transaksi berhasil disimpan, status belum dibayar !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void tbTotalHarga_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dsMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        public FormTransaksiPembelian(string[] data)
        {
            InitializeComponent();
            id_receptionist = data[0];
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void FormTransaksiPembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sI_HotelDataSet6.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.sI_HotelDataSet6.Menu);
            clear();
        }

        private void cbKamar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 0 Proses Pemesanan
            // 1 Belum Dibayar
            // 2 Dibayar
        }
    }
}
