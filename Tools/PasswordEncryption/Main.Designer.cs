namespace PasswordEncryption
{
    partial class Main
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdnCustom = new System.Windows.Forms.RadioButton();
            this.rdnMD5 = new System.Windows.Forms.RadioButton();
            this.rdnPlaintextPassword = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(17, 19);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(669, 54);
            this.txtConnectionString.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConnectionString);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection string";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(477, 265);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 31);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(560, 265);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 31);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdnCustom);
            this.groupBox2.Controls.Add(this.rdnMD5);
            this.groupBox2.Controls.Add(this.rdnPlaintextPassword);
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypt/Derypt types";
            // 
            // rdnCustom
            // 
            this.rdnCustom.AutoSize = true;
            this.rdnCustom.Location = new System.Drawing.Point(241, 35);
            this.rdnCustom.Name = "rdnCustom";
            this.rdnCustom.Size = new System.Drawing.Size(60, 17);
            this.rdnCustom.TabIndex = 2;
            this.rdnCustom.TabStop = true;
            this.rdnCustom.Text = "Custom";
            this.rdnCustom.UseVisualStyleBackColor = true;
            this.rdnCustom.CheckedChanged += new System.EventHandler(this.rdnCustom_CheckedChanged);
            // 
            // rdnMD5
            // 
            this.rdnMD5.AutoSize = true;
            this.rdnMD5.Location = new System.Drawing.Point(173, 35);
            this.rdnMD5.Name = "rdnMD5";
            this.rdnMD5.Size = new System.Drawing.Size(48, 17);
            this.rdnMD5.TabIndex = 1;
            this.rdnMD5.TabStop = true;
            this.rdnMD5.Text = "MD5";
            this.rdnMD5.UseVisualStyleBackColor = true;
            this.rdnMD5.CheckedChanged += new System.EventHandler(this.rdnMD5_CheckedChanged);
            // 
            // rdnPlaintextPassword
            // 
            this.rdnPlaintextPassword.AutoSize = true;
            this.rdnPlaintextPassword.Location = new System.Drawing.Point(40, 35);
            this.rdnPlaintextPassword.Name = "rdnPlaintextPassword";
            this.rdnPlaintextPassword.Size = new System.Drawing.Size(114, 17);
            this.rdnPlaintextPassword.TabIndex = 0;
            this.rdnPlaintextPassword.TabStop = true;
            this.rdnPlaintextPassword.Text = "Plaintext Password";
            this.rdnPlaintextPassword.UseVisualStyleBackColor = true;
            this.rdnPlaintextPassword.CheckedChanged += new System.EventHandler(this.rdnPlaintextPassword_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(641, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogs);
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 77);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(17, 20);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(669, 44);
            this.txtLogs.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 308);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Password Encrypt/Derypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdnMD5;
        private System.Windows.Forms.RadioButton rdnPlaintextPassword;
        private System.Windows.Forms.RadioButton rdnCustom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLogs;
    }
}

