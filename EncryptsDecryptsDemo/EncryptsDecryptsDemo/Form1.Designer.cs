namespace EncryptsDecryptsDemo
{
    partial class Form1
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
            this.txt_UserInput = new System.Windows.Forms.TextBox();
            this.txt_Encrypted = new System.Windows.Forms.TextBox();
            this.txt_Decrypted = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txt_Salt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_UserInput
            // 
            this.txt_UserInput.Location = new System.Drawing.Point(60, 44);
            this.txt_UserInput.Name = "txt_UserInput";
            this.txt_UserInput.Size = new System.Drawing.Size(328, 20);
            this.txt_UserInput.TabIndex = 0;
            // 
            // txt_Encrypted
            // 
            this.txt_Encrypted.Location = new System.Drawing.Point(60, 114);
            this.txt_Encrypted.Name = "txt_Encrypted";
            this.txt_Encrypted.Size = new System.Drawing.Size(328, 20);
            this.txt_Encrypted.TabIndex = 1;
            // 
            // txt_Decrypted
            // 
            this.txt_Decrypted.Location = new System.Drawing.Point(60, 156);
            this.txt_Decrypted.Name = "txt_Decrypted";
            this.txt_Decrypted.Size = new System.Drawing.Size(328, 20);
            this.txt_Decrypted.TabIndex = 2;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(446, 69);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 3;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(446, 136);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 4;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txt_Salt
            // 
            this.txt_Salt.Location = new System.Drawing.Point(60, 88);
            this.txt_Salt.Name = "txt_Salt";
            this.txt_Salt.Size = new System.Drawing.Size(149, 20);
            this.txt_Salt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 237);
            this.Controls.Add(this.txt_Salt);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txt_Decrypted);
            this.Controls.Add(this.txt_Encrypted);
            this.Controls.Add(this.txt_UserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserInput;
        private System.Windows.Forms.TextBox txt_Encrypted;
        private System.Windows.Forms.TextBox txt_Decrypted;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txt_Salt;
    }
}

