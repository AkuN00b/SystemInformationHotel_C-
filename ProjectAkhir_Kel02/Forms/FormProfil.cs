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
    public partial class FormProfil : Form
    {
        String id, nama, email, password;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        string[] user;
        private Form currentChildForm;

        public FormProfil(string[] data)
        {
            InitializeComponent();
            user = data;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void tbPasswordLama_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbProfil_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FormEditProfil(user));
        }

        private void rbPassword_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FormEditPassword(user));
        }

        public void clear()
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void btnBatalPassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}
