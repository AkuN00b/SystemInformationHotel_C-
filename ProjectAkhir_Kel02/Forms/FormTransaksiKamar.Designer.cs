
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormTransaksiKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiKamar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tbSearchCustomer = new ns1.BunifuMaterialTextbox();
            this.dsCustomer = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.btnSearchCustomer = new FontAwesome.Sharp.IconPictureBox();
            this.btnEdit = new ns1.BunifuFlatButton();
            this.btnBatal = new ns1.BunifuFlatButton();
            this.btnHapus = new ns1.BunifuFlatButton();
            this.btnSimpan = new ns1.BunifuFlatButton();
            this.cbKamar = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.dpCheckIn = new ns1.BunifuDatepicker();
            this.dpCheckOut = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.tbTotalHarga = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.btnSearchKamar = new FontAwesome.Sharp.IconPictureBox();
            this.tbSearchKamar = new ns1.BunifuMaterialTextbox();
            this.dsKamar = new ns1.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(35, 84);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(315, 21);
            this.cbCustomer.TabIndex = 180;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchCustomer.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchCustomer.HintText = "";
            this.tbSearchCustomer.isPassword = false;
            this.tbSearchCustomer.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchCustomer.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchCustomer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchCustomer.LineThickness = 3;
            this.tbSearchCustomer.Location = new System.Drawing.Point(658, 115);
            this.tbSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(315, 27);
            this.tbSearchCustomer.TabIndex = 174;
            this.tbSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchCustomer.OnValueChanged += new System.EventHandler(this.tbSearch_OnValueChanged);
            // 
            // dsCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCustomer.DoubleBuffered = true;
            this.dsCustomer.EnableHeadersVisualStyles = false;
            this.dsCustomer.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsCustomer.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsCustomer.Location = new System.Drawing.Point(430, 149);
            this.dsCustomer.Name = "dsCustomer";
            this.dsCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsCustomer.Size = new System.Drawing.Size(617, 176);
            this.dsCustomer.TabIndex = 169;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 189);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel3.TabIndex = 168;
            this.bunifuCustomLabel3.Text = "Check In";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel2.TabIndex = 167;
            this.bunifuCustomLabel2.Text = "Customer";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCustomer.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCustomer.Location = new System.Drawing.Point(989, 115);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(32, 32);
            this.btnSearchCustomer.TabIndex = 175;
            this.btnSearchCustomer.TabStop = false;
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
            this.btnEdit.Location = new System.Drawing.Point(221, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(129, 35);
            this.btnEdit.TabIndex = 171;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(221, 473);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnBatal.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 173;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Textcolor = System.Drawing.Color.White;
            this.btnBatal.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
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
            this.btnHapus.Location = new System.Drawing.Point(35, 473);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.Red;
            this.btnHapus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(129, 35);
            this.btnHapus.TabIndex = 172;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Textcolor = System.Drawing.Color.White;
            this.btnHapus.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
            this.btnSimpan.Location = new System.Drawing.Point(35, 428);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 170;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // cbKamar
            // 
            this.cbKamar.FormattingEnabled = true;
            this.cbKamar.Location = new System.Drawing.Point(35, 149);
            this.cbKamar.Name = "cbKamar";
            this.cbKamar.Size = new System.Drawing.Size(315, 21);
            this.cbKamar.TabIndex = 182;
            this.cbKamar.SelectedIndexChanged += new System.EventHandler(this.cbKamar_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 121);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 20);
            this.bunifuCustomLabel1.TabIndex = 181;
            this.bunifuCustomLabel1.Text = "Kamar";
            // 
            // dpCheckIn
            // 
            this.dpCheckIn.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCheckIn.BorderRadius = 0;
            this.dpCheckIn.ForeColor = System.Drawing.Color.White;
            this.dpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCheckIn.FormatCustom = null;
            this.dpCheckIn.Location = new System.Drawing.Point(35, 212);
            this.dpCheckIn.Name = "dpCheckIn";
            this.dpCheckIn.Size = new System.Drawing.Size(315, 36);
            this.dpCheckIn.TabIndex = 183;
            this.dpCheckIn.Value = new System.DateTime(2022, 6, 13, 10, 46, 56, 607);
            // 
            // dpCheckOut
            // 
            this.dpCheckOut.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCheckOut.BorderRadius = 0;
            this.dpCheckOut.ForeColor = System.Drawing.Color.White;
            this.dpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCheckOut.FormatCustom = null;
            this.dpCheckOut.Location = new System.Drawing.Point(35, 289);
            this.dpCheckOut.Name = "dpCheckOut";
            this.dpCheckOut.Size = new System.Drawing.Size(315, 36);
            this.dpCheckOut.TabIndex = 185;
            this.dpCheckOut.Value = new System.DateTime(2022, 6, 13, 10, 46, 56, 607);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(31, 266);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(84, 20);
            this.bunifuCustomLabel5.TabIndex = 184;
            this.bunifuCustomLabel5.Text = "Check Out";
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalHarga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTotalHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTotalHarga.HintForeColor = System.Drawing.Color.Empty;
            this.tbTotalHarga.HintText = "";
            this.tbTotalHarga.isPassword = false;
            this.tbTotalHarga.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbTotalHarga.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTotalHarga.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbTotalHarga.LineThickness = 3;
            this.tbTotalHarga.Location = new System.Drawing.Point(35, 371);
            this.tbTotalHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(315, 27);
            this.tbTotalHarga.TabIndex = 187;
            this.tbTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 347);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(92, 20);
            this.bunifuCustomLabel4.TabIndex = 186;
            this.bunifuCustomLabel4.Text = "Total Harga";
            // 
            // btnSearchKamar
            // 
            this.btnSearchKamar.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchKamar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchKamar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchKamar.Location = new System.Drawing.Point(989, 353);
            this.btnSearchKamar.Name = "btnSearchKamar";
            this.btnSearchKamar.Size = new System.Drawing.Size(32, 32);
            this.btnSearchKamar.TabIndex = 190;
            this.btnSearchKamar.TabStop = false;
            this.btnSearchKamar.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // tbSearchKamar
            // 
            this.tbSearchKamar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchKamar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchKamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchKamar.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchKamar.HintText = "";
            this.tbSearchKamar.isPassword = false;
            this.tbSearchKamar.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchKamar.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchKamar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchKamar.LineThickness = 3;
            this.tbSearchKamar.Location = new System.Drawing.Point(658, 353);
            this.tbSearchKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchKamar.Name = "tbSearchKamar";
            this.tbSearchKamar.Size = new System.Drawing.Size(315, 27);
            this.tbSearchKamar.TabIndex = 189;
            this.tbSearchKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchKamar.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // dsKamar
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dsKamar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsKamar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dsKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKamar.DoubleBuffered = true;
            this.dsKamar.EnableHeadersVisualStyles = false;
            this.dsKamar.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsKamar.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsKamar.Location = new System.Drawing.Point(430, 387);
            this.dsKamar.Name = "dsKamar";
            this.dsKamar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsKamar.Size = new System.Drawing.Size(617, 176);
            this.dsKamar.TabIndex = 188;
            this.dsKamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // FormTransaksiKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.btnSearchKamar);
            this.Controls.Add(this.tbSearchKamar);
            this.Controls.Add(this.dsKamar);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dpCheckOut);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dpCheckIn);
            this.Controls.Add(this.cbKamar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.tbSearchCustomer);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dsCustomer);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormTransaksiKamar";
            this.Text = "Transaksi Kamar";
            this.Load += new System.EventHandler(this.FormTransaksiKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCustomer;
        private FontAwesome.Sharp.IconPictureBox btnSearchCustomer;
        private ns1.BunifuMaterialTextbox tbSearchCustomer;
        private ns1.BunifuFlatButton btnEdit;
        private ns1.BunifuFlatButton btnBatal;
        private ns1.BunifuFlatButton btnHapus;
        private ns1.BunifuFlatButton btnSimpan;
        private ns1.BunifuCustomDataGrid dsCustomer;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cbKamar;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDatepicker dpCheckIn;
        private ns1.BunifuDatepicker dpCheckOut;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMaterialTextbox tbTotalHarga;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private FontAwesome.Sharp.IconPictureBox btnSearchKamar;
        private ns1.BunifuMaterialTextbox tbSearchKamar;
        private ns1.BunifuCustomDataGrid dsKamar;
    }
}