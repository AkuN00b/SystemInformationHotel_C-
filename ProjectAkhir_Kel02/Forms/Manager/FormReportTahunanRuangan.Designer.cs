
namespace ProjectAkhir_Kel02.Forms.Manager
{
    partial class FormReportTahunanRuangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportTahunanRuangan));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            this.GrafikTransaksiRuanganBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRuanganTahuinan1 = new ProjectAkhir_Kel02.DataSetRuanganTahuinan();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLihatLaporan = new ns1.BunifuFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cBTahunGrafikTransaksiRuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIHotelDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sI_HotelDataSet10 = new ProjectAkhir_Kel02.SI_HotelDataSet10();
            this.cBTahunGrafikTransaksiRuanganTableAdapter = new ProjectAkhir_Kel02.SI_HotelDataSet10TableAdapters.CBTahunGrafikTransaksiRuanganTableAdapter();
            this.grafikTransaksiRuanganTableAdapter1 = new ProjectAkhir_Kel02.DataSetRuanganTahuinanTableAdapters.GrafikTransaksiRuanganTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTransaksiRuanganBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRuanganTahuinan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBTahunGrafikTransaksiRuanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIHotelDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_HotelDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // GrafikTransaksiRuanganBS
            // 
            this.GrafikTransaksiRuanganBS.DataMember = "GrafikTransaksiRuangan";
            this.GrafikTransaksiRuanganBS.DataSource = this.dataSetRuanganTahuinan1;
            // 
            // dataSetRuanganTahuinan1
            // 
            this.dataSetRuanganTahuinan1.DataSetName = "DataSetRuanganTahuinan";
            this.dataSetRuanganTahuinan1.EnforceConstraints = false;
            this.dataSetRuanganTahuinan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GrafikTransaksiRuanganBS;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectAkhir_Kel02.ReportTahunanRuangann.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 209);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(752, 372);
            this.reportViewer1.TabIndex = 199;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 193;
            this.label1.Text = "REPORT TRANSAKSI RUANGAN";
            // 
            // btnLihatLaporan
            // 
            this.btnLihatLaporan.Activecolor = System.Drawing.Color.ForestGreen;
            this.btnLihatLaporan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLihatLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLihatLaporan.BorderRadius = 0;
            this.btnLihatLaporan.ButtonText = "Lihat Laporan";
            this.btnLihatLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLihatLaporan.DisabledColor = System.Drawing.Color.Gray;
            this.btnLihatLaporan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatLaporan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLihatLaporan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLihatLaporan.Iconimage")));
            this.btnLihatLaporan.Iconimage_right = null;
            this.btnLihatLaporan.Iconimage_right_Selected = null;
            this.btnLihatLaporan.Iconimage_Selected = null;
            this.btnLihatLaporan.IconMarginLeft = 0;
            this.btnLihatLaporan.IconMarginRight = 0;
            this.btnLihatLaporan.IconRightVisible = true;
            this.btnLihatLaporan.IconRightZoom = 0D;
            this.btnLihatLaporan.IconVisible = true;
            this.btnLihatLaporan.IconZoom = 90D;
            this.btnLihatLaporan.IsTab = false;
            this.btnLihatLaporan.Location = new System.Drawing.Point(315, 137);
            this.btnLihatLaporan.Name = "btnLihatLaporan";
            this.btnLihatLaporan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnLihatLaporan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLihatLaporan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLihatLaporan.selected = false;
            this.btnLihatLaporan.Size = new System.Drawing.Size(147, 35);
            this.btnLihatLaporan.TabIndex = 196;
            this.btnLihatLaporan.Text = "Lihat Laporan";
            this.btnLihatLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatLaporan.Textcolor = System.Drawing.Color.White;
            this.btnLihatLaporan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatLaporan.Click += new System.EventHandler(this.btnLihatLaporan_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cBTahunGrafikTransaksiRuanganBindingSource;
            this.comboBox1.DisplayMember = "Year";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 200;
            this.comboBox1.ValueMember = "Year";
            // 
            // cBTahunGrafikTransaksiRuanganBindingSource
            // 
            this.cBTahunGrafikTransaksiRuanganBindingSource.DataMember = "CBTahunGrafikTransaksiRuangan";
            this.cBTahunGrafikTransaksiRuanganBindingSource.DataSource = this.sIHotelDataSet10BindingSource;
            // 
            // sIHotelDataSet10BindingSource
            // 
            this.sIHotelDataSet10BindingSource.DataSource = this.sI_HotelDataSet10;
            this.sIHotelDataSet10BindingSource.Position = 0;
            // 
            // sI_HotelDataSet10
            // 
            this.sI_HotelDataSet10.DataSetName = "SI_HotelDataSet10";
            this.sI_HotelDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBTahunGrafikTransaksiRuanganTableAdapter
            // 
            this.cBTahunGrafikTransaksiRuanganTableAdapter.ClearBeforeFill = true;
            // 
            // grafikTransaksiRuanganTableAdapter1
            // 
            this.grafikTransaksiRuanganTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 201;
            this.label2.Text = "Tahun :";
            // 
            // FormReportTahunanRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnLihatLaporan);
            this.Controls.Add(this.label1);
            this.Name = "FormReportTahunanRuangan";
            this.Text = "FormReportTahunanRuangan";
            this.Load += new System.EventHandler(this.FormReportTahunanRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTransaksiRuanganBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRuanganTahuinan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBTahunGrafikTransaksiRuanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIHotelDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_HotelDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ns1.BunifuFlatButton btnLihatLaporan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sIHotelDataSet10BindingSource;
        private SI_HotelDataSet10 sI_HotelDataSet10;
        private System.Windows.Forms.BindingSource cBTahunGrafikTransaksiRuanganBindingSource;
        private SI_HotelDataSet10TableAdapters.CBTahunGrafikTransaksiRuanganTableAdapter cBTahunGrafikTransaksiRuanganTableAdapter;
        private DataSetRuanganTahuinan dataSetRuanganTahuinan1;
        private DataSetRuanganTahuinanTableAdapters.GrafikTransaksiRuanganTableAdapter grafikTransaksiRuanganTableAdapter1;
        private System.Windows.Forms.BindingSource GrafikTransaksiRuanganBS;
        private System.Windows.Forms.Label label2;
    }
}