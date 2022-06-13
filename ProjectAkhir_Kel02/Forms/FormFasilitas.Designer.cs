
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormFasilitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFasilitas));
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.dsFasilitas = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.tbNamaFasilitas = new ns1.BunifuMaterialTextbox();
            this.tbJumlah = new ns1.BunifuMaterialTextbox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnEdit = new ns1.BunifuFlatButton();
            this.btnBatal = new ns1.BunifuFlatButton();
            this.btnHapus = new ns1.BunifuFlatButton();
            this.btnSimpan = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsFasilitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearch.HintText = "";
            this.tbSearch.isPassword = false;
            this.tbSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearch.LineThickness = 3;
            this.tbSearch.Location = new System.Drawing.Point(658, 115);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(315, 27);
            this.tbSearch.TabIndex = 120;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dsFasilitas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsFasilitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsFasilitas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsFasilitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsFasilitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsFasilitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsFasilitas.DoubleBuffered = true;
            this.dsFasilitas.EnableHeadersVisualStyles = false;
            this.dsFasilitas.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsFasilitas.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsFasilitas.Location = new System.Drawing.Point(430, 149);
            this.dsFasilitas.Name = "dsFasilitas";
            this.dsFasilitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsFasilitas.Size = new System.Drawing.Size(617, 496);
            this.dsFasilitas.TabIndex = 115;
            this.dsFasilitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDetailFasilitasKamar_CellContentClick);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 125);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(60, 20);
            this.bunifuCustomLabel3.TabIndex = 113;
            this.bunifuCustomLabel3.Text = "Jumlah";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(113, 20);
            this.bunifuCustomLabel2.TabIndex = 112;
            this.bunifuCustomLabel2.Text = "Nama Fasilitas";
            // 
            // tbNamaFasilitas
            // 
            this.tbNamaFasilitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNamaFasilitas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNamaFasilitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNamaFasilitas.HintForeColor = System.Drawing.Color.Empty;
            this.tbNamaFasilitas.HintText = "";
            this.tbNamaFasilitas.isPassword = false;
            this.tbNamaFasilitas.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNamaFasilitas.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNamaFasilitas.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNamaFasilitas.LineThickness = 3;
            this.tbNamaFasilitas.Location = new System.Drawing.Point(35, 80);
            this.tbNamaFasilitas.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamaFasilitas.Name = "tbNamaFasilitas";
            this.tbNamaFasilitas.Size = new System.Drawing.Size(315, 27);
            this.tbNamaFasilitas.TabIndex = 122;
            this.tbNamaFasilitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNamaFasilitas.OnValueChanged += new System.EventHandler(this.tbEmail_OnValueChanged);
            // 
            // tbJumlah
            // 
            this.tbJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJumlah.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbJumlah.HintForeColor = System.Drawing.Color.Empty;
            this.tbJumlah.HintText = "";
            this.tbJumlah.isPassword = false;
            this.tbJumlah.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbJumlah.LineIdleColor = System.Drawing.Color.Gray;
            this.tbJumlah.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbJumlah.LineThickness = 3;
            this.tbJumlah.Location = new System.Drawing.Point(37, 149);
            this.tbJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(315, 27);
            this.tbJumlah.TabIndex = 123;
            this.tbJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(989, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 121;
            this.btnSearch.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(222, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(129, 35);
            this.btnEdit.TabIndex = 117;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBatal
            // 
            this.btnBatal.Activecolor = System.Drawing.Color.DarkViolet;
            this.btnBatal.BackColor = System.Drawing.Color.DarkViolet;
            this.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatal.BorderRadius = 0;
            this.btnBatal.ButtonText = "Batal";
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.DisabledColor = System.Drawing.Color.Gray;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBatal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBatal.Iconimage")));
            this.btnBatal.Iconimage_right = null;
            this.btnBatal.Iconimage_right_Selected = null;
            this.btnBatal.Iconimage_Selected = null;
            this.btnBatal.IconMarginLeft = 0;
            this.btnBatal.IconMarginRight = 0;
            this.btnBatal.IconRightVisible = true;
            this.btnBatal.IconRightZoom = 0D;
            this.btnBatal.IconVisible = true;
            this.btnBatal.IconZoom = 90D;
            this.btnBatal.IsTab = false;
            this.btnBatal.Location = new System.Drawing.Point(222, 257);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnBatal.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 119;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Textcolor = System.Drawing.Color.White;
            this.btnBatal.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHapus
            // 
            this.btnHapus.Activecolor = System.Drawing.Color.Red;
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapus.BorderRadius = 0;
            this.btnHapus.ButtonText = "Hapus";
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHapus.Iconimage")));
            this.btnHapus.Iconimage_right = null;
            this.btnHapus.Iconimage_right_Selected = null;
            this.btnHapus.Iconimage_Selected = null;
            this.btnHapus.IconMarginLeft = 0;
            this.btnHapus.IconMarginRight = 0;
            this.btnHapus.IconRightVisible = true;
            this.btnHapus.IconRightZoom = 0D;
            this.btnHapus.IconVisible = true;
            this.btnHapus.IconZoom = 90D;
            this.btnHapus.IsTab = false;
            this.btnHapus.Location = new System.Drawing.Point(37, 257);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.Red;
            this.btnHapus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(129, 35);
            this.btnHapus.TabIndex = 118;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Textcolor = System.Drawing.Color.White;
            this.btnHapus.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSimpan
            // 
            this.btnSimpan.Activecolor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderRadius = 0;
            this.btnSimpan.ButtonText = "Simpan";
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledColor = System.Drawing.Color.Gray;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSimpan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Iconimage")));
            this.btnSimpan.Iconimage_right = null;
            this.btnSimpan.Iconimage_right_Selected = null;
            this.btnSimpan.Iconimage_Selected = null;
            this.btnSimpan.IconMarginLeft = 0;
            this.btnSimpan.IconMarginRight = 0;
            this.btnSimpan.IconRightVisible = true;
            this.btnSimpan.IconRightZoom = 0D;
            this.btnSimpan.IconVisible = true;
            this.btnSimpan.IconZoom = 90D;
            this.btnSimpan.IsTab = false;
            this.btnSimpan.Location = new System.Drawing.Point(37, 212);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 116;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbNamaFasilitas);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dsFasilitas);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormFasilitas";
            this.Text = "Master Fasilitas";
            this.Load += new System.EventHandler(this.FormFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFasilitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private ns1.BunifuMaterialTextbox tbSearch;
        private ns1.BunifuFlatButton btnEdit;
        private ns1.BunifuFlatButton btnBatal;
        private ns1.BunifuFlatButton btnHapus;
        private ns1.BunifuFlatButton btnSimpan;
        private ns1.BunifuCustomDataGrid dsFasilitas;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMaterialTextbox tbNamaFasilitas;
        private ns1.BunifuMaterialTextbox tbJumlah;
    }
}