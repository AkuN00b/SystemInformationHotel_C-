
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiKamar));
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tbSearchCustomer = new ns1.BunifuMaterialTextbox();
            this.dsCustomer = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.cbKamar = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.dpCheckIn = new ns1.BunifuDatepicker();
            this.dpCheckOut = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.tbSearchKamar = new ns1.BunifuMaterialTextbox();
            this.dsKamar = new ns1.BunifuCustomDataGrid();
            this.tbCustomer = new ns1.BunifuMaterialTextbox();
            this.tbKamar = new ns1.BunifuMaterialTextbox();
            this.tbSearchTrsKamar = new ns1.BunifuMaterialTextbox();
            this.dsTrsKamar = new ns1.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchTrsKamar = new FontAwesome.Sharp.IconPictureBox();
            this.btnCheckOut = new ns1.BunifuFlatButton();
            this.btnSearchKamar = new FontAwesome.Sharp.IconPictureBox();
            this.btnSearchCustomer = new FontAwesome.Sharp.IconPictureBox();
            this.btnBatal = new ns1.BunifuFlatButton();
            this.btnSimpan = new ns1.BunifuFlatButton();
            this.tbTotalHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrsKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTrsKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).BeginInit();
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
            this.tbSearchCustomer.HintText = "Pilih dan Cari Customer";
            this.tbSearchCustomer.isPassword = false;
            this.tbSearchCustomer.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchCustomer.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchCustomer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchCustomer.LineThickness = 3;
            this.tbSearchCustomer.Location = new System.Drawing.Point(470, 114);
            this.tbSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(181, 27);
            this.tbSearchCustomer.TabIndex = 174;
            this.tbSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchCustomer.OnValueChanged += new System.EventHandler(this.tbSearch_OnValueChanged);
            this.tbSearchCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchCustomer_KeyPress);
            // 
            // dsCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCustomer.DoubleBuffered = true;
            this.dsCustomer.EnableHeadersVisualStyles = false;
            this.dsCustomer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dsCustomer.Location = new System.Drawing.Point(430, 149);
            this.dsCustomer.Name = "dsCustomer";
            this.dsCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsCustomer.Size = new System.Drawing.Size(282, 176);
            this.dsCustomer.TabIndex = 169;
            this.dsCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsCustomer_CellClick);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(31, 189);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(130, 20);
            this.bunifuCustomLabel3.TabIndex = 168;
            this.bunifuCustomLabel3.Text = "Tanggal Masuk";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(31, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(94, 20);
            this.bunifuCustomLabel2.TabIndex = 167;
            this.bunifuCustomLabel2.Text = "Pelanggan";
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
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 121);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 20);
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
            this.dpCheckIn.onValueChanged += new System.EventHandler(this.dpCheckIn_onValueChanged);
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
            this.dpCheckOut.onValueChanged += new System.EventHandler(this.dpCheckOut_onValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(31, 266);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(129, 20);
            this.bunifuCustomLabel5.TabIndex = 184;
            this.bunifuCustomLabel5.Text = "Tanggal Keluar";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 347);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(103, 20);
            this.bunifuCustomLabel4.TabIndex = 186;
            this.bunifuCustomLabel4.Text = "Total Harga";
            // 
            // tbSearchKamar
            // 
            this.tbSearchKamar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchKamar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchKamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchKamar.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearchKamar.HintText = "Pilih dan Cari Kamar";
            this.tbSearchKamar.isPassword = false;
            this.tbSearchKamar.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearchKamar.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearchKamar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearchKamar.LineThickness = 3;
            this.tbSearchKamar.Location = new System.Drawing.Point(786, 114);
            this.tbSearchKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchKamar.Name = "tbSearchKamar";
            this.tbSearchKamar.Size = new System.Drawing.Size(159, 27);
            this.tbSearchKamar.TabIndex = 189;
            this.tbSearchKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchKamar.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.tbSearchKamar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchKamar_KeyPress);
            // 
            // dsKamar
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsKamar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dsKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsKamar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsKamar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsKamar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dsKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKamar.DoubleBuffered = true;
            this.dsKamar.EnableHeadersVisualStyles = false;
            this.dsKamar.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.dsKamar.HeaderForeColor = System.Drawing.Color.White;
            this.dsKamar.Location = new System.Drawing.Point(727, 148);
            this.dsKamar.Name = "dsKamar";
            this.dsKamar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsKamar.Size = new System.Drawing.Size(282, 176);
            this.dsKamar.TabIndex = 188;
            this.dsKamar.CellBorderStyleChanged += new System.EventHandler(this.dsKamar_CellBorderStyleChanged);
            this.dsKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsKamar_CellClick);
            this.dsKamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
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
            this.tbCustomer.Location = new System.Drawing.Point(35, 80);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(315, 27);
            this.tbCustomer.TabIndex = 191;
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
            this.tbKamar.Location = new System.Drawing.Point(35, 148);
            this.tbKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbKamar.Name = "tbKamar";
            this.tbKamar.Size = new System.Drawing.Size(315, 27);
            this.tbKamar.TabIndex = 150;
            this.tbKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.tbSearchTrsKamar.Location = new System.Drawing.Point(745, 372);
            this.tbSearchTrsKamar.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTrsKamar.Name = "tbSearchTrsKamar";
            this.tbSearchTrsKamar.Size = new System.Drawing.Size(236, 27);
            this.tbSearchTrsKamar.TabIndex = 225;
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
            this.dsTrsKamar.Location = new System.Drawing.Point(416, 406);
            this.dsTrsKamar.Name = "dsTrsKamar";
            this.dsTrsKamar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsTrsKamar.Size = new System.Drawing.Size(617, 176);
            this.dsTrsKamar.TabIndex = 224;
            this.dsTrsKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTrsKamar_CellClick);
            this.dsTrsKamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTrsKamar_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 228;
            this.label1.Text = "Rp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(426, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 229;
            this.label2.Text = "Daftar Customer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(724, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 231;
            this.label4.Text = "Daftar Kamar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(412, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 19);
            this.label5.TabIndex = 232;
            this.label5.Text = "Daftar Transaksi Kamar";
            // 
            // btnSearchTrsKamar
            // 
            this.btnSearchTrsKamar.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTrsKamar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchTrsKamar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchTrsKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchTrsKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchTrsKamar.Location = new System.Drawing.Point(988, 367);
            this.btnSearchTrsKamar.Name = "btnSearchTrsKamar";
            this.btnSearchTrsKamar.Size = new System.Drawing.Size(32, 32);
            this.btnSearchTrsKamar.TabIndex = 226;
            this.btnSearchTrsKamar.TabStop = false;
            this.btnSearchTrsKamar.Click += new System.EventHandler(this.btnSearchTrsKamar_Click);
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
            this.btnCheckOut.Location = new System.Drawing.Point(35, 478);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCheckOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckOut.selected = false;
            this.btnCheckOut.Size = new System.Drawing.Size(315, 35);
            this.btnCheckOut.TabIndex = 223;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Textcolor = System.Drawing.Color.White;
            this.btnCheckOut.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnSearchKamar
            // 
            this.btnSearchKamar.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchKamar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchKamar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchKamar.Location = new System.Drawing.Point(963, 109);
            this.btnSearchKamar.Name = "btnSearchKamar";
            this.btnSearchKamar.Size = new System.Drawing.Size(32, 32);
            this.btnSearchKamar.TabIndex = 190;
            this.btnSearchKamar.TabStop = false;
            this.btnSearchKamar.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCustomer.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearchCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCustomer.Location = new System.Drawing.Point(667, 114);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(32, 32);
            this.btnSearchCustomer.TabIndex = 175;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(221, 428);
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
            // tbTotalHarga
            // 
            this.tbTotalHarga.AutoSize = true;
            this.tbTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHarga.ForeColor = System.Drawing.Color.Red;
            this.tbTotalHarga.Location = new System.Drawing.Point(62, 382);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(17, 18);
            this.tbTotalHarga.TabIndex = 233;
            this.tbTotalHarga.Text = "0";
            this.tbTotalHarga.TextChanged += new System.EventHandler(this.tbTotalHarga_TextChanged_1);
            this.tbTotalHarga.Click += new System.EventHandler(this.tbTotalHarga_Click);
            this.tbTotalHarga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbTotalHarga_MouseClick);
            // 
            // FormTransaksiKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchTrsKamar);
            this.Controls.Add(this.tbSearchTrsKamar);
            this.Controls.Add(this.dsTrsKamar);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.tbKamar);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.btnSearchKamar);
            this.Controls.Add(this.tbSearchKamar);
            this.Controls.Add(this.dsKamar);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dpCheckOut);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dpCheckIn);
            this.Controls.Add(this.cbKamar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.tbSearchCustomer);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dsCustomer);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormTransaksiKamar";
            this.Text = "Transaksi Kamar";
            this.Load += new System.EventHandler(this.FormTransaksiKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrsKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTrsKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCustomer;
        private FontAwesome.Sharp.IconPictureBox btnSearchCustomer;
        private ns1.BunifuMaterialTextbox tbSearchCustomer;
        private ns1.BunifuFlatButton btnBatal;
        private ns1.BunifuFlatButton btnSimpan;
        private ns1.BunifuCustomDataGrid dsCustomer;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cbKamar;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDatepicker dpCheckIn;
        private ns1.BunifuDatepicker dpCheckOut;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private FontAwesome.Sharp.IconPictureBox btnSearchKamar;
        private ns1.BunifuMaterialTextbox tbSearchKamar;
        private ns1.BunifuCustomDataGrid dsKamar;
        private ns1.BunifuMaterialTextbox tbCustomer;
        private ns1.BunifuMaterialTextbox tbKamar;
        private ns1.BunifuFlatButton btnCheckOut;
        private FontAwesome.Sharp.IconPictureBox btnSearchTrsKamar;
        private ns1.BunifuMaterialTextbox tbSearchTrsKamar;
        private ns1.BunifuCustomDataGrid dsTrsKamar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbTotalHarga;
    }
}