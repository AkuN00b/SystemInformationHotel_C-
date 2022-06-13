
namespace ProjectAkhir_Kel02
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.tbEmail = new ns1.BunifuMaterialTextbox();
            this.tbPassword = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new ns1.BunifuThinButton2();
            this.btnLogin = new ns1.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnExit = new ns1.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(-2, -1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(341, 36);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "System Information Hotel";
            this.bunifuCustomLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel1_MouseDown);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(236, 53);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 20);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Email";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 3;
            this.tbEmail.Location = new System.Drawing.Point(240, 77);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(288, 35);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmail.OnValueChanged += new System.EventHandler(this.tbUsername_OnValueChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = false;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPassword.LineThickness = 3;
            this.tbPassword.Location = new System.Drawing.Point(240, 154);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(288, 35);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.OnValueChanged += new System.EventHandler(this.tbPassword_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(236, 130);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Password";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(240, 215);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 9;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(266, 217);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(49, 16);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Visible";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(-3, 281);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(28, 13);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "v1.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 10);
            this.panel2.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Chartreuse;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.Chartreuse;
            this.btnClear.IdleLineColor = System.Drawing.Color.Chartreuse;
            this.btnClear.Location = new System.Drawing.Point(357, 246);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 32);
            this.btnClear.TabIndex = 14;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(357, 209);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 32);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectAkhir_Kel02.Properties.Resources.hotel_png_21014;
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 169);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(564, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(28, 28);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 20;
            this.btnExit.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 20;
            this.btnExit.IdleFillColor = System.Drawing.Color.White;
            this.btnExit.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.btnExit.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(240, 246);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 32);
            this.btnExit.TabIndex = 96;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(604, 309);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.iconButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIHotel";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SIHotel_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMaterialTextbox tbEmail;
        private ns1.BunifuMaterialTextbox tbPassword;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        private ns1.BunifuThinButton2 btnLogin;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuThinButton2 btnClear;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuThinButton2 btnExit;
    }
}