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
    public partial class FormReportTransaksiRuangan : Form
    {
        public FormReportTransaksiRuangan()
        {
            InitializeComponent();
        }

        private void FormReportTransaksiRuangan_Load(object sender, EventArgs e)
        {
            // this.reportViewer1.RefreshReport();
            dpToDate.Value = DateTime.Now;
        }

        private void btnLihatLaporan_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("dari", dpFromDate.Value.Date.ToShortDateString()),
                new Microsoft.Reporting.WinForms.ReportParameter("sampai", dpToDate.Value.Date.ToShortDateString())
            };

            reportViewer1.LocalReport.SetParameters(rParams);

            this.laporanTransaksiRuanganTableAdapter.Fill(this.dsRuangann1.LaporanTransaksiRuangan, dpFromDate.Value.ToString("yyyy-MM-dd"), dpToDate.Value.ToString("yyyy-MM-dd"));
            this.reportViewer1.RefreshReport();
        }
    }
}
