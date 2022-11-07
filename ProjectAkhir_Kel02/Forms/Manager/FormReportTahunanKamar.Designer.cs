
namespace ProjectAkhir_Kel02.Forms.Manager
{
    partial class FormReportTahunanKamar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportTahunanKamar));
            this.GrafikTransaksiKamarBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetKamarTahunan1 = new ProjectAkhir_Kel02.DataSetKamarTahunan();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cBTahunGrafikTransaksiKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sI_HotelDataSet12 = new ProjectAkhir_Kel02.SI_HotelDataSet12();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLihatLaporan = new ns1.BunifuFlatButton();
            this.cBTahunGrafikTransaksiKamarTableAdapter = new ProjectAkhir_Kel02.SI_HotelDataSet12TableAdapters.CBTahunGrafikTransaksiKamarTableAdapter();
            this.grafikTransaksiKamarTableAdapter1 = new ProjectAkhir_Kel02.DataSetKamarTahunanTableAdapters.GrafikTransaksiKamarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTransaksiKamarBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKamarTahunan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBTahunGrafikTransaksiKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_HotelDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // GrafikTransaksiKamarBS
            // 
            this.GrafikTransaksiKamarBS.DataMember = "GrafikTransaksiKamar";
            this.GrafikTransaksiKamarBS.DataSource = this.dataSetKamarTahunan1;
            // 
            // dataSetKamarTahunan1
            // 
            this.dataSetKamarTahunan1.DataSetName = "DataSetKamarTahunan";
            this.dataSetKamarTahunan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 206;
            this.label2.Text = "Tahun :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cBTahunGrafikTransaksiKamarBindingSource;
            this.comboBox1.DisplayMember = "Year";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 205;
            this.comboBox1.ValueMember = "Year";
            // 
            // cBTahunGrafikTransaksiKamarBindingSource
            // 
            this.cBTahunGrafikTransaksiKamarBindingSource.DataMember = "CBTahunGrafikTransaksiKamar";
            this.cBTahunGrafikTransaksiKamarBindingSource.DataSource = this.sI_HotelDataSet12;
            // 
            // sI_HotelDataSet12
            // 
            this.sI_HotelDataSet12.DataSetName = "SI_HotelDataSet12";
            this.sI_HotelDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GrafikTransaksiKamarBS;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectAkhir_Kel02.ReportKamarTahunan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 210);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(752, 372);
            this.reportViewer1.TabIndex = 204;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 202;
            this.label1.Text = "REPORT TRANSAKSI KAMAR";
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
            this.btnLihatLaporan.Location = new System.Drawing.Point(321, 138);
            this.btnLihatLaporan.Name = "btnLihatLaporan";
            this.btnLihatLaporan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnLihatLaporan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLihatLaporan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLihatLaporan.selected = false;
            this.btnLihatLaporan.Size = new System.Drawing.Size(147, 35);
            this.btnLihatLaporan.TabIndex = 203;
            this.btnLihatLaporan.Text = "Lihat Laporan";
            this.btnLihatLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatLaporan.Textcolor = System.Drawing.Color.White;
            this.btnLihatLaporan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatLaporan.Click += new System.EventHandler(this.btnLihatLaporan_Click);
            // 
            // cBTahunGrafikTransaksiKamarTableAdapter
            // 
            this.cBTahunGrafikTransaksiKamarTableAdapter.ClearBeforeFill = true;
            // 
            // grafikTransaksiKamarTableAdapter1
            // 
            this.grafikTransaksiKamarTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReportTahunanKamar
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
            this.Name = "FormReportTahunanKamar";
            this.Text = "FormReportTahunanKamar";
            this.Load += new System.EventHandler(this.FormReportTahunanKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTransaksiKamarBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKamarTahunan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBTahunGrafikTransaksiKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_HotelDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ns1.BunifuFlatButton btnLihatLaporan;
        private System.Windows.Forms.Label label1;
        private SI_HotelDataSet12 sI_HotelDataSet12;
        private System.Windows.Forms.BindingSource cBTahunGrafikTransaksiKamarBindingSource;
        private SI_HotelDataSet12TableAdapters.CBTahunGrafikTransaksiKamarTableAdapter cBTahunGrafikTransaksiKamarTableAdapter;
        private DataSetKamarTahunan dataSetKamarTahunan1;
        private DataSetKamarTahunanTableAdapters.GrafikTransaksiKamarTableAdapter grafikTransaksiKamarTableAdapter1;
        private System.Windows.Forms.BindingSource GrafikTransaksiKamarBS;
    }
}