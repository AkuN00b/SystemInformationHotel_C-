
namespace ProjectAkhir_Kel02
{
    partial class FormManagerMenu
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnMaximized = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnReportTransaksiRuangan = new FontAwesome.Sharp.IconButton();
            this.btnReportTransaksiMenu = new FontAwesome.Sharp.IconButton();
            this.btnReportTransaksiKamar = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.btnMinimized);
            this.panelTitleBar.Controls.Add(this.btnMaximized);
            this.panelTitleBar.Controls.Add(this.btnLogout);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(860, 80);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimized.IconColor = System.Drawing.Color.MediumBlue;
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 23;
            this.btnMinimized.Location = new System.Drawing.Point(757, -12);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(39, 44);
            this.btnMinimized.TabIndex = 9;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximized.IconColor = System.Drawing.Color.MediumBlue;
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.IconSize = 23;
            this.btnMaximized.Location = new System.Drawing.Point(789, -11);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(39, 44);
            this.btnMaximized.TabIndex = 8;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.MediumBlue;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.Location = new System.Drawing.Point(809, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(39, 44);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(118, 52);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(51, 16);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "label1";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(118, 19);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(51, 16);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "label1";
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.labelRole);
            this.PanelLogo.Controls.Add(this.labelUsername);
            this.PanelLogo.Controls.Add(this.btnHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 103);
            this.PanelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnHome.Image = global::ProjectAkhir_Kel02.Properties.Resources.hotel_building_near_sea_seafront_resort_view_vector_illustration_flat_cartoon_101884_681_removebg_preview;
            this.btnHome.Location = new System.Drawing.Point(-81, -11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(273, 133);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.PanelMenu.Controls.Add(this.btnReportTransaksiRuangan);
            this.PanelMenu.Controls.Add(this.btnReportTransaksiMenu);
            this.PanelMenu.Controls.Add(this.btnReportTransaksiKamar);
            this.PanelMenu.Controls.Add(this.btnDashboard);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 749);
            this.PanelMenu.TabIndex = 4;
            // 
            // btnReportTransaksiRuangan
            // 
            this.btnReportTransaksiRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportTransaksiRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportTransaksiRuangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportTransaksiRuangan.ForeColor = System.Drawing.Color.Black;
            this.btnReportTransaksiRuangan.IconChar = FontAwesome.Sharp.IconChar.Simplybuilt;
            this.btnReportTransaksiRuangan.IconColor = System.Drawing.Color.MediumBlue;
            this.btnReportTransaksiRuangan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportTransaksiRuangan.IconSize = 32;
            this.btnReportTransaksiRuangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportTransaksiRuangan.Location = new System.Drawing.Point(0, 238);
            this.btnReportTransaksiRuangan.Name = "btnReportTransaksiRuangan";
            this.btnReportTransaksiRuangan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportTransaksiRuangan.Size = new System.Drawing.Size(220, 45);
            this.btnReportTransaksiRuangan.TabIndex = 5;
            this.btnReportTransaksiRuangan.Text = "Report Transaksi Ruangan";
            this.btnReportTransaksiRuangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportTransaksiRuangan.UseVisualStyleBackColor = true;
            this.btnReportTransaksiRuangan.Click += new System.EventHandler(this.btnReportTransaksiRuangan_Click);
            // 
            // btnReportTransaksiMenu
            // 
            this.btnReportTransaksiMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportTransaksiMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportTransaksiMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportTransaksiMenu.ForeColor = System.Drawing.Color.Black;
            this.btnReportTransaksiMenu.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnReportTransaksiMenu.IconColor = System.Drawing.Color.MediumBlue;
            this.btnReportTransaksiMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportTransaksiMenu.IconSize = 32;
            this.btnReportTransaksiMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportTransaksiMenu.Location = new System.Drawing.Point(0, 193);
            this.btnReportTransaksiMenu.Name = "btnReportTransaksiMenu";
            this.btnReportTransaksiMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportTransaksiMenu.Size = new System.Drawing.Size(220, 45);
            this.btnReportTransaksiMenu.TabIndex = 4;
            this.btnReportTransaksiMenu.Text = "Report Transaksi Menu";
            this.btnReportTransaksiMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportTransaksiMenu.UseVisualStyleBackColor = true;
            this.btnReportTransaksiMenu.Click += new System.EventHandler(this.btnReportTransaksiMenu_Click);
            // 
            // btnReportTransaksiKamar
            // 
            this.btnReportTransaksiKamar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportTransaksiKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportTransaksiKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportTransaksiKamar.ForeColor = System.Drawing.Color.Black;
            this.btnReportTransaksiKamar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnReportTransaksiKamar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnReportTransaksiKamar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportTransaksiKamar.IconSize = 32;
            this.btnReportTransaksiKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportTransaksiKamar.Location = new System.Drawing.Point(0, 148);
            this.btnReportTransaksiKamar.Name = "btnReportTransaksiKamar";
            this.btnReportTransaksiKamar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportTransaksiKamar.Size = new System.Drawing.Size(220, 45);
            this.btnReportTransaksiKamar.TabIndex = 3;
            this.btnReportTransaksiKamar.Text = "Report Transaksi Kamar";
            this.btnReportTransaksiKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportTransaksiKamar.UseVisualStyleBackColor = true;
            this.btnReportTransaksiKamar.Click += new System.EventHandler(this.btnUser_Click);
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(860, 9);
            this.panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(860, 660);
            this.panelDesktop.TabIndex = 7;
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Black;
            this.labelTitleChildForm.Location = new System.Drawing.Point(66, 28);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(56, 20);
            this.labelTitleChildForm.TabIndex = 13;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 42;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 19);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 43);
            this.iconCurrentChildForm.TabIndex = 12;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // FormManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 749);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormManagerMenu";
            this.Text = "FormManagerMenu";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnReportTransaksiRuangan;
        private FontAwesome.Sharp.IconButton btnReportTransaksiMenu;
        private FontAwesome.Sharp.IconButton btnReportTransaksiKamar;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}