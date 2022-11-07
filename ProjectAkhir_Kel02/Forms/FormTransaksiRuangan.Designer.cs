
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormTransaksiRuangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiRuangan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.dpCheckOut = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.dpCheckIn = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.tbRuangan = new ns1.BunifuMaterialTextbox();
            this.tbCustomer = new ns1.BunifuMaterialTextbox();
            this.btnCheckOut = new ns1.BunifuFlatButton();
            this.btnBatal = new ns1.BunifuFlatButton();
            this.btnSimpan = new ns1.BunifuFlatButton();
            this.btnSearchTrsRuangan = new FontAwesome.Sharp.IconPictureBox();
            this.tbSearchTrsRuangan = new ns1.BunifuMaterialTextbox();
            this.dsTrsRuangan = new ns1.BunifuCustomDataGrid();
            this.btnSearchRuangan = new FontAwesome.Sharp.IconPictureBox();
            this.tbSearchRuangan = new ns1.BunifuMaterialTextbox();
            this.dsRuangan = new ns1.BunifuCustomDataGrid();
            this.btnSearchCustomer = new FontAwesome.Sharp.IconPictureBox();
            this.tbSearchCustomer = new ns1.BunifuMaterialTextbox();
            this.dsCustomer = new ns1.BunifuCustomDataGrid();
            this.tbTotalHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTrsRuangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrsRuangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRuangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRuangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 388);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(103, 20);
            this.bunifuCustomLabel4.TabIndex = 206;
            this.bunifuCustomLabel4.Text = "Total Harga";
            // 
            // dpCheckOut
            // 
            this.dpCheckOut.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCheckOut.BorderRadius = 0;
            this.dpCheckOut.ForeColor = System.Drawing.Color.White;
            this.dpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCheckOut.FormatCustom = null;
            this.dpCheckOut.Location = new System.Drawing.Point(35, 330);
            this.dpCheckOut.Name = "dpCheckOut";
            this.dpCheckOut.Size = new System.Drawing.Size(315, 36);
            this.dpCheckOut.TabIndex = 205;
            this.dpCheckOut.Value = new System.DateTime(2022, 6, 13, 10, 46, 56, 607);
            this.dpCheckOut.onValueChanged += new System.EventHandler(this.dpCheckOut_onValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(31, 307);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 20);
            this.bunifuCustomLabel5.TabIndex = 204;
            this.bunifuCustomLabel5.Text = "Check Out";
            // 
            // dpCheckIn
            // 
            this.dpCheckIn.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCheckIn.BorderRadius = 0;
            this.dpCheckIn.ForeColor = System.Drawing.Color.White;
            this.dpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCheckIn.FormatCustom = null;
            this.dpCheckIn.Location = new System.Drawing.Point(35, 253);
            this.dpCheckIn.Name = "dpCheckIn";
            this.dpCheckIn.Size = new System.Drawing.Size(315, 36);
            this.dpCheckIn.TabIndex = 203;
            this.dpCheckIn.Value = new System.DateTime(2022, 6, 13, 10, 46, 56, 607);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 158);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel1.TabIndex = 201;
            this.bunifuCustomLabel1.Text = "Ruangan";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 230);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 20);
            this.bunifuCustomLabel3.TabIndex = 192;
            this.bunifuCustomLabel3.Text = "Check In";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 90);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(86, 20);
            this.bunifuCustomLabel2.TabIndex = 191;
            this.bunifuCustomLabel2.Text = "Customer";
            // 
            // tbRuangan
            // 
            this.tbRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRuangan.Enabled = false;
            this.tbRuangan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRuangan.HintForeColor = System.Drawing.Color.Empty;
            this.tbRuangan.HintText = "Pilih Ruangan dari Data Grid";
            this.tbRuangan.isPassword = false;
            this.tbRuangan.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbRuangan.LineIdleColor = System.Drawing.Color.Gray;
            this.tbRuangan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbRuangan.LineThickness = 3;
            this.tbRuangan.Location = new System.Drawing.Point(35, 188);
            this.tbRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.tbRuangan.Name = "tbRuangan";
            this.tbRuangan.Size = new System.Drawing.Size(315, 27);
            this.tbRuangan.TabIndex = 211;
            this.tbRuangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCustomer.Enabled = false;
            this.tbCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCustomer.HintForeColor = System.Drawing.Color.Empty;
            this.tbCustomer.HintText = "Pilih Customer dari Data Grid";
            this.tbCustomer.isPassword = false;
            this.tbCustomer.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCustomer.LineIdleColor = System.Drawing.Color.Gray;
            this.tbCustomer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCustomer.LineThickness = 3;
            this.tbCustomer.Location = new System.Drawing.Point(35, 120);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(315, 27);
            this.tbCustomer.TabIndex = 212;
            this.tbCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.BorderRadius = 0;
            this.btnCheckOut.ButtonText = "Check Out";
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Iconimage")));
            this.btnCheckOut.Iconimage_right = null;
            this.btnCheckOut.Iconimage_right_Selected = null;
            this.btnCheckOut.Iconimage_Selected = null;
            this.btnCheckOut.IconMarginLeft = 0;
            this.btnCheckOut.IconMarginRight = 0;
            this.btnCheckOut.IconRightVisible = true;
            this.btnCheckOut.IconRightZoom = 0D;
            this.btnCheckOut.IconVisible = true;
            this.btnCheckOut.IconZoom = 90D;
            this.btnCheckOut.IsTab = false;
            this.btnCheckOut.Location = new System.Drawing.Point(35, 517);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCheckOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckOut.selected = false;
            this.btnCheckOut.Size = new System.Drawing.Size(315, 35);
            this.btnCheckOut.TabIndex = 226;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Textcolor = System.Drawing.Color.White;
            this.btnCheckOut.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(221, 467);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnBatal.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 225;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Textcolor = System.Drawing.Color.White;
            this.btnBatal.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
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
            this.btnSimpan.Location = new System.Drawing.Point(35, 467);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 224;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnSearchTrsRuangan
            // 
            this.btnSearchTrsRuangan.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTrsRuangan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchTrsRuangan.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchTrsRuangan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchTrsRuangan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchTrsRuangan.Location = new System.Drawing.Point(997, 369);
            this.btnSearchTrsRuangan.Name = "btnSearchTrsRuangan";
            this.btnSearchTrsRuangan.Size = new System.Drawing.Size(32, 32);
            this.btnSearchTrsRuangan.TabIndex = 235;
            this.btnSearchTrsRuangan.TabStop = false;
            this.btnSearchTrsRuangan.Click += new System.EventHandler(this.btnSearchTrsRuangan_Click);
            // 
            // tbSearchTrsRuangan
            // 
            this.tbSearchTrsRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTrsRuangan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchTrsRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchTrsRuangan.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchTrsRuangan.HintText = "Pilih dan Cari Transaksi Ruangan";
            this.tbSearchTrsRuangan.isPassword = false;
            this.tbSearchTrsRuangan.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchTrsRuangan.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchTrsRuangan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchTrsRuangan.LineThickness = 3;
            this.tbSearchTrsRuangan.Location = new System.Drawing.Point(751, 374);
            this.tbSearchTrsRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTrsRuangan.Name = "tbSearchTrsRuangan";
            this.tbSearchTrsRuangan.Size = new System.Drawing.Size(236, 27);
            this.tbSearchTrsRuangan.TabIndex = 234;
            this.tbSearchTrsRuangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchTrsRuangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchTrsRuangan_KeyPress);
            // 
            // dsTrsRuangan
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsTrsRuangan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dsTrsRuangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsTrsRuangan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsTrsRuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsTrsRuangan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsTrsRuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dsTrsRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTrsRuangan.DoubleBuffered = true;
            this.dsTrsRuangan.EnableHeadersVisualStyles = false;
            this.dsTrsRuangan.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsTrsRuangan.HeaderForeColor = System.Drawing.Color.White;
            this.dsTrsRuangan.Location = new System.Drawing.Point(422, 408);
            this.dsTrsRuangan.Name = "dsTrsRuangan";
            this.dsTrsRuangan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsTrsRuangan.Size = new System.Drawing.Size(617, 176);
            this.dsTrsRuangan.TabIndex = 233;
            this.dsTrsRuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTrsRuangan_CellClick);
            // 
            // btnSearchRuangan
            // 
            this.btnSearchRuangan.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchRuangan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchRuangan.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchRuangan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchRuangan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchRuangan.Location = new System.Drawing.Point(969, 111);
            this.btnSearchRuangan.Name = "btnSearchRuangan";
            this.btnSearchRuangan.Size = new System.Drawing.Size(32, 32);
            this.btnSearchRuangan.TabIndex = 232;
            this.btnSearchRuangan.TabStop = false;
            this.btnSearchRuangan.Click += new System.EventHandler(this.btnSearchRuangan_Click_1);
            // 
            // tbSearchRuangan
            // 
            this.tbSearchRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchRuangan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchRuangan.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchRuangan.HintText = "Pilih dan Cari Ruangan";
            this.tbSearchRuangan.isPassword = false;
            this.tbSearchRuangan.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchRuangan.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchRuangan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchRuangan.LineThickness = 3;
            this.tbSearchRuangan.Location = new System.Drawing.Point(783, 116);
            this.tbSearchRuangan.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchRuangan.Name = "tbSearchRuangan";
            this.tbSearchRuangan.Size = new System.Drawing.Size(168, 27);
            this.tbSearchRuangan.TabIndex = 231;
            this.tbSearchRuangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchRuangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchRuangan_KeyPress);
            // 
            // dsRuangan
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsRuangan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dsRuangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsRuangan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsRuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsRuangan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsRuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dsRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsRuangan.DoubleBuffered = true;
            this.dsRuangan.EnableHeadersVisualStyles = false;
            this.dsRuangan.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsRuangan.HeaderForeColor = System.Drawing.Color.White;
            this.dsRuangan.Location = new System.Drawing.Point(733, 150);
            this.dsRuangan.Name = "dsRuangan";
            this.dsRuangan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsRuangan.Size = new System.Drawing.Size(282, 176);
            this.dsRuangan.TabIndex = 230;
            this.dsRuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsRuangan_CellClick);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCustomer.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCustomer.Location = new System.Drawing.Point(673, 116);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(32, 32);
            this.btnSearchCustomer.TabIndex = 229;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click_1);
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchCustomer.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchCustomer.HintText = "Pilih dan Cari Customer";
            this.tbSearchCustomer.isPassword = false;
            this.tbSearchCustomer.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchCustomer.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchCustomer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchCustomer.LineThickness = 3;
            this.tbSearchCustomer.Location = new System.Drawing.Point(479, 116);
            this.tbSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(178, 27);
            this.tbSearchCustomer.TabIndex = 228;
            this.tbSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchCustomer_KeyPress);
            // 
            // dsCustomer
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dsCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCustomer.DoubleBuffered = true;
            this.dsCustomer.EnableHeadersVisualStyles = false;
            this.dsCustomer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dsCustomer.Location = new System.Drawing.Point(436, 151);
            this.dsCustomer.Name = "dsCustomer";
            this.dsCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsCustomer.Size = new System.Drawing.Size(282, 176);
            this.dsCustomer.TabIndex = 227;
            this.dsCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsCustomer_CellClick);
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.AutoSize = true;
            this.tbTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHarga.ForeColor = System.Drawing.Color.Red;
            this.tbTotalHarga.Location = new System.Drawing.Point(62, 422);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(17, 18);
            this.tbTotalHarga.TabIndex = 246;
            this.tbTotalHarga.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 245;
            this.label4.Text = "Rp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(418, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 247;
            this.label2.Text = "Daftar Transaksi Ruangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(432, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 248;
            this.label1.Text = "Daftar Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(729, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 249;
            this.label3.Text = "Daftar Ruangan";
            // 
            // FormTransaksiRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchTrsRuangan);
            this.Controls.Add(this.tbSearchTrsRuangan);
            this.Controls.Add(this.dsTrsRuangan);
            this.Controls.Add(this.btnSearchRuangan);
            this.Controls.Add(this.tbSearchRuangan);
            this.Controls.Add(this.dsRuangan);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.tbSearchCustomer);
            this.Controls.Add(this.dsCustomer);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbRuangan);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dpCheckOut);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dpCheckIn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormTransaksiRuangan";
            this.Text = "Transaksi Ruangan";
            this.Load += new System.EventHandler(this.FormTransaksiRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTrsRuangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrsRuangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRuangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRuangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuDatepicker dpCheckOut;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuDatepicker dpCheckIn;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMaterialTextbox tbRuangan;
        private ns1.BunifuMaterialTextbox tbCustomer;
        private ns1.BunifuFlatButton btnCheckOut;
        private ns1.BunifuFlatButton btnBatal;
        private ns1.BunifuFlatButton btnSimpan;
        private FontAwesome.Sharp.IconPictureBox btnSearchTrsRuangan;
        private ns1.BunifuMaterialTextbox tbSearchTrsRuangan;
        private ns1.BunifuCustomDataGrid dsTrsRuangan;
        private FontAwesome.Sharp.IconPictureBox btnSearchRuangan;
        private ns1.BunifuMaterialTextbox tbSearchRuangan;
        private ns1.BunifuCustomDataGrid dsRuangan;
        private FontAwesome.Sharp.IconPictureBox btnSearchCustomer;
        private ns1.BunifuMaterialTextbox tbSearchCustomer;
        private ns1.BunifuCustomDataGrid dsCustomer;
        private System.Windows.Forms.Label tbTotalHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}