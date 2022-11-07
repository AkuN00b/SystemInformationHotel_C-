
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormUserMenu
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
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDetailUser = new System.Windows.Forms.RadioButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.ForeColor = System.Drawing.Color.Black;
            this.rbUser.Location = new System.Drawing.Point(14, 59);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(68, 17);
            this.rbUser.TabIndex = 190;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Edit User";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDetailUser);
            this.groupBox1.Controls.Add(this.rbUser);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 122);
            this.groupBox1.TabIndex = 193;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Opsi";
            // 
            // rbDetailUser
            // 
            this.rbDetailUser.AutoSize = true;
            this.rbDetailUser.ForeColor = System.Drawing.Color.Black;
            this.rbDetailUser.Location = new System.Drawing.Point(14, 23);
            this.rbDetailUser.Name = "rbDetailUser";
            this.rbDetailUser.Size = new System.Drawing.Size(98, 17);
            this.rbDetailUser.TabIndex = 191;
            this.rbDetailUser.TabStop = true;
            this.rbDetailUser.Text = "Edit Detail User";
            this.rbDetailUser.UseVisualStyleBackColor = true;
            this.rbDetailUser.CheckedChanged += new System.EventHandler(this.rbDetailUser_CheckedChanged);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(187, 12);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(890, 686);
            this.panelDesktop.TabIndex = 194;
            // 
            // FormUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormUserMenu";
            this.Text = "Master User";
            this.Load += new System.EventHandler(this.FormUserMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDetailUser;
        private System.Windows.Forms.Panel panelDesktop;
    }
}