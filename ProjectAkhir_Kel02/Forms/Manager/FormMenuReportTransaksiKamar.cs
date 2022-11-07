using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Kel02.Forms.Manager
{
    public partial class FormMenuReportTransaksiKamar : Form
    {
        private Form currentChildForm;

        public FormMenuReportTransaksiKamar()
        {
            InitializeComponent();
        }

        private void rbProfil_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FormReportTransaksiKamar());

        }

        private void rbPassword_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FormReportTahunanKamar());

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
    }
}
