using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Kel02
{
    public partial class FormLogin : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormLogin()
        {
            InitializeComponent();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                tbPassword.isPassword = false;
            } else
            {
                tbPassword.isPassword = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbPassword.isPassword = true;
            bunifuCheckbox1.Checked = false;
        }

        private void SIHotel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
            bunifuCheckbox1.Checked = false;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Keluar dari aplikasi?", "Konfrimasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string role;
            try
            {
                connection.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_Login", connection);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("email_user", tbEmail.Text);
                view.Parameters.AddWithValue("password", tbPassword.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                connection.Close();

                if (st.Rows.Count != 0)
                {
                    role = st.Rows[0][4].ToString();
                    if (role == "1")
                    {
                        MessageBox.Show("Selamat datang Bapak/Ibu Manager!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMainMenu fmm = new FormMainMenu();
                        this.Hide();
                        fmm.Show();
                    } else if (role == "2")
                    {
                        MessageBox.Show("Selamat datang Bapak/Ibu Resepsionis!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMainMenu fmm = new FormMainMenu();
                        this.Hide();
                        fmm.Show();
                    } else if (role == "3")
                    {
                        MessageBox.Show("Selamat datang Bapak/Ibu Customer!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMainMenu fmm = new FormMainMenu();
                        this.Hide();
                        fmm.Show();
                    }

                    clear();
                }
                else
                {
                    MessageBox.Show("Email atau Password anda salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
