
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiPembelian));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearchKamar = new ns1.BunifuMaterialTextbox();
            this.dsKamar = new ns1.BunifuCustomDataGrid();
            this.tbTotalHarga = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.cbKamar = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tbSearchCustomer = new ns1.BunifuMaterialTextbox();
            this.dsCustomer = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.btnSearchKamar = new FontAwesome.Sharp.IconPictureBox();
            this.btnSearchCustomer = new FontAwesome.Sharp.IconPictureBox();
            this.btnEdit = new ns1.BunifuFlatButton();
            this.btnBatal = new ns1.BunifuFlatButton();
            this.btnHapus = new ns1.BunifuFlatButton();
            this.btnSimpan = new ns1.BunifuFlatButton();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.dsDetailMenu = new ns1.BunifuCustomDataGrid();
            this.tbJumlah = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.btnTambahMenu = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetailMenu)).BeginInit();
            this.SuspendLayout();
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
            this.tbSearchKamar.Location = new System.Drawing.Point(654, 308);
            this.tbSearchKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchKamar.Name = "tbSearchKamar";
            this.tbSearchKamar.Size = new System.Drawing.Size(315, 27);
            this.tbSearchKamar.TabIndex = 209;
            this.tbSearchKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dsKamar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsKamar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsKamar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKamar.DoubleBuffered = true;
            this.dsKamar.EnableHeadersVisualStyles = false;
            this.dsKamar.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsKamar.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsKamar.Location = new System.Drawing.Point(426, 342);
            this.dsKamar.Name = "dsKamar";
            this.dsKamar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsKamar.Size = new System.Drawing.Size(617, 176);
            this.dsKamar.TabIndex = 208;
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
            this.tbTotalHarga.Location = new System.Drawing.Point(35, 406);
            this.tbTotalHarga.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(315, 27);
            this.tbTotalHarga.TabIndex = 207;
            this.tbTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 382);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(92, 20);
            this.bunifuCustomLabel4.TabIndex = 206;
            this.bunifuCustomLabel4.Text = "Total Harga";
            // 
            // cbKamar
            // 
            this.cbKamar.FormattingEnabled = true;
            this.cbKamar.Location = new System.Drawing.Point(35, 190);
            this.cbKamar.Name = "cbKamar";
            this.cbKamar.Size = new System.Drawing.Size(315, 21);
            this.cbKamar.TabIndex = 202;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 162);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 20);
            this.bunifuCustomLabel1.TabIndex = 201;
            this.bunifuCustomLabel1.Text = "Kamar";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(35, 125);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(315, 21);
            this.cbCustomer.TabIndex = 200;
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
            this.tbSearchCustomer.Location = new System.Drawing.Point(654, 70);
            this.tbSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(315, 27);
            this.tbSearchCustomer.TabIndex = 198;
            this.tbSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dsCustomer
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dsCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCustomer.DoubleBuffered = true;
            this.dsCustomer.EnableHeadersVisualStyles = false;
            this.dsCustomer.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsCustomer.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsCustomer.Location = new System.Drawing.Point(426, 104);
            this.dsCustomer.Name = "dsCustomer";
            this.dsCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsCustomer.Size = new System.Drawing.Size(617, 176);
            this.dsCustomer.TabIndex = 193;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 97);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel2.TabIndex = 191;
            this.bunifuCustomLabel2.Text = "Customer";
            // 
            // btnSearchKamar
            // 
            this.btnSearchKamar.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchKamar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchKamar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchKamar.Location = new System.Drawing.Point(985, 308);
            this.btnSearchKamar.Name = "btnSearchKamar";
            this.btnSearchKamar.Size = new System.Drawing.Size(32, 32);
            this.btnSearchKamar.TabIndex = 210;
            this.btnSearchKamar.TabStop = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCustomer.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCustomer.Location = new System.Drawing.Point(985, 70);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(32, 32);
            this.btnSearchCustomer.TabIndex = 199;
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
            this.btnEdit.Location = new System.Drawing.Point(221, 469);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(129, 35);
            this.btnEdit.TabIndex = 195;
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
            this.btnBatal.Location = new System.Drawing.Point(221, 514);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnBatal.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 197;
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
            this.btnHapus.Location = new System.Drawing.Point(35, 514);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.Red;
            this.btnHapus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(129, 35);
            this.btnHapus.TabIndex = 196;
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
            this.btnSimpan.Location = new System.Drawing.Point(35, 469);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 194;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(35, 259);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(141, 21);
            this.cbMenu.TabIndex = 212;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 231);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 20);
            this.bunifuCustomLabel3.TabIndex = 211;
            this.bunifuCustomLabel3.Text = "Menu";
            // 
            // dsDetailMenu
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsDetailMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dsDetailMenu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsDetailMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsDetailMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsDetailMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dsDetailMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDetailMenu.DoubleBuffered = true;
            this.dsDetailMenu.EnableHeadersVisualStyles = false;
            this.dsDetailMenu.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsDetailMenu.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsDetailMenu.Location = new System.Drawing.Point(426, 561);
            this.dsDetailMenu.Name = "dsDetailMenu";
            this.dsDetailMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsDetailMenu.Size = new System.Drawing.Size(617, 176);
            this.dsDetailMenu.TabIndex = 213;
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
            this.tbJumlah.Location = new System.Drawing.Point(198, 253);
            this.tbJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(152, 27);
            this.tbJumlah.TabIndex = 216;
            this.tbJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(194, 231);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(60, 20);
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
            this.btnTambahMenu.Size = new System.Drawing.Size(315, 35);
            this.btnTambahMenu.TabIndex = 217;
            this.btnTambahMenu.Text = "Tambah Menu";
            this.btnTambahMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambahMenu.Textcolor = System.Drawing.Color.White;
            this.btnTambahMenu.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 749);
            this.Controls.Add(this.btnTambahMenu);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dsDetailMenu);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btnSearchKamar);
            this.Controls.Add(this.tbSearchKamar);
            this.Controls.Add(this.dsKamar);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.bunifuCustomLabel4);
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
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormTransaksiPembelian";
            this.Text = "Transaksi Pembelian";
            ((System.ComponentModel.ISupportInitialize)(this.dsKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetailMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnSearchKamar;
        private ns1.BunifuMaterialTextbox tbSearchKamar;
        private ns1.BunifuCustomDataGrid dsKamar;
        private ns1.BunifuMaterialTextbox tbTotalHarga;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox cbKamar;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbCustomer;
        private FontAwesome.Sharp.IconPictureBox btnSearchCustomer;
        private ns1.BunifuMaterialTextbox tbSearchCustomer;
        private ns1.BunifuFlatButton btnEdit;
        private ns1.BunifuFlatButton btnBatal;
        private ns1.BunifuFlatButton btnHapus;
        private ns1.BunifuFlatButton btnSimpan;
        private ns1.BunifuCustomDataGrid dsCustomer;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cbMenu;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomDataGrid dsDetailMenu;
        private ns1.BunifuMaterialTextbox tbJumlah;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuFlatButton btnTambahMenu;
    }
}