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

namespace ProjectAkhir_Kel02.Forms
{
    public partial class FormTransaksiKamar : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, id_kamar, id_customer, hari, id_receptionist, harga_kelas, harga_jenis, id_trs_kamar;
        double total_harga, a;
        int differenceInDays, isEdit;
        public FormTransaksiKamar(string[] data)
        {
            InitializeComponent();
            id_receptionist = data[0];
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id = loading();
            string b = a.ToString();

            if (b == "" || tbCustomer.Text == "" || tbKamar.Text == "" || hari == "")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand insert = new SqlCommand("sp_InsertTransaksiKamar", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_transaksi_kamar", id);
                insert.Parameters.AddWithValue("id_customer", id_customer);
                insert.Parameters.AddWithValue("id_receptionist", id_receptionist);
                insert.Parameters.AddWithValue("id_kamar", id_kamar);
                insert.Parameters.AddWithValue("tgl_transaksi", DateTime.Now);
                insert.Parameters.AddWithValue("check_in", dpCheckIn.Value);
                insert.Parameters.AddWithValue("check_out", dpCheckOut.Value);
                insert.Parameters.AddWithValue("total_harga", b);
                insert.Parameters.AddWithValue("status_transaksi", 1);

                // 1 = Check In
                // 2 = Check Out

                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data transaksi kamar berhasil disimpan ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            clear();
        }

        private void FormTransaksiKamar_Load(object sender, EventArgs e)
        {
            clear();
        }

        private string loading()
        {
            IDOtomatis a = new IDOtomatis();
            string sp = "sp_IDTransaksiKamar";
            a.setID("TR", sp);
            string id = a.getID();
            return id;
        }

        public void clear()
        {
            tbCustomer.Text = "";
            tbKamar.Text = "";
            tbTotalHarga.Text = "0";
            total_harga = 0;
            differenceInDays = 0;
            isEdit = 0;

            btnSimpan.Enabled = true;
            dsCustomer.Enabled = true;
            dsKamar.Enabled = true;
            dpCheckIn.Enabled = true;
            dpCheckOut.Enabled = true;
            btnCheckOut.Enabled = false;

            dpCheckIn.Value = DateTime.Today.Date;
            dpCheckOut.Value = DateTime.Today.Date;

            connection.Close();
            LoadDataCustomer();
            LoadDataKamar();
            LoadDataTransaksiKamar();
            loading();

            dsCustomer.Columns[0].HeaderCell.Value = "ID Customer";
            dsCustomer.Columns[1].HeaderCell.Value = "Nama Customer";
            dsCustomer.Columns[2].HeaderCell.Value = "Email Customer";
            dsCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsCustomer.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsCustomer.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsCustomer.Columns[2].DefaultCellStyle.ForeColor = Color.Black;

            dsKamar.Columns[0].HeaderCell.Value = "ID Kamar";
            dsKamar.Columns[1].HeaderCell.Value = "Kelas Kamar";
            dsKamar.Columns[2].HeaderCell.Value = "Jenis Kamar";
            dsKamar.Columns[3].HeaderCell.Value = "Status Kamar";
            dsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsKamar.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsKamar.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsKamar.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsKamar.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dsKamar.Columns[4].Visible = false;
            dsKamar.Columns[5].Visible = false;

            dsTrsKamar.Columns[0].HeaderCell.Value = "ID Transaksi Kamar";
            dsTrsKamar.Columns[1].HeaderCell.Value = "Customer";
            dsTrsKamar.Columns[2].HeaderCell.Value = "Receptionist";
            dsTrsKamar.Columns[3].HeaderCell.Value = "Kamar";
            dsTrsKamar.Columns[4].HeaderCell.Value = "Kelas Kamar";
            dsTrsKamar.Columns[5].HeaderCell.Value = "Jenis Kamar";
            dsTrsKamar.Columns[6].HeaderCell.Value = "Tgl Transaksi";
            dsTrsKamar.Columns[7].HeaderCell.Value = "Check In";
            dsTrsKamar.Columns[8].HeaderCell.Value = "Check Out";
            dsTrsKamar.Columns[9].HeaderCell.Value = "Total Harga";
            dsTrsKamar.Columns[9].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsTrsKamar.Columns[10].HeaderCell.Value = "Status";
            dsTrsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsTrsKamar.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[5].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[6].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[7].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[8].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[9].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsKamar.Columns[10].DefaultCellStyle.ForeColor = Color.Black;
        }

        public void LoadDataCustomer()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadCustomer", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsCustomer.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void LoadDataKamar()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadKamarTransaksi", connection);
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

        public void LoadDataTransaksiKamar()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadTransaksiKamar", connection);
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

        private void tbSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dsCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsCustomer.Rows[e.RowIndex];

                    //transfer ke textbox
                    id_customer = row.Cells[0].Value.ToString();
                    tbCustomer.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dpCheckOut_onValueChanged(object sender, EventArgs e)
        {
            DateTime FirstDate = dpCheckIn.Value;
            DateTime SecondDate = dpCheckOut.Value;
            TimeSpan ts = SecondDate - FirstDate;
            differenceInDays = ts.Days;

            if (total_harga < 1)
            {

            } else
            {
                a = (differenceInDays * total_harga);
                string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                tbTotalHarga.Text = kembali;
            }
        }

        private void dsTrsKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            dsCustomer.Enabled = false;
            dsKamar.Enabled = false;
            btnCheckOut.Enabled = true;
            isEdit = 1;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsTrsKamar.Rows[e.RowIndex];

                    //transfer ke textbox
                    id_trs_kamar = row.Cells[0].Value.ToString();
                    id = row.Cells[0].Value.ToString();
                    tbCustomer.Text = row.Cells[1].Value.ToString();
                    id_kamar = row.Cells[3].Value.ToString();
                    tbKamar.Text = row.Cells[3].Value.ToString() + " - " + row.Cells[4].Value.ToString() + " - " + row.Cells[5].Value.ToString();
                    dpCheckIn.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                    dpCheckOut.Value = Convert.ToDateTime(row.Cells[8].Value.ToString());
                    Double a = Double.Parse(row.Cells[9].Value.ToString());
                    string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                    tbTotalHarga.Text = kembali;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dsTrsKamar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsKamar_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        public static bool checkNull(string s)
        {
            return (s == null || s == String.Empty) ? true : false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            double sisaBayar;
            string b;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            DataTable st = new DataTable();
            SqlCommand view = new SqlCommand("sp_CekTagihanKamar", connection);
            view.CommandType = CommandType.StoredProcedure;
            view.Parameters.AddWithValue("id_transaksi", id);
            SqlDataAdapter adapter = new SqlDataAdapter(view);
            adapter.Fill(st);
            connection.Close();

            b = st.Rows[0][0].ToString();

            if (!checkNull(b))
            {
                sisaBayar = Double.Parse(b);

                string kembali = string.Format("{0:n0}", Double.Parse(sisaBayar.ToString()));

                DialogResult d;
                d = MessageBox.Show("Ada tagihan sebesar Rp. " + kembali + ". Customer sudah membayar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand insert = new SqlCommand("sp_UpdateTrsKamar", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id_tr_kamar", id_trs_kamar);
                    insert.Parameters.AddWithValue("id_kamar", id_kamar);

                    SqlCommand update = new SqlCommand("sp_BayarTagihan", connection);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("id_transaksi", id_trs_kamar);

                    try
                    {
                        insert.ExecuteNonQuery();
                        update.ExecuteNonQuery();
                        MessageBox.Show("Data transaksi berubah menjadi checkout, tagihan berhasil dibayar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Data transaksi tidak jadi checkout, bayar tagihan terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand insert = new SqlCommand("sp_UpdateTrsKamar", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_tr_kamar", id_trs_kamar);
                insert.Parameters.AddWithValue("id_kamar", id_kamar);

                try
                {
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data transaksi berubah menjadi checkout!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            // 1 = Check In
            // 2 = Check Out

            clear();
        }

        private void dpCheckIn_onValueChanged(object sender, EventArgs e)
        {
            if (isEdit == 0)
            {
                DateTime FirstDate = DateTime.Now;
                DateTime SecondDate = dpCheckIn.Value;
                TimeSpan ts = SecondDate - FirstDate;
                differenceInDays = ts.Days;

                if (differenceInDays < 0)
                {
                    MessageBox.Show("Tanggal tidak sesuai !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dpCheckIn.Value = DateTime.Today.Date;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbTotalHarga_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbTotalHarga_TextChanged(object sender, EventArgs e)
        {
            
        }

        public double split(String x)
        {
            String[] a = x.Split('.');
            // String[] b = a[1].Split('.');
            // String[] c = b[1].Split(',');
            String Total = a[0];
            double total = Double.Parse(separate(Total));

            return total;
        }

        private void tbTotalHarga_Click(object sender, EventArgs e)
        {
            
        }

        private void tbSearchCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchCustomer.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariCustomer", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsCustomer.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsCustomer.Columns[0].HeaderCell.Value = "ID Customer";
                dsCustomer.Columns[1].HeaderCell.Value = "Nama Customer";
                dsCustomer.Columns[2].HeaderCell.Value = "Email Customer";
                dsCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbSearchKamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchKamar.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariKamarTransaksi", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
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

                dsKamar.Columns[0].HeaderCell.Value = "ID Kamar";
                dsKamar.Columns[1].HeaderCell.Value = "Kelas Kamar";
                dsKamar.Columns[2].HeaderCell.Value = "Jenis Kamar";
                dsKamar.Columns[3].HeaderCell.Value = "Status Kamar";
                dsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
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
                    SqlCommand view = new SqlCommand("sp_CariTransaksiKamar", connection);
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
                dsTrsKamar.Columns[1].HeaderCell.Value = "Customer";
                dsTrsKamar.Columns[2].HeaderCell.Value = "Receptionist";
                dsTrsKamar.Columns[3].HeaderCell.Value = "Kamar";
                dsTrsKamar.Columns[4].HeaderCell.Value = "Kelas Kamar";
                dsTrsKamar.Columns[5].HeaderCell.Value = "Jenis Kamar";
                dsTrsKamar.Columns[6].HeaderCell.Value = "Tgl Transaksi";
                dsTrsKamar.Columns[7].HeaderCell.Value = "Check In";
                dsTrsKamar.Columns[8].HeaderCell.Value = "Check Out";
                dsTrsKamar.Columns[9].HeaderCell.Value = "Total Harga";
                dsTrsKamar.Columns[10].HeaderCell.Value = "Status";
                dsCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbTotalHarga_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public String separate(String a)
        {
            string[] test = a.Split(',');
            string x = "";
            foreach (string tst in test)
            {
                if (tst.Trim() != "")
                {
                    x = x + tst;
                    Console.Write(tst);
                }
            }
            return x;
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
                    SqlCommand view = new SqlCommand("sp_CariTransaksiKamar", connection);
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
                dsTrsKamar.Columns[1].HeaderCell.Value = "Customer";
                dsTrsKamar.Columns[2].HeaderCell.Value = "Receptionist";
                dsTrsKamar.Columns[3].HeaderCell.Value = "Kamar";
                dsTrsKamar.Columns[4].HeaderCell.Value = "Kelas Kamar";
                dsTrsKamar.Columns[5].HeaderCell.Value = "Jenis Kamar";
                dsTrsKamar.Columns[6].HeaderCell.Value = "Tgl Transaksi";
                dsTrsKamar.Columns[7].HeaderCell.Value = "Check In";
                dsTrsKamar.Columns[8].HeaderCell.Value = "Check Out";
                dsTrsKamar.Columns[9].HeaderCell.Value = "Total Harga";
                dsTrsKamar.Columns[10].HeaderCell.Value = "Status";
                dsCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dsKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsKamar.Rows[e.RowIndex];
                    //transfer ke textbox
                    id_kamar = row.Cells[0].Value.ToString();
                    tbKamar.Text = row.Cells[0].Value.ToString() + " - " + row.Cells[1].Value.ToString() + " - " + row.Cells[2].Value.ToString();
                    harga_jenis = row.Cells[4].Value.ToString();
                    harga_kelas = row.Cells[5].Value.ToString();
                    total_harga = Convert.ToDouble(harga_jenis) + Convert.ToDouble(harga_kelas); 
                    if (differenceInDays == 0)
                    {

                    } else
                    {
                        a = (differenceInDays * total_harga);
                        string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                        tbTotalHarga.Text = kembali;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchCustomer.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariCustomer", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsCustomer.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsCustomer.Columns[0].HeaderCell.Value = "ID Customer";
                dsCustomer.Columns[1].HeaderCell.Value = "Nama Customer";
                dsCustomer.Columns[2].HeaderCell.Value = "Email Customer";
                dsCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void cbKamar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchKamar.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariKamarTransaksi", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
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

                dsKamar.Columns[0].HeaderCell.Value = "ID Kamar";
                dsKamar.Columns[1].HeaderCell.Value = "Kelas Kamar";
                dsKamar.Columns[2].HeaderCell.Value = "Jenis Kamar";
                dsKamar.Columns[3].HeaderCell.Value = "Status Kamar";
                dsKamar.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
