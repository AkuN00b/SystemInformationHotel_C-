
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormEditPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPassword));
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.tbPasswordBaruu = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.tbPasswordBaru = new ns1.BunifuMaterialTextbox();
            this.tbPasswordLama = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.btnEditPassword = new ns1.BunifuFlatButton();
            this.btnBatalPassword = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(60, 234);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(49, 16);
            this.bunifuCustomLabel6.TabIndex = 199;
            this.bunifuCustomLabel6.Text = "Visible";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(34, 232);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 198;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // tbPasswordBaruu
            // 
            this.tbPasswordBaruu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordBaruu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPasswordBaruu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordBaruu.HintForeColor = System.Drawing.Color.Empty;
            this.tbPasswordBaruu.HintText = "";
            this.tbPasswordBaruu.isPassword = false;
            this.tbPasswordBaruu.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPasswordBaruu.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPasswordBaruu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPasswordBaruu.LineThickness = 3;
            this.tbPasswordBaruu.Location = new System.Drawing.Point(35, 173);
            this.tbPasswordBaruu.Margin = new System.Windows.Forms.Padding(4);
            this.tbPasswordBaruu.Name = "tbPasswordBaruu";
            this.tbPasswordBaruu.Size = new System.Drawing.Size(315, 27);
            this.tbPasswordBaruu.TabIndex = 197;
            this.tbPasswordBaruu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPasswordBaruu.OnValueChanged += new System.EventHandler(this.tbPasswordBaruu_OnValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(31, 147);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(220, 20);
            this.bunifuCustomLabel5.TabIndex = 196;
            this.bunifuCustomLabel5.Text = "Password Baru (Verifikasi)";
            // 
            // tbPasswordBaru
            // 
            this.tbPasswordBaru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordBaru.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPasswordBaru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordBaru.HintForeColor = System.Drawing.Color.Empty;
            this.tbPasswordBaru.HintText = "";
            this.tbPasswordBaru.isPassword = false;
            this.tbPasswordBaru.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPasswordBaru.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPasswordBaru.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPasswordBaru.LineThickness = 3;
            this.tbPasswordBaru.Location = new System.Drawing.Point(36, 101);
            this.tbPasswordBaru.Margin = new System.Windows.Forms.Padding(4);
            this.tbPasswordBaru.Name = "tbPasswordBaru";
            this.tbPasswordBaru.Size = new System.Drawing.Size(315, 27);
            this.tbPasswordBaru.TabIndex = 195;
            this.tbPasswordBaru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPasswordBaru.OnValueChanged += new System.EventHandler(this.tbPasswordBaru_OnValueChanged);
            // 
            // tbPasswordLama
            // 
            this.tbPasswordLama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordLama.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPasswordLama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordLama.HintForeColor = System.Drawing.Color.Empty;
            this.tbPasswordLama.HintText = "";
            this.tbPasswordLama.isPassword = false;
            this.tbPasswordLama.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPasswordLama.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPasswordLama.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPasswordLama.LineThickness = 3;
            this.tbPasswordLama.Location = new System.Drawing.Point(35, 30);
            this.tbPasswordLama.Margin = new System.Windows.Forms.Padding(4);
            this.tbPasswordLama.Name = "tbPasswordLama";
            this.tbPasswordLama.Size = new System.Drawing.Size(315, 27);
            this.tbPasswordLama.TabIndex = 194;
            this.tbPasswordLama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPasswordLama.OnValueChanged += new System.EventHandler(this.tbPasswordLama_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 75);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 20);
            this.bunifuCustomLabel1.TabIndex = 191;
            this.bunifuCustomLabel1.Text = "Password Baru";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 20);
            this.bunifuCustomLabel4.TabIndex = 190;
            this.bunifuCustomLabel4.Text = "Password Lama";
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPassword.BorderRadius = 0;
            this.btnEditPassword.ButtonText = "Edit";
            this.btnEditPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditPassword.Iconimage")));
            this.btnEditPassword.Iconimage_right = null;
            this.btnEditPassword.Iconimage_right_Selected = null;
            this.btnEditPassword.Iconimage_Selected = null;
            this.btnEditPassword.IconMarginLeft = 0;
            this.btnEditPassword.IconMarginRight = 0;
            this.btnEditPassword.IconRightVisible = true;
            this.btnEditPassword.IconRightZoom = 0D;
            this.btnEditPassword.IconVisible = true;
            this.btnEditPassword.IconZoom = 90D;
            this.btnEditPassword.IsTab = false;
            this.btnEditPassword.Location = new System.Drawing.Point(36, 275);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditPassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditPassword.selected = false;
            this.btnEditPassword.Size = new System.Drawing.Size(315, 35);
            this.btnEditPassword.TabIndex = 192;
            this.btnEditPassword.Text = "Edit";
            this.btnEditPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPassword.Textcolor = System.Drawing.Color.White;
            this.btnEditPassword.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // btnBatalPassword
            // 
            this.btnBatalPassword.Activecolor = System.Drawing.Color.DarkViolet;
            this.btnBatalPassword.BackColor = System.Drawing.Color.DarkViolet;
            this.btnBatalPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatalPassword.BorderRadius = 0;
            this.btnBatalPassword.ButtonText = "Batal";
            this.btnBatalPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnBatalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBatalPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBatalPassword.Iconimage")));
            this.btnBatalPassword.Iconimage_right = null;
            this.btnBatalPassword.Iconimage_right_Selected = null;
            this.btnBatalPassword.Iconimage_Selected = null;
            this.btnBatalPassword.IconMarginLeft = 0;
            this.btnBatalPassword.IconMarginRight = 0;
            this.btnBatalPassword.IconRightVisible = true;
            this.btnBatalPassword.IconRightZoom = 0D;
            this.btnBatalPassword.IconVisible = true;
            this.btnBatalPassword.IconZoom = 90D;
            this.btnBatalPassword.IsTab = false;
            this.btnBatalPassword.Location = new System.Drawing.Point(36, 320);
            this.btnBatalPassword.Name = "btnBatalPassword";
            this.btnBatalPassword.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnBatalPassword.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btnBatalPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatalPassword.selected = false;
            this.btnBatalPassword.Size = new System.Drawing.Size(315, 35);
            this.btnBatalPassword.TabIndex = 193;
            this.btnBatalPassword.Text = "Batal";
            this.btnBatalPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatalPassword.Textcolor = System.Drawing.Color.White;
            this.btnBatalPassword.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalPassword.Click += new System.EventHandler(this.btnBatalPassword_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(135, 20);
            this.bunifuCustomLabel2.TabIndex = 190;
            this.bunifuCustomLabel2.Text = "Password Lama";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 75);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(129, 20);
            this.bunifuCustomLabel3.TabIndex = 191;
            this.bunifuCustomLabel3.Text = "Password Baru";
            // 
            // FormEditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.tbPasswordBaruu);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.tbPasswordBaru);
            this.Controls.Add(this.tbPasswordLama);
            this.Controls.Add(this.btnEditPassword);
            this.Controls.Add(this.btnBatalPassword);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Name = "FormEditPassword";
            this.Text = "FormEditPassword";
            this.Load += new System.EventHandler(this.FormEditPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCheckbox bunifuCheckbox1;
        private ns1.BunifuMaterialTextbox tbPasswordBaruu;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMaterialTextbox tbPasswordBaru;
        private ns1.BunifuMaterialTextbox tbPasswordLama;
        private ns1.BunifuFlatButton btnEditPassword;
        private ns1.BunifuFlatButton btnBatalPassword;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
    }
}