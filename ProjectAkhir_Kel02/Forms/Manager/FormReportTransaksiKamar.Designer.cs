
namespace ProjectAkhir_Kel02.Forms.Manager
{
    partial class FormReportTransaksiKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportTransaksiKamar));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFromDate = new ns1.BunifuDatepicker();
            this.dpToDate = new ns1.BunifuDatepicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnLihatLaporan = new ns1.BunifuFlatButton();
            this.ReportKamar_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportKamar_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "REPORT TRANSAKSI KAMAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sampai :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dari :";
            // 
            // dpFromDate
            // 
            this.dpFromDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpFromDate.BorderRadius = 0;
            this.dpFromDate.ForeColor = System.Drawing.Color.White;
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFromDate.FormatCustom = null;
            this.dpFromDate.Location = new System.Drawing.Point(109, 86);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(231, 35);
            this.dpFromDate.TabIndex = 184;
            this.dpFromDate.Value = new System.DateTime(2022, 6, 13, 10, 46, 56, 607);
            // 
            // dpToDate
            // 
            this.dpToDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpToDate.BorderRadius = 0;
            this.dpToDate.ForeColor = System.Drawing.Color.White;
            this.dpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpToDate.FormatCustom = null;
            this.dpToDate.Location = new System.Drawing.Point(485, 86);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.Size = new System.Drawing.Size(231, 35);
            this.dpToDate.TabIndex = 185;
            this.dpToDate.Value = new System.DateTime(2022, 6, 13, 10, 46, 56, 607);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Kamar";
            reportDataSource1.Value = this.ReportKamar_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectAkhir_Kel02.ReportTransaksiKamar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 220);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(752, 372);
            this.reportViewer1.TabIndex = 187;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
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
            this.btnLihatLaporan.Location = new System.Drawing.Point(315, 141);
            this.btnLihatLaporan.Name = "btnLihatLaporan";
            this.btnLihatLaporan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnLihatLaporan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLihatLaporan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLihatLaporan.selected = false;
            this.btnLihatLaporan.Size = new System.Drawing.Size(147, 35);
            this.btnLihatLaporan.TabIndex = 105;
            this.btnLihatLaporan.Text = "Lihat Laporan";
            this.btnLihatLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatLaporan.Textcolor = System.Drawing.Color.White;
            this.btnLihatLaporan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatLaporan.Click += new System.EventHandler(this.btnLihatLaporan_Click);
            // 
            // ReportKamar_ResultBindingSource
            // 
            this.ReportKamar_ResultBindingSource.DataSource = typeof(ProjectAkhir_Kel02.ReportKamar_Result);
            // 
            // FormReportTransaksiKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dpToDate);
            this.Controls.Add(this.dpFromDate);
            this.Controls.Add(this.btnLihatLaporan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReportTransaksiKamar";
            this.Text = "FormReportTransaksiKamar";
            this.Load += new System.EventHandler(this.FormReportTransaksiKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportKamar_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton btnLihatLaporan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuDatepicker dpFromDate;
        private ns1.BunifuDatepicker dpToDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportKamar_ResultBindingSource;
    }
}