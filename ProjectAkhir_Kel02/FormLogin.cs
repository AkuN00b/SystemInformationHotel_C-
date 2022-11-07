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
using System.Text.RegularExpressions;
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

        public void loginMethod ()
        {
            string role;

            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Email atau Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Regex validateEmailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
                Match match = validateEmailRegex.Match(tbEmail.Text);

                if (match.Success)
                {
                    if (!(tbPassword.Text.Length < 7))
                    {
                        try
                        {
                            // connection.Open();
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
                                    string[] detail_user = { st.Rows[0][0].ToString(), st.Rows[0][1].ToString(), st.Rows[0][2].ToString(), st.Rows[0][3].ToString(), "Manager" };
                                    MessageBox.Show("Selamat Datang di Sistem Informasi Hotel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FormManagerMenu fmm = new FormManagerMenu(detail_user);
                                    this.Hide();
                                    fmm.Show();
                                }
                                else if (role == "2")
                                {
                                    string[] detail_user = { st.Rows[0][0].ToString(), st.Rows[0][1].ToString(), st.Rows[0][2].ToString(), st.Rows[0][3].ToString(), "Resepsionis" };
                                    MessageBox.Show("Selamat Datang di Sistem Informasi Hotel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FormMainMenu fmm = new FormMainMenu(detail_user);
                                    this.Hide();
                                    fmm.Show();
                                }
                                else if (role == "3")
                                {
                                    string[] detail_user = { st.Rows[0][0].ToString(), st.Rows[0][1].ToString(), st.Rows[0][2].ToString(), st.Rows[0][3].ToString(), "Customer" };
                                    MessageBox.Show("Selamat Datang di Sistem Informasi Hotel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FormCustomerMenu fcm = new FormCustomerMenu(detail_user);
                                    this.Hide();
                                    fcm.Show();
                                } else
                                {
                                    MessageBox.Show("Maaf anda tidak dapat mengakses aplikasi ini !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                clear();
                            }
                            else
                            {
                                MessageBox.Show("User tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password anda kurang dari 8 karakter !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Format email tidak sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            loginMethod();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                bunifuCheckbox1.Checked = false;
                tbPassword.isPassword = true;
            }
            else
            {
                bunifuCheckbox1.Checked = true;
                tbPassword.isPassword = false;
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                loginMethod();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                loginMethod();
            }
        }
    }
}
