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
    public partial class FormReportTransaksiKamar : Form
    {
        public FormReportTransaksiKamar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormReportTransaksiKamar_Load(object sender, EventArgs e)
        {
            // this.reportViewer1.RefreshReport();
            dpToDate.Value = DateTime.Now;
        }

        private void btnLihatLaporan_Click(object sender, EventArgs e)
        {
            using (SI_HotelEntities4 db = new SI_HotelEntities4())
            {
                ReportKamar_ResultBindingSource.DataSource = db.ReportKamar(dpFromDate.Value, dpToDate.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("dari", dpFromDate.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("sampai", dpToDate.Value.Date.ToShortDateString())
                };

                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }
        }
    }
}
