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
    public partial class FormTransaksiRuangan : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, id_ruangan, id_customer, hari, id_receptionist, harga_kelas, harga_jenis, id_trs_ruangan;
        double total_harga, a;
        int differenceInDays;
        public FormTransaksiRuangan(string[] data)
        {
            InitializeComponent();
            id_receptionist = data[0];
        }

        private void FormTransaksiRuangan_Load(object sender, EventArgs e)
        {
            clear();
        }

        private string loading()
        {
            IDOtomatis a = new IDOtomatis();
            string sp = "sp_IDTransaksiRuangan";
            a.setID("TRU", sp);
            string id = a.getID();
            return id;
        }

        public void clear()
        {
            tbCustomer.Text = "";
            tbRuangan.Text = "";
            tbTotalHarga.Text = "0";
            total_harga = 0;
            differenceInDays = 0;

            btnSimpan.Enabled = true;
            dsCustomer.Enabled = true;
            dsRuangan.Enabled = true;
            dpCheckIn.Enabled = true;
            dpCheckOut.Enabled = true;
            btnCheckOut.Enabled = false;

            dpCheckIn.Value = DateTime.Today.Date;
            dpCheckOut.Value = DateTime.Today.Date;

            connection.Close();
            LoadDataCustomer();
            LoadDataRuangan();
            LoadDataTransaksiRuangan();
            loading();

            btnSimpan.Enabled = true;

            dsCustomer.Columns[0].HeaderCell.Value = "ID Customer";
            dsCustomer.Columns[1].HeaderCell.Value = "Nama Customer";
            dsCustomer.Columns[2].HeaderCell.Value = "Email Customer";
            dsCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsCustomer.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsCustomer.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsCustomer.Columns[2].DefaultCellStyle.ForeColor = Color.Black;

            dsRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
            dsRuangan.Columns[1].HeaderCell.Value = "Deskripsi Ruangan";
            dsRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
            dsRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
            dsRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsRuangan.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsRuangan.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsRuangan.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsRuangan.Columns[3].DefaultCellStyle.ForeColor = Color.Black;

            dsTrsRuangan.Columns[0].HeaderCell.Value = "ID Transaksi Ruangan";
            dsTrsRuangan.Columns[1].HeaderCell.Value = "Customer";
            dsTrsRuangan.Columns[2].HeaderCell.Value = "Receptionist";
            dsTrsRuangan.Columns[3].HeaderCell.Value = "Ruangan";
            dsTrsRuangan.Columns[4].HeaderCell.Value = "Deskripsi Ruangan";
            dsTrsRuangan.Columns[5].HeaderCell.Value = "Tgl Transaksi";
            dsTrsRuangan.Columns[6].HeaderCell.Value = "Check In";
            dsTrsRuangan.Columns[7].HeaderCell.Value = "Check Out";
            dsTrsRuangan.Columns[8].HeaderCell.Value = "Total Harga";
            dsTrsRuangan.Columns[8].DefaultCellStyle.Format = "Rp ###,##0.00";
            dsTrsRuangan.Columns[9].HeaderCell.Value = "Status Transaksi";
            dsTrsRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dsTrsRuangan.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[5].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[6].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[7].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[8].DefaultCellStyle.ForeColor = Color.Black;
            dsTrsRuangan.Columns[9].DefaultCellStyle.ForeColor = Color.Black;
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

        public void LoadDataRuangan()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadRuanganTransaksi", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsRuangan.DataSource = bindingSource1;
                connection.Close();
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

        private void btnSearchCustomer_Click_1(object sender, EventArgs e)
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

        private void btnSearchRuangan_Click_1(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchRuangan.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariRuanganTransaksi", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsRuangan.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
                dsRuangan.Columns[1].HeaderCell.Value = "Deskripsi Ruangan";
                dsRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
                dsRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
                dsRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSearchTrsRuangan_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchTrsRuangan.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariTransaksiRuangan", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsTrsRuangan.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsTrsRuangan.Columns[0].HeaderCell.Value = "ID Transaksi Ruangan";
                dsTrsRuangan.Columns[1].HeaderCell.Value = "Customer";
                dsTrsRuangan.Columns[2].HeaderCell.Value = "Receptionist";
                dsTrsRuangan.Columns[3].HeaderCell.Value = "Ruangan";
                dsTrsRuangan.Columns[4].HeaderCell.Value = "Deskripsi Ruangan";
                dsTrsRuangan.Columns[5].HeaderCell.Value = "Tgl Transaksi";
                dsTrsRuangan.Columns[6].HeaderCell.Value = "Check In";
                dsTrsRuangan.Columns[7].HeaderCell.Value = "Check Out";
                dsTrsRuangan.Columns[8].HeaderCell.Value = "Total Harga";
                dsTrsRuangan.Columns[8].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsTrsRuangan.Columns[9].HeaderCell.Value = "Status Transaksi";
                dsTrsRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id = loading();
            string b = a.ToString();

            if (b == "" || tbCustomer.Text == "" || tbRuangan.Text == "" || hari == "")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand insert = new SqlCommand("sp_InsertTransaksiRuangan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("id_transaksi_ruangan", id);
                insert.Parameters.AddWithValue("id_customer", id_customer);
                insert.Parameters.AddWithValue("id_receptionist", id_receptionist);
                insert.Parameters.AddWithValue("id_ruangan", id_ruangan);
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
                    MessageBox.Show("Data transaksi ruangan berhasil disimpan ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

            clear();
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

        private void dsRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsRuangan.Rows[e.RowIndex];
                    //transfer ke textbox
                    id_ruangan = row.Cells[0].Value.ToString();
                    tbRuangan.Text = row.Cells[0].Value.ToString() + " - " + row.Cells[1].Value.ToString();
                    total_harga = Convert.ToDouble(row.Cells[2].Value.ToString());

                    if (differenceInDays == 0)
                    {

                    }
                    else
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

        private void dsTrsRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSimpan.Enabled = false;
            dsCustomer.Enabled = false;
            dsRuangan.Enabled = false;
            btnCheckOut.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    //mengambil semua baris
                    DataGridViewRow row = this.dsTrsRuangan.Rows[e.RowIndex];

                    //transfer ke textbox
                    id_trs_ruangan = row.Cells[0].Value.ToString();
                    tbCustomer.Text = row.Cells[1].Value.ToString();
                    id_ruangan = row.Cells[3].Value.ToString();
                    tbRuangan.Text = row.Cells[3].Value.ToString() + " - " + row.Cells[4].Value.ToString();
                    dpCheckIn.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                    dpCheckOut.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                    a = Double.Parse(row.Cells[8].Value.ToString());
                    string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                    tbTotalHarga.Text = kembali;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error: " + ex.Message);
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

            }
            else
            {
                a = (differenceInDays * total_harga);
                string kembali = string.Format("{0:n0}", Double.Parse(a.ToString()));
                tbTotalHarga.Text = kembali;
            }
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

        private void tbSearchRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchRuangan.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariRuanganTransaksi", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsRuangan.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsRuangan.Columns[0].HeaderCell.Value = "ID Ruangan";
                dsRuangan.Columns[1].HeaderCell.Value = "Deskripsi Ruangan";
                dsRuangan.Columns[2].HeaderCell.Value = "Harga Ruangan";
                dsRuangan.Columns[2].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsRuangan.Columns[3].HeaderCell.Value = "Status Ruangan";
                dsRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbSearchTrsRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            try
            {
                string cari = tbSearchTrsRuangan.Text;
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_CariTransaksiRuangan", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("cari", cari);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    bindingSource1.DataSource = st;
                    dsTrsRuangan.DataSource = bindingSource1;
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }

                dsTrsRuangan.Columns[0].HeaderCell.Value = "ID Transaksi Ruangan";
                dsTrsRuangan.Columns[1].HeaderCell.Value = "Customer";
                dsTrsRuangan.Columns[2].HeaderCell.Value = "Receptionist";
                dsTrsRuangan.Columns[3].HeaderCell.Value = "Ruangan";
                dsTrsRuangan.Columns[4].HeaderCell.Value = "Deskripsi Ruangan";
                dsTrsRuangan.Columns[5].HeaderCell.Value = "Tgl Transaksi";
                dsTrsRuangan.Columns[6].HeaderCell.Value = "Check In";
                dsTrsRuangan.Columns[7].HeaderCell.Value = "Check Out";
                dsTrsRuangan.Columns[8].HeaderCell.Value = "Total Harga";
                dsTrsRuangan.Columns[8].DefaultCellStyle.Format = "Rp ###,##0.00";
                dsTrsRuangan.Columns[9].HeaderCell.Value = "Status Transaksi";
                dsTrsRuangan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand insert = new SqlCommand("sp_UpdateTrsRuangan", connection);
            insert.CommandType = CommandType.StoredProcedure;
            insert.Parameters.AddWithValue("id_tr_ruangan", id_trs_ruangan);
            insert.Parameters.AddWithValue("id_ruangan", id_ruangan);

            // 1 = Check In
            // 2 = Check Out

            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Data transaksi berubah menjadi checkout", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            clear();
        }

        public void LoadDataTransaksiRuangan()
        {
            BindingSource bindingSource1 = new BindingSource();

            try
            {
                connection.Open();

                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_LoadTransaksiRuangan", connection);
                view.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                bindingSource1.DataSource = st;
                dsTrsRuangan.DataSource = bindingSource1;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void tbSearchCustomer_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dsCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSearchRuangan_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchRuangan_Click(object sender, EventArgs e)
        {

        }

        private void dsRuangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
