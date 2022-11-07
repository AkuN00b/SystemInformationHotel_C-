
namespace ProjectAkhir_Kel02.Forms
{
    partial class FormProfil
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
            this.rbProfil = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPassword = new System.Windows.Forms.RadioButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbProfil
            // 
            this.rbProfil.AutoSize = true;
            this.rbProfil.ForeColor = System.Drawing.Color.Black;
            this.rbProfil.Location = new System.Drawing.Point(19, 24);
            this.rbProfil.Name = "rbProfil";
            this.rbProfil.Size = new System.Drawing.Size(69, 17);
            this.rbProfil.TabIndex = 190;
            this.rbProfil.TabStop = true;
            this.rbProfil.Text = "Edit Profil";
            this.rbProfil.UseVisualStyleBackColor = true;
            this.rbProfil.CheckedChanged += new System.EventHandler(this.rbProfil_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPassword);
            this.groupBox1.Controls.Add(this.rbProfil);
            this.groupBox1.Location = new System.Drawing.Point(35, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 122);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Opsi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbPassword
            // 
            this.rbPassword.AutoSize = true;
            this.rbPassword.ForeColor = System.Drawing.Color.Black;
            this.rbPassword.Location = new System.Drawing.Point(19, 58);
            this.rbPassword.Name = "rbPassword";
            this.rbPassword.Size = new System.Drawing.Size(92, 17);
            this.rbPassword.TabIndex = 191;
            this.rbPassword.TabStop = true;
            this.rbPassword.Text = "Edit Password";
            this.rbPassword.UseVisualStyleBackColor = true;
            this.rbPassword.CheckedChanged += new System.EventHandler(this.rbPassword_CheckedChanged);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(245, 56);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(834, 644);
            this.panelDesktop.TabIndex = 192;
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProfil";
            this.Text = "FormProfil";
            this.Load += new System.EventHandler(this.FormProfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbProfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPassword;
        private System.Windows.Forms.Panel panelDesktop;
    }
}