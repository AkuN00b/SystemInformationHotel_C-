
namespace ProjectAkhir_Kel02
{
    partial class FormMainMenu
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnMaximized = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnRole = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnKamar = new FontAwesome.Sharp.IconButton();
            this.btnJenisKamar = new FontAwesome.Sharp.IconButton();
            this.btnKelasKamar = new FontAwesome.Sharp.IconButton();
            this.btnFasilitas = new FontAwesome.Sharp.IconButton();
            this.btnDetailFasilitas = new FontAwesome.Sharp.IconButton();
            this.btnMenuMakanan = new FontAwesome.Sharp.IconButton();
            this.btnJenisMakanan = new FontAwesome.Sharp.IconButton();
            this.btnRuangan = new FontAwesome.Sharp.IconButton();
            this.btnTransaksiKamar = new FontAwesome.Sharp.IconButton();
            this.btnTransaksiPembelian = new FontAwesome.Sharp.IconButton();
            this.btnTransaksiRuangan = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.PanelMenu.Controls.Add(this.btnTransaksiRuangan);
            this.PanelMenu.Controls.Add(this.btnTransaksiPembelian);
            this.PanelMenu.Controls.Add(this.btnTransaksiKamar);
            this.PanelMenu.Controls.Add(this.btnRuangan);
            this.PanelMenu.Controls.Add(this.btnJenisMakanan);
            this.PanelMenu.Controls.Add(this.btnMenuMakanan);
            this.PanelMenu.Controls.Add(this.btnDetailFasilitas);
            this.PanelMenu.Controls.Add(this.btnFasilitas);
            this.PanelMenu.Controls.Add(this.btnKelasKamar);
            this.PanelMenu.Controls.Add(this.btnJenisKamar);
            this.PanelMenu.Controls.Add(this.btnKamar);
            this.PanelMenu.Controls.Add(this.btnRole);
            this.PanelMenu.Controls.Add(this.btnUser);
            this.PanelMenu.Controls.Add(this.btnDashboard);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 749);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.btnHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 103);
            this.PanelLogo.TabIndex = 0;
            this.PanelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.btnLogout);
            this.panelTitleBar.Controls.Add(this.btnMaximized);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(860, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(57, 34);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            this.labelTitleChildForm.Click += new System.EventHandler(this.labelTitleChildForm_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(860, 9);
            this.panelShadow.TabIndex = 2;
            this.panelShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShadow_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(860, 660);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnMaximized.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximized.IconColor = System.Drawing.Color.MediumBlue;
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.IconSize = 27;
            this.btnMaximized.Location = new System.Drawing.Point(796, -2);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(27, 29);
            this.btnMaximized.TabIndex = 4;
            this.btnMaximized.TabStop = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.MediumBlue;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 27;
            this.btnMinimize.Location = new System.Drawing.Point(763, -3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 27);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // btnRole
            // 
            this.btnRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.ForeColor = System.Drawing.Color.Black;
            this.btnRole.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnRole.IconColor = System.Drawing.Color.MediumBlue;
            this.btnRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRole.IconSize = 32;
            this.btnRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRole.Location = new System.Drawing.Point(0, 193);
            this.btnRole.Name = "btnRole";
            this.btnRole.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRole.Size = new System.Drawing.Size(220, 45);
            this.btnRole.TabIndex = 4;
            this.btnRole.Text = "Role";
            this.btnRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click_1);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUser.IconColor = System.Drawing.Color.MediumBlue;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 32;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 148);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUser.Size = new System.Drawing.Size(220, 45);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnDashboard.IconColor = System.Drawing.Color.MediumBlue;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 103);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnHome.Image = global::ProjectAkhir_Kel02.Properties.Resources.hotel_building_near_sea_seafront_resort_view_vector_illustration_flat_cartoon_101884_681_removebg_preview;
            this.btnHome.Location = new System.Drawing.Point(-31, -11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(273, 133);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnKamar
            // 
            this.btnKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKamar.ForeColor = System.Drawing.Color.Black;
            this.btnKamar.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKamar.IconSize = 32;
            this.btnKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKamar.Location = new System.Drawing.Point(0, 238);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKamar.Size = new System.Drawing.Size(220, 45);
            this.btnKamar.TabIndex = 5;
            this.btnKamar.Text = "Kamar";
            this.btnKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKamar.UseVisualStyleBackColor = true;
            this.btnKamar.Click += new System.EventHandler(this.btnKamar_Click);
            // 
            // btnJenisKamar
            // 
            this.btnJenisKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJenisKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJenisKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenisKamar.ForeColor = System.Drawing.Color.Black;
            this.btnJenisKamar.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnJenisKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnJenisKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJenisKamar.IconSize = 32;
            this.btnJenisKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJenisKamar.Location = new System.Drawing.Point(0, 283);
            this.btnJenisKamar.Name = "btnJenisKamar";
            this.btnJenisKamar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnJenisKamar.Size = new System.Drawing.Size(220, 45);
            this.btnJenisKamar.TabIndex = 6;
            this.btnJenisKamar.Text = "Jenis Kamar";
            this.btnJenisKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJenisKamar.UseVisualStyleBackColor = true;
            this.btnJenisKamar.Click += new System.EventHandler(this.btnJenisKamar_Click);
            // 
            // btnKelasKamar
            // 
            this.btnKelasKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKelasKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelasKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelasKamar.ForeColor = System.Drawing.Color.Black;
            this.btnKelasKamar.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnKelasKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnKelasKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKelasKamar.IconSize = 32;
            this.btnKelasKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelasKamar.Location = new System.Drawing.Point(0, 328);
            this.btnKelasKamar.Name = "btnKelasKamar";
            this.btnKelasKamar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKelasKamar.Size = new System.Drawing.Size(220, 45);
            this.btnKelasKamar.TabIndex = 7;
            this.btnKelasKamar.Text = "Kelas Kamar";
            this.btnKelasKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKelasKamar.UseVisualStyleBackColor = true;
            this.btnKelasKamar.Click += new System.EventHandler(this.btnKelasKamar_Click);
            // 
            // btnFasilitas
            // 
            this.btnFasilitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFasilitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFasilitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFasilitas.ForeColor = System.Drawing.Color.Black;
            this.btnFasilitas.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnFasilitas.IconColor = System.Drawing.Color.MediumBlue;
            this.btnFasilitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFasilitas.IconSize = 32;
            this.btnFasilitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFasilitas.Location = new System.Drawing.Point(0, 373);
            this.btnFasilitas.Name = "btnFasilitas";
            this.btnFasilitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFasilitas.Size = new System.Drawing.Size(220, 45);
            this.btnFasilitas.TabIndex = 8;
            this.btnFasilitas.Text = "Fasilitas";
            this.btnFasilitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFasilitas.UseVisualStyleBackColor = true;
            this.btnFasilitas.Click += new System.EventHandler(this.btnFasilitas_Click);
            // 
            // btnDetailFasilitas
            // 
            this.btnDetailFasilitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetailFasilitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailFasilitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailFasilitas.ForeColor = System.Drawing.Color.Black;
            this.btnDetailFasilitas.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnDetailFasilitas.IconColor = System.Drawing.Color.MediumBlue;
            this.btnDetailFasilitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetailFasilitas.IconSize = 32;
            this.btnDetailFasilitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailFasilitas.Location = new System.Drawing.Point(0, 418);
            this.btnDetailFasilitas.Name = "btnDetailFasilitas";
            this.btnDetailFasilitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDetailFasilitas.Size = new System.Drawing.Size(220, 45);
            this.btnDetailFasilitas.TabIndex = 9;
            this.btnDetailFasilitas.Text = "Detail Fasilitas";
            this.btnDetailFasilitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailFasilitas.UseVisualStyleBackColor = true;
            this.btnDetailFasilitas.Click += new System.EventHandler(this.btnDetailFasilitas_Click);
            // 
            // btnMenuMakanan
            // 
            this.btnMenuMakanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMakanan.ForeColor = System.Drawing.Color.Black;
            this.btnMenuMakanan.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnMenuMakanan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnMenuMakanan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuMakanan.IconSize = 32;
            this.btnMenuMakanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMakanan.Location = new System.Drawing.Point(0, 463);
            this.btnMenuMakanan.Name = "btnMenuMakanan";
            this.btnMenuMakanan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenuMakanan.Size = new System.Drawing.Size(220, 45);
            this.btnMenuMakanan.TabIndex = 10;
            this.btnMenuMakanan.Text = "Menu Makanan";
            this.btnMenuMakanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuMakanan.UseVisualStyleBackColor = true;
            this.btnMenuMakanan.Click += new System.EventHandler(this.btnMenuMakanan_Click);
            // 
            // btnJenisMakanan
            // 
            this.btnJenisMakanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJenisMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJenisMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenisMakanan.ForeColor = System.Drawing.Color.Black;
            this.btnJenisMakanan.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnJenisMakanan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnJenisMakanan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJenisMakanan.IconSize = 32;
            this.btnJenisMakanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJenisMakanan.Location = new System.Drawing.Point(0, 508);
            this.btnJenisMakanan.Name = "btnJenisMakanan";
            this.btnJenisMakanan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnJenisMakanan.Size = new System.Drawing.Size(220, 45);
            this.btnJenisMakanan.TabIndex = 11;
            this.btnJenisMakanan.Text = "Jenis Makanan";
            this.btnJenisMakanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJenisMakanan.UseVisualStyleBackColor = true;
            this.btnJenisMakanan.Click += new System.EventHandler(this.btnJenisMakanan_Click);
            // 
            // btnRuangan
            // 
            this.btnRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuangan.ForeColor = System.Drawing.Color.Black;
            this.btnRuangan.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnRuangan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnRuangan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRuangan.IconSize = 32;
            this.btnRuangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuangan.Location = new System.Drawing.Point(0, 553);
            this.btnRuangan.Name = "btnRuangan";
            this.btnRuangan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRuangan.Size = new System.Drawing.Size(220, 45);
            this.btnRuangan.TabIndex = 12;
            this.btnRuangan.Text = "Ruangan";
            this.btnRuangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuangan.UseVisualStyleBackColor = true;
            this.btnRuangan.Click += new System.EventHandler(this.btnRuangan_Click);
            // 
            // btnTransaksiKamar
            // 
            this.btnTransaksiKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksiKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksiKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksiKamar.ForeColor = System.Drawing.Color.Black;
            this.btnTransaksiKamar.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnTransaksiKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnTransaksiKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaksiKamar.IconSize = 32;
            this.btnTransaksiKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksiKamar.Location = new System.Drawing.Point(0, 598);
            this.btnTransaksiKamar.Name = "btnTransaksiKamar";
            this.btnTransaksiKamar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransaksiKamar.Size = new System.Drawing.Size(220, 45);
            this.btnTransaksiKamar.TabIndex = 13;
            this.btnTransaksiKamar.Text = "Transaksi Kamar";
            this.btnTransaksiKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksiKamar.UseVisualStyleBackColor = true;
            this.btnTransaksiKamar.Click += new System.EventHandler(this.btnTransaksiKamar_Click);
            // 
            // btnTransaksiPembelian
            // 
            this.btnTransaksiPembelian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksiPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksiPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksiPembelian.ForeColor = System.Drawing.Color.Black;
            this.btnTransaksiPembelian.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnTransaksiPembelian.IconColor = System.Drawing.Color.MediumBlue;
            this.btnTransaksiPembelian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaksiPembelian.IconSize = 32;
            this.btnTransaksiPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksiPembelian.Location = new System.Drawing.Point(0, 643);
            this.btnTransaksiPembelian.Name = "btnTransaksiPembelian";
            this.btnTransaksiPembelian.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransaksiPembelian.Size = new System.Drawing.Size(220, 45);
            this.btnTransaksiPembelian.TabIndex = 14;
            this.btnTransaksiPembelian.Text = "Transaksi Pembelian";
            this.btnTransaksiPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksiPembelian.UseVisualStyleBackColor = true;
            this.btnTransaksiPembelian.Click += new System.EventHandler(this.btnTransaksiPembelian_Click);
            // 
            // btnTransaksiRuangan
            // 
            this.btnTransaksiRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksiRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksiRuangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksiRuangan.ForeColor = System.Drawing.Color.Black;
            this.btnTransaksiRuangan.IconChar = FontAwesome.Sharp.IconChar.GrinTongue;
            this.btnTransaksiRuangan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnTransaksiRuangan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaksiRuangan.IconSize = 32;
            this.btnTransaksiRuangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksiRuangan.Location = new System.Drawing.Point(0, 688);
            this.btnTransaksiRuangan.Name = "btnTransaksiRuangan";
            this.btnTransaksiRuangan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransaksiRuangan.Size = new System.Drawing.Size(220, 45);
            this.btnTransaksiRuangan.TabIndex = 15;
            this.btnTransaksiRuangan.Text = "Transaksi Ruangan";
            this.btnTransaksiRuangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksiRuangan.UseVisualStyleBackColor = true;
            this.btnTransaksiRuangan.Click += new System.EventHandler(this.btnTransaksiRuangan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnLogout.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.MediumBlue;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(816, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(32, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1080, 749);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnRole;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnMaximized;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconButton btnJenisMakanan;
        private FontAwesome.Sharp.IconButton btnMenuMakanan;
        private FontAwesome.Sharp.IconButton btnDetailFasilitas;
        private FontAwesome.Sharp.IconButton btnFasilitas;
        private FontAwesome.Sharp.IconButton btnKelasKamar;
        private FontAwesome.Sharp.IconButton btnJenisKamar;
        private FontAwesome.Sharp.IconButton btnKamar;
        private FontAwesome.Sharp.IconButton btnTransaksiRuangan;
        private FontAwesome.Sharp.IconButton btnTransaksiPembelian;
        private FontAwesome.Sharp.IconButton btnTransaksiKamar;
        private FontAwesome.Sharp.IconButton btnRuangan;
        private FontAwesome.Sharp.IconPictureBox btnLogout;
    }
}

