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
    public partial class FormEditPassword : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, nama, email, password;
        string[] user;

        private void tbPasswordLama_OnValueChanged(object sender, EventArgs e)
        {
            tbPasswordLama.isPassword = true;
            tbPasswordBaru.isPassword = true;
            tbPasswordBaruu.isPassword = true;
            bunifuCheckbox1.Checked = false;
        }

        private void tbPasswordBaru_OnValueChanged(object sender, EventArgs e)
        {
            tbPasswordLama.isPassword = true;
            tbPasswordBaru.isPassword = true;
            tbPasswordBaruu.isPassword = true;
            bunifuCheckbox1.Checked = false;
        }

        private void tbPasswordBaruu_OnValueChanged(object sender, EventArgs e)
        {
            tbPasswordLama.isPassword = true;
            tbPasswordBaru.isPassword = true;
            tbPasswordBaruu.isPassword = true;
            bunifuCheckbox1.Checked = false;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                tbPasswordLama.isPassword = false;
                tbPasswordBaru.isPassword = false;
                tbPasswordBaruu.isPassword = false;
            }
            else
            {
                tbPasswordLama.isPassword = true;
                tbPasswordBaru.isPassword = true;
                tbPasswordBaruu.isPassword = true;
            }
        }

        private void btnBatalPassword_Click(object sender, EventArgs e)
        {
            clear();
        }

        public FormEditPassword(string[] data)
        {
            InitializeComponent();
            id = data[0];
            nama = data[1];
            email = data[2];
            password = data[3];
            user = data;
        }

        private void FormEditPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (tbPasswordLama.Text == "" || tbPasswordBaru.Text == "" || tbPasswordBaruu.Text == "")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (((tbPasswordLama.Text.Length < 7)) || ((tbPasswordBaru.Text.Length < 7)) || ((tbPasswordBaruu.Text.Length < 7)))
            {
                MessageBox.Show("Password anda kurang dari 8 karakter!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (password == tbPasswordLama.Text)
                {
                    if (tbPasswordBaru.Text == tbPasswordBaruu.Text)
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        SqlCommand insert = new SqlCommand("sp_UpdatePassword", connection);
                        insert.CommandType = CommandType.StoredProcedure;
                        insert.Parameters.AddWithValue("id", id);
                        insert.Parameters.AddWithValue("password", tbPasswordBaru.Text);

                        try
                        {
                            password = tbPasswordBaru.Text;

                            insert.ExecuteNonQuery();
                            MessageBox.Show("Data password berhasil diperbaharui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password baru anda tidak sesuai dengan verifikasi password baru !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Password anda tidak sesuai, dengan password sebelumnya !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            clear();
        }

        public void clear()
        {
            tbPasswordLama.Text = "";
            tbPasswordBaru.Text = "";
            tbPasswordBaruu.Text = "";
        }
    }
}
