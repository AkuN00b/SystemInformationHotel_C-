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
using System.Text.RegularExpressions;

namespace ProjectAkhir_Kel02.Forms
{
    public partial class FormEditProfil : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        String id, nama, email, password;
        string[] user;

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        public FormEditProfil(string[] data)
        {
            InitializeComponent();
            id = data[0];
            nama = data[1];
            email = data[2];
            password = data[3];
            user = data;
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void FormEditProfil_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (tbNama.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Mohon untuk mengisi seluruh data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (tbNama.Text == nama && tbEmail.Text == email) 
            {
                MessageBox.Show("Tidak ada perubahan data, batal diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Regex validateEmailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
                Match match = validateEmailRegex.Match(tbEmail.Text);

                if (match.Success)
                {
                    SqlCommand insert = new SqlCommand("sp_UpdateProfil", connection);
                    insert.CommandType = CommandType.StoredProcedure;
                    insert.Parameters.AddWithValue("id", id);
                    insert.Parameters.AddWithValue("nama", tbNama.Text);
                    insert.Parameters.AddWithValue("email", tbEmail.Text);

                    try
                    {
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data profil berhasil diperbaharui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }

                    DataTable st = new DataTable();
                    SqlCommand view = new SqlCommand("sp_LoginNow", connection);
                    view.CommandType = CommandType.StoredProcedure;
                    view.Parameters.AddWithValue("id_user", user[0]);
                    SqlDataAdapter adapter = new SqlDataAdapter(view);
                    adapter.Fill(st);
                    connection.Close();

                    user[1] = st.Rows[0][1].ToString();
                    user[2] = st.Rows[0][2].ToString();
                } else
                {
                    MessageBox.Show("Format email tidak sesuai!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            clear();
        }

        public void clear()
        {
            tbNama.Text = user[1];
            tbEmail.Text = user[2];
        }
    }
}
