
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormTransaksiPembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiPembelian));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sI_HotelDataSet6 = new ProjectAkhir_Kel02.SI_HotelDataSet6();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.dsMenu = new ns1.BunifuCustomDataGrid();
            this.tbJumlah = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.btnTambahMenu = new ns1.BunifuFlatButton();
            this.dsDetailPembelian = new ns1.BunifuCustomDataGrid();
            this.btnSearchMenu = new FontAwesome.Sharp.IconPictureBox();
            this.tbSearchMenu = new ns1.BunifuMaterialTextbox();
            this.btnHapusMenu = new ns1.BunifuFlatButton();
            this.btnEditMenu = new ns1.BunifuFlatButton();
            this.btnHapusSemuaMenu = new ns1.BunifuFlatButton();
            this.tbCustomer = new ns1.BunifuMaterialTextbox();
            this.tbKamar = new ns1.BunifuMaterialTextbox();
            this.btnSearchTrsKamar = new FontAwesome.Sharp.IconPictureBox();
            this.tbSearchTrsKamar = new ns1.BunifuMaterialTextbox();
            this.dsTrsKamar = new ns1.BunifuCustomDataGrid();
            this.menuTableAdapter = new ProjectAkhir_Kel02.SI_HotelDataSet6TableAdapters.MenuTableAdapter();
            this.btnTerbayar = new ns1.BunifuFlatButton();
            this.btnDetailPembelian = new FontAwesome.Sharp.IconPictureBox();
            this.tbDetailPembelian = new ns1.BunifuMaterialTextbox();
            this.tbMenu = new ns1.BunifuMaterialTextbox();
            this.btnBatalPembayaran = new ns1.BunifuFlatButton();
            this.cbDibayar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_HotelDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetailPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTrsKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrsKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 429);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(103, 20);
            this.bunifuCustomLabel4.TabIndex = 206;
            this.bunifuCustomLabel4.Text = "Total Harga";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 125);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 20);
            this.bunifuCustomLabel1.TabIndex = 201;
            this.bunifuCustomLabel1.Text = "Kamar";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 48);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(86, 20);
            this.bunifuCustomLabel2.TabIndex = 191;
            this.bunifuCustomLabel2.Text = "Customer";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.sI_HotelDataSet6;
            // 
            // sI_HotelDataSet6
            // 
            this.sI_HotelDataSet6.DataSetName = "SI_HotelDataSet6";
            this.sI_HotelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 223);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(53, 20);
            this.bunifuCustomLabel3.TabIndex = 211;
            this.bunifuCustomLabel3.Text = "Menu";
            // 
            // dsMenu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsMenu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMenu.DoubleBuffered = true;
            this.dsMenu.EnableHeadersVisualStyles = false;
            this.dsMenu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsMenu.HeaderForeColor = System.Drawing.Color.White;
            this.dsMenu.Location = new System.Drawing.Point(426, 278);
            this.dsMenu.Name = "dsMenu";
            this.dsMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsMenu.Size = new System.Drawing.Size(617, 176);
            this.dsMenu.TabIndex = 213;
            this.dsMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMenu_CellClick);
            this.dsMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMenu_CellContentClick);
            // 
            // tbJumlah
            // 
            this.tbJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJumlah.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbJumlah.HintForeColor = System.Drawing.Color.Empty;
            this.tbJumlah.HintText = "Masukkan Jumlah";
            this.tbJumlah.isPassword = false;
            this.tbJumlah.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbJumlah.LineIdleColor = System.Drawing.Color.Gray;
            this.tbJumlah.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbJumlah.LineThickness = 3;
            this.tbJumlah.Location = new System.Drawing.Point(198, 245);
            this.tbJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(152, 27);
            this.tbJumlah.TabIndex = 216;
            this.tbJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbJumlah.OnValueChanged += new System.EventHandler(this.tbJumlah_OnValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(194, 223);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel5.TabIndex = 215;
            this.bunifuCustomLabel5.Text = "Jumlah";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // btnTambahMenu
            // 
            this.btnTambahMenu.Activecolor = System.Drawing.Color.ForestGreen;
            this.btnTambahMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTambahMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahMenu.BorderRadius = 0;
            this.btnTambahMenu.ButtonText = "Tambah Menu";
            this.btnTambahMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambahMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambahMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTambahMenu.Iconimage")));
            this.btnTambahMenu.Iconimage_right = null;
            this.btnTambahMenu.Iconimage_right_Selected = null;
            this.btnTambahMenu.Iconimage_Selected = null;
            this.btnTambahMenu.IconMarginLeft = 0;
            this.btnTambahMenu.IconMarginRight = 0;
            this.btnTambahMenu.IconRightVisible = true;
            this.btnTambahMenu.IconRightZoom = 0D;
            this.btnTambahMenu.IconVisible = true;
            this.btnTambahMenu.IconZoom = 90D;
            this.btnTambahMenu.IsTab = false;
            this.btnTambahMenu.Location = new System.Drawing.Point(35, 300);
            this.btnTambahMenu.Name = "btnTambahMenu";
            this.btnTambahMenu.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnTambahMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTambahMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTambahMenu.selected = false;
            this.btnTambahMenu.Size = new System.Drawing.Size(99, 35);
            this.btnTambahMenu.TabIndex = 217;
            this.btnTambahMenu.Text = "Tambah Menu";
            this.btnTambahMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambahMenu.Textcolor = System.Drawing.Color.White;
            this.btnTambahMenu.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahMenu.Click += new System.EventHandler(this.btnTambahMenu_Click);
            // 
            // dsDetailPembelian
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsDetailPembelian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dsDetailPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsDetailPembelian.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsDetailPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsDetailPembelian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsDetailPembelian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dsDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDetailPembelian.DoubleBuffered = true;
            this.dsDetailPembelian.EnableHeadersVisualStyles = false;
            this.dsDetailPembelian.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsDetailPembelian.HeaderForeColor = System.Drawing.Color.White;
            this.dsDetailPembelian.Location = new System.Drawing.Point(426, 525);
            this.dsDetailPembelian.Name = "dsDetailPembelian";
            this.dsDetailPembelian.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsDetailPembelian.Size = new System.Drawing.Size(617, 140);
            this.dsDetailPembelian.TabIndex = 218;
            this.dsDetailPembelian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDetailPembelian_CellClick);
            this.dsDetailPembelian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDetailPembelian_CellContentClick);
            // 
            // btnSearchMenu
            // 
            this.btnSearchMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchMenu.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchMenu.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchMenu.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchMenu.Location = new System.Drawing.Point(998, 239);
            this.btnSearchMenu.Name = "btnSearchMenu";
            this.btnSearchMenu.Size = new System.Drawing.Size(32, 32);
            this.btnSearchMenu.TabIndex = 220;
            this.btnSearchMenu.TabStop = false;
            this.btnSearchMenu.Click += new System.EventHandler(this.btnSearchMenu_Click);
            // 
            // tbSearchMenu
            // 
            this.tbSearchMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchMenu.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchMenu.HintText = "Pilih dan Cari Menu";
            this.tbSearchMenu.isPassword = false;
            this.tbSearchMenu.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchMenu.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchMenu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchMenu.LineThickness = 3;
            this.tbSearchMenu.Location = new System.Drawing.Point(755, 244);
            this.tbSearchMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchMenu.Name = "tbSearchMenu";
            this.tbSearchMenu.Size = new System.Drawing.Size(236, 27);
            this.tbSearchMenu.TabIndex = 219;
            this.tbSearchMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchMenu_KeyPress);
            // 
            // btnHapusMenu
            // 
            this.btnHapusMenu.Activecolor = System.Drawing.Color.Red;
            this.btnHapusMenu.BackColor = System.Drawing.Color.Red;
            this.btnHapusMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusMenu.BorderRadius = 0;
            this.btnHapusMenu.ButtonText = "Hapus Menu";
            this.btnHapusMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapusMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapusMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHapusMenu.Iconimage")));
            this.btnHapusMenu.Iconimage_right = null;
            this.btnHapusMenu.Iconimage_right_Selected = null;
            this.btnHapusMenu.Iconimage_Selected = null;
            this.btnHapusMenu.IconMarginLeft = 0;
            this.btnHapusMenu.IconMarginRight = 0;
            this.btnHapusMenu.IconRightVisible = true;
            this.btnHapusMenu.IconRightZoom = 0D;
            this.btnHapusMenu.IconVisible = true;
            this.btnHapusMenu.IconZoom = 90D;
            this.btnHapusMenu.IsTab = false;
            this.btnHapusMenu.Location = new System.Drawing.Point(251, 300);
            this.btnHapusMenu.Name = "btnHapusMenu";
            this.btnHapusMenu.Normalcolor = System.Drawing.Color.Red;
            this.btnHapusMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapusMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapusMenu.selected = false;
            this.btnHapusMenu.Size = new System.Drawing.Size(99, 35);
            this.btnHapusMenu.TabIndex = 221;
            this.btnHapusMenu.Text = "Hapus Menu";
            this.btnHapusMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusMenu.Textcolor = System.Drawing.Color.White;
            this.btnHapusMenu.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusMenu.Click += new System.EventHandler(this.btnHapusMenu_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditMenu.BorderRadius = 0;
            this.btnEditMenu.ButtonText = "Edit Menu";
            this.btnEditMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditMenu.Iconimage")));
            this.btnEditMenu.Iconimage_right = null;
            this.btnEditMenu.Iconimage_right_Selected = null;
            this.btnEditMenu.Iconimage_Selected = null;
            this.btnEditMenu.IconMarginLeft = 0;
            this.btnEditMenu.IconMarginRight = 0;
            this.btnEditMenu.IconRightVisible = true;
            this.btnEditMenu.IconRightZoom = 0D;
            this.btnEditMenu.IconVisible = true;
            this.btnEditMenu.IconZoom = 90D;
            this.btnEditMenu.IsTab = false;
            this.btnEditMenu.Location = new System.Drawing.Point(143, 300);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditMenu.selected = false;
            this.btnEditMenu.Size = new System.Drawing.Size(99, 35);
            this.btnEditMenu.TabIndex = 222;
            this.btnEditMenu.Text = "Edit Menu";
            this.btnEditMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMenu.Textcolor = System.Drawing.Color.White;
            this.btnEditMenu.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
            // 
            // btnHapusSemuaMenu
            // 
            this.btnHapusSemuaMenu.Activecolor = System.Drawing.Color.Red;
            this.btnHapusSemuaMenu.BackColor = System.Drawing.Color.Red;
            this.btnHapusSemuaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusSemuaMenu.BorderRadius = 0;
            this.btnHapusSemuaMenu.ButtonText = "Hapus Semua Menu";
            this.btnHapusSemuaMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusSemuaMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapusSemuaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusSemuaMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapusSemuaMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHapusSemuaMenu.Iconimage")));
            this.btnHapusSemuaMenu.Iconimage_right = null;
            this.btnHapusSemuaMenu.Iconimage_right_Selected = null;
            this.btnHapusSemuaMenu.Iconimage_Selected = null;
            this.btnHapusSemuaMenu.IconMarginLeft = 0;
            this.btnHapusSemuaMenu.IconMarginRight = 0;
            this.btnHapusSemuaMenu.IconRightVisible = true;
            this.btnHapusSemuaMenu.IconRightZoom = 0D;
            this.btnHapusSemuaMenu.IconVisible = true;
            this.btnHapusSemuaMenu.IconZoom = 90D;
            this.btnHapusSemuaMenu.IsTab = false;
            this.btnHapusSemuaMenu.Location = new System.Drawing.Point(35, 350);
            this.btnHapusSemuaMenu.Name = "btnHapusSemuaMenu";
            this.btnHapusSemuaMenu.Normalcolor = System.Drawing.Color.Red;
            this.btnHapusSemuaMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapusSemuaMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapusSemuaMenu.selected = false;
            this.btnHapusSemuaMenu.Size = new System.Drawing.Size(152, 35);
            this.btnHapusSemuaMenu.TabIndex = 223;
            this.btnHapusSemuaMenu.Text = "Hapus Semua Menu";
            this.btnHapusSemuaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusSemuaMenu.Textcolor = System.Drawing.Color.White;
            this.btnHapusSemuaMenu.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusSemuaMenu.Click += new System.EventHandler(this.btnHapusSemuaMenu_Click);
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
            this.tbCustomer.Location = new System.Drawing.Point(35, 77);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(315, 27);
            this.tbCustomer.TabIndex = 227;
            this.tbCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbKamar
            // 
            this.tbKamar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKamar.Enabled = false;
            this.tbKamar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbKamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbKamar.HintForeColor = System.Drawing.Color.Empty;
            this.tbKamar.HintText = "Pilih Kamar dari Data Grid";
            this.tbKamar.isPassword = false;
            this.tbKamar.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbKamar.LineIdleColor = System.Drawing.Color.Gray;
            this.tbKamar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbKamar.LineThickness = 3;
            this.tbKamar.Location = new System.Drawing.Point(35, 155);
            this.tbKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbKamar.Name = "tbKamar";
            this.tbKamar.Size = new System.Drawing.Size(315, 27);
            this.tbKamar.TabIndex = 228;
            this.tbKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearchTrsKamar
            // 
            this.btnSearchTrsKamar.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTrsKamar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchTrsKamar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchTrsKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchTrsKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchTrsKamar.Location = new System.Drawing.Point(998, 87);
            this.btnSearchTrsKamar.Name = "btnSearchTrsKamar";
            this.btnSearchTrsKamar.Size = new System.Drawing.Size(32, 32);
            this.btnSearchTrsKamar.TabIndex = 231;
            this.btnSearchTrsKamar.TabStop = false;
            this.btnSearchTrsKamar.Click += new System.EventHandler(this.btnSearchTrsKamar_Click);
            // 
            // tbSearchTrsKamar
            // 
            this.tbSearchTrsKamar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTrsKamar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchTrsKamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchTrsKamar.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchTrsKamar.HintText = "Pilih dan Cari Transaksi Kamar";
            this.tbSearchTrsKamar.isPassword = false;
            this.tbSearchTrsKamar.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchTrsKamar.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchTrsKamar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchTrsKamar.LineThickness = 3;
            this.tbSearchTrsKamar.Location = new System.Drawing.Point(755, 92);
            this.tbSearchTrsKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTrsKamar.Name = "tbSearchTrsKamar";
            this.tbSearchTrsKamar.Size = new System.Drawing.Size(236, 27);
            this.tbSearchTrsKamar.TabIndex = 230;
            this.tbSearchTrsKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchTrsKamar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchTrsKamar_KeyPress);
            // 
            // dsTrsKamar
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsTrsKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dsTrsKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsTrsKamar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsTrsKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsTrsKamar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsTrsKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dsTrsKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTrsKamar.DoubleBuffered = true;
            this.dsTrsKamar.EnableHeadersVisualStyles = false;
            this.dsTrsKamar.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsTrsKamar.HeaderForeColor = System.Drawing.Color.White;
            this.dsTrsKamar.Location = new System.Drawing.Point(426, 125);
            this.dsTrsKamar.Name = "dsTrsKamar";
            this.dsTrsKamar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsTrsKamar.Size = new System.Drawing.Size(617, 99);
            this.dsTrsKamar.TabIndex = 229;
            this.dsTrsKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTrsKamar_CellClick);
            this.dsTrsKamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTrsKamar_CellContentClick);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // btnTerbayar
            // 
            this.btnTerbayar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTerbayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTerbayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerbayar.BorderRadius = 0;
            this.btnTerbayar.ButtonText = "Beli Menu";
            this.btnTerbayar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerbayar.DisabledColor = System.Drawing.Color.Gray;
            this.btnTerbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerbayar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTerbayar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTerbayar.Iconimage")));
            this.btnTerbayar.Iconimage_right = null;
            this.btnTerbayar.Iconimage_right_Selected = null;
            this.btnTerbayar.Iconimage_Selected = null;
            this.btnTerbayar.IconMarginLeft = 0;
            this.btnTerbayar.IconMarginRight = 0;
            this.btnTerbayar.IconRightVisible = true;
            this.btnTerbayar.IconRightZoom = 0D;
            this.btnTerbayar.IconVisible = true;
            this.btnTerbayar.IconZoom = 90D;
            this.btnTerbayar.IsTab = false;
            this.btnTerbayar.Location = new System.Drawing.Point(35, 538);
            this.btnTerbayar.Name = "btnTerbayar";
            this.btnTerbayar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTerbayar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTerbayar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTerbayar.selected = false;
            this.btnTerbayar.Size = new System.Drawing.Size(315, 35);
            this.btnTerbayar.TabIndex = 234;
            this.btnTerbayar.Text = "Beli Menu";
            this.btnTerbayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerbayar.Textcolor = System.Drawing.Color.White;
            this.btnTerbayar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerbayar.Click += new System.EventHandler(this.btnTerbayar_Click);
            // 
            // btnDetailPembelian
            // 
            this.btnDetailPembelian.BackColor = System.Drawing.Color.Transparent;
            this.btnDetailPembelian.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDetailPembelian.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnDetailPembelian.IconColor = System.Drawing.Color.MediumBlue;
            this.btnDetailPembelian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetailPembelian.Location = new System.Drawing.Point(998, 486);
            this.btnDetailPembelian.Name = "btnDetailPembelian";
            this.btnDetailPembelian.Size = new System.Drawing.Size(32, 32);
            this.btnDetailPembelian.TabIndex = 236;
            this.btnDetailPembelian.TabStop = false;
            this.btnDetailPembelian.Click += new System.EventHandler(this.btnDetailPembelian_Click);
            // 
            // tbDetailPembelian
            // 
            this.tbDetailPembelian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDetailPembelian.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbDetailPembelian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDetailPembelian.HintForeColor = System.Drawing.Color.Empty;
            this.tbDetailPembelian.HintText = "7";
            this.tbDetailPembelian.isPassword = false;
            this.tbDetailPembelian.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbDetailPembelian.LineIdleColor = System.Drawing.Color.Gray;
            this.tbDetailPembelian.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbDetailPembelian.LineThickness = 3;
            this.tbDetailPembelian.Location = new System.Drawing.Point(755, 491);
            this.tbDetailPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.tbDetailPembelian.Name = "tbDetailPembelian";
            this.tbDetailPembelian.Size = new System.Drawing.Size(236, 27);
            this.tbDetailPembelian.TabIndex = 235;
            this.tbDetailPembelian.Text = "Pilih dan Cari Detail Pembelian";
            this.tbDetailPembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDetailPembelian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDetailPembelian_KeyPress);
            // 
            // tbMenu
            // 
            this.tbMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMenu.Enabled = false;
            this.tbMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMenu.HintForeColor = System.Drawing.Color.Empty;
            this.tbMenu.HintText = "Pilih Menu";
            this.tbMenu.isPassword = false;
            this.tbMenu.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbMenu.LineIdleColor = System.Drawing.Color.Gray;
            this.tbMenu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbMenu.LineThickness = 3;
            this.tbMenu.Location = new System.Drawing.Point(35, 245);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(152, 27);
            this.tbMenu.TabIndex = 237;
            this.tbMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBatalPembayaran
            // 
            this.btnBatalPembayaran.Activecolor = System.Drawing.Color.Red;
            this.btnBatalPembayaran.BackColor = System.Drawing.Color.Red;
            this.btnBatalPembayaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatalPembayaran.BorderRadius = 0;
            this.btnBatalPembayaran.ButtonText = "Batal Pembelian Menu";
            this.btnBatalPembayaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalPembayaran.DisabledColor = System.Drawing.Color.Gray;
            this.btnBatalPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalPembayaran.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBatalPembayaran.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBatalPembayaran.Iconimage")));
            this.btnBatalPembayaran.Iconimage_right = null;
            this.btnBatalPembayaran.Iconimage_right_Selected = null;
            this.btnBatalPembayaran.Iconimage_Selected = null;
            this.btnBatalPembayaran.IconMarginLeft = 0;
            this.btnBatalPembayaran.IconMarginRight = 0;
            this.btnBatalPembayaran.IconRightVisible = true;
            this.btnBatalPembayaran.IconRightZoom = 0D;
            this.btnBatalPembayaran.IconVisible = true;
            this.btnBatalPembayaran.IconZoom = 90D;
            this.btnBatalPembayaran.IsTab = false;
            this.btnBatalPembayaran.Location = new System.Drawing.Point(198, 350);
            this.btnBatalPembayaran.Name = "btnBatalPembayaran";
            this.btnBatalPembayaran.Normalcolor = System.Drawing.Color.Red;
            this.btnBatalPembayaran.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBatalPembayaran.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatalPembayaran.selected = false;
            this.btnBatalPembayaran.Size = new System.Drawing.Size(152, 35);
            this.btnBatalPembayaran.TabIndex = 238;
            this.btnBatalPembayaran.Text = "Batal Pembelian Menu";
            this.btnBatalPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatalPembayaran.Textcolor = System.Drawing.Color.White;
            this.btnBatalPembayaran.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalPembayaran.Click += new System.EventHandler(this.btnBatalPembayaran_Click);
            // 
            // cbDibayar
            // 
            this.cbDibayar.AutoSize = true;
            this.cbDibayar.ForeColor = System.Drawing.Color.Black;
            this.cbDibayar.Location = new System.Drawing.Point(35, 506);
            this.cbDibayar.Name = "cbDibayar";
            this.cbDibayar.Size = new System.Drawing.Size(62, 17);
            this.cbDibayar.TabIndex = 239;
            this.cbDibayar.Text = "Dibayar";
            this.cbDibayar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(422, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 240;
            this.label2.Text = "Daftar Transaksi Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(423, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 241;
            this.label1.Text = "Daftar Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(423, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 242;
            this.label3.Text = "Daftar Detail Pembelian";
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.AutoSize = true;
            this.tbTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHarga.ForeColor = System.Drawing.Color.Red;
            this.tbTotalHarga.Location = new System.Drawing.Point(62, 465);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(17, 18);
            this.tbTotalHarga.TabIndex = 244;
            this.tbTotalHarga.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 243;
            this.label4.Text = "Rp.";
            // 
            // FormTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1072, 749);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDibayar);
            this.Controls.Add(this.btnBatalPembayaran);
            this.Controls.Add(this.tbMenu);
            this.Controls.Add(this.btnDetailPembelian);
            this.Controls.Add(this.tbDetailPembelian);
            this.Controls.Add(this.btnTerbayar);
            this.Controls.Add(this.btnSearchTrsKamar);
            this.Controls.Add(this.tbSearchTrsKamar);
            this.Controls.Add(this.dsTrsKamar);
            this.Controls.Add(this.tbKamar);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.btnHapusSemuaMenu);
            this.Controls.Add(this.btnEditMenu);
            this.Controls.Add(this.btnHapusMenu);
            this.Controls.Add(this.btnSearchMenu);
            this.Controls.Add(this.tbSearchMenu);
            this.Controls.Add(this.dsDetailPembelian);
            this.Controls.Add(this.btnTambahMenu);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dsMenu);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormTransaksiPembelian";
            this.Text = "Transaksi Pembelian";
            this.Load += new System.EventHandler(this.FormTransaksiPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sI_HotelDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetailPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTrsKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrsKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomDataGrid dsMenu;
        private ns1.BunifuMaterialTextbox tbJumlah;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuFlatButton btnTambahMenu;
        private ns1.BunifuCustomDataGrid dsDetailPembelian;
        private FontAwesome.Sharp.IconPictureBox btnSearchMenu;
        private ns1.BunifuMaterialTextbox tbSearchMenu;
        private ns1.BunifuFlatButton btnHapusMenu;
        private ns1.BunifuFlatButton btnEditMenu;
        private ns1.BunifuFlatButton btnHapusSemuaMenu;
        private ns1.BunifuMaterialTextbox tbCustomer;
        private ns1.BunifuMaterialTextbox tbKamar;
        private FontAwesome.Sharp.IconPictureBox btnSearchTrsKamar;
        private ns1.BunifuMaterialTextbox tbSearchTrsKamar;
        private ns1.BunifuCustomDataGrid dsTrsKamar;
        private SI_HotelDataSet6 sI_HotelDataSet6;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private SI_HotelDataSet6TableAdapters.MenuTableAdapter menuTableAdapter;
        private ns1.BunifuFlatButton btnTerbayar;
        private FontAwesome.Sharp.IconPictureBox btnDetailPembelian;
        private ns1.BunifuMaterialTextbox tbDetailPembelian;
        private ns1.BunifuMaterialTextbox tbMenu;
        private ns1.BunifuFlatButton btnBatalPembayaran;
        private System.Windows.Forms.CheckBox cbDibayar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbTotalHarga;
        private System.Windows.Forms.Label label4;
    }
}