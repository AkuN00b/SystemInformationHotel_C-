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
    public partial class FormReportTahunanMenu : Form
    {
        public FormReportTahunanMenu()
        {
            InitializeComponent();
        }

        private void FormReportTahunanMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sI_HotelDataSet11.CBTahunGrafikTransaksiPembelian' table. You can move, or remove it, as needed.
            this.cBTahunGrafikTransaksiPembelianTableAdapter.Fill(this.sI_HotelDataSet11.CBTahunGrafikTransaksiPembelian);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnLihatLaporan_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("year", comboBox1.SelectedValue.ToString())
            };
            reportViewer1.LocalReport.SetParameters(rParams);

            this.grafikTransaksiPembelianTableAdapter1.Fill(this.dataSetMenuTahunan1.GrafikTransaksiPembelian, Int32.Parse(comboBox1.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
