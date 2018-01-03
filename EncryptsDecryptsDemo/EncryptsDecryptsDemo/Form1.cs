using EncryptDecryptClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptsDecryptsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            txt_Salt.Text = EncryptDecrypt.CreateSalt(4);

            txt_Encrypted.Text = EncryptDecrypt.Do_Encrypt(txt_UserInput.Text, txt_Salt.Text);

        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
           txt_Decrypted.Text= EncryptDecrypt.Do_Decrypt(txt_Encrypted.Text, txt_Salt.Text);
        }
    }

}

