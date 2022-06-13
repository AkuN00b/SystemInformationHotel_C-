
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.tbEmail = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.tbNama = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.tbPassword = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.dsUser = new ns1.BunifuCustomDataGrid();
            this.btnEdit = new ns1.BunifuFlatButton();
            this.btnBatal = new ns1.BunifuFlatButton();
            this.btnHapus = new ns1.BunifuFlatButton();
            this.btnSimpan = new ns1.BunifuFlatButton();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnSeek = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeek)).BeginInit();
            this.SuspendLayout();
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
            this.tbEmail.Location = new System.Drawing.Point(30, 128);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(315, 27);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 104);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(48, 20);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Email";
            // 
            // tbNama
            // 
            this.tbNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNama.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNama.HintForeColor = System.Drawing.Color.Empty;
            this.tbNama.HintText = "";
            this.tbNama.isPassword = false;
            this.tbNama.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNama.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNama.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNama.LineThickness = 3;
            this.tbNama.Location = new System.Drawing.Point(30, 59);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(315, 27);
            this.tbNama.TabIndex = 10;
            this.tbNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNama.OnValueChanged += new System.EventHandler(this.tbUsername_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 35);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 20);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Nama";
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
            this.tbPassword.Location = new System.Drawing.Point(30, 202);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(276, 27);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 178);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Password";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(30, 291);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(315, 21);
            this.cbRole.TabIndex = 15;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(26, 253);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(42, 20);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Role";
            // 
            // dsUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dsUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsUser.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsUser.DoubleBuffered = true;
            this.dsUser.EnableHeadersVisualStyles = false;
            this.dsUser.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dsUser.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dsUser.Location = new System.Drawing.Point(425, 128);
            this.dsUser.Name = "dsUser";
            this.dsUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsUser.Size = new System.Drawing.Size(617, 496);
            this.dsUser.TabIndex = 17;
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
            this.btnEdit.Location = new System.Drawing.Point(216, 339);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(129, 35);
            this.btnEdit.TabIndex = 89;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.editbtn_Click);
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
            this.btnBatal.Location = new System.Drawing.Point(216, 384);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnBatal.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 91;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.Textcolor = System.Drawing.Color.White;
            this.btnBatal.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Click += new System.EventHandler(this.batalbtn_Click);
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
            this.btnHapus.Location = new System.Drawing.Point(31, 384);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.Red;
            this.btnHapus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(129, 35);
            this.btnHapus.TabIndex = 90;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Textcolor = System.Drawing.Color.White;
            this.btnHapus.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Click += new System.EventHandler(this.hapusbtn_Click);
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
            this.btnSimpan.Location = new System.Drawing.Point(31, 339);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 88;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Click += new System.EventHandler(this.savebtn_Click);
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
            this.tbSearch.Location = new System.Drawing.Point(653, 94);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(315, 27);
            this.tbSearch.TabIndex = 92;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(984, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 93;
            this.btnSearch.TabStop = false;
            // 
            // btnSeek
            // 
            this.btnSeek.BackColor = System.Drawing.Color.Transparent;
            this.btnSeek.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSeek.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnSeek.IconColor = System.Drawing.Color.MediumBlue;
            this.btnSeek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeek.Location = new System.Drawing.Point(313, 202);
            this.btnSeek.Name = "btnSeek";
            this.btnSeek.Size = new System.Drawing.Size(32, 32);
            this.btnSeek.TabIndex = 94;
            this.btnSeek.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.btnSeek);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dsUser);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "FormUser";
            this.Text = "Master User";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox tbEmail;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMaterialTextbox tbNama;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMaterialTextbox tbPassword;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbRole;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomDataGrid dsUser;
        private ns1.BunifuFlatButton btnEdit;
        private ns1.BunifuFlatButton btnBatal;
        private ns1.BunifuFlatButton btnHapus;
        private ns1.BunifuFlatButton btnSimpan;
        private ns1.BunifuMaterialTextbox tbSearch;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private FontAwesome.Sharp.IconPictureBox btnSeek;
    }
}