using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConejoEncryptDecrypt;

namespace ConejoHelper
{
    public partial class Form1 : Form
    {
        string Password = "SysOjenoc78432643264873624724578";
        public Form1()
        {
            InitializeComponent();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            this.tDecryptedText.Text = "";
            this.tEncrypted.Text = "";
            this.tTextToEncrypt.Text = "";
            this.tTextToDecrypt.Text = "";
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Encrypt.Password = Password;
                tEncrypted.Text = Encrypt.EncryptionText(tTextToEncrypt.Text);
            }
            catch (Exception ex)
            {

                ErrorManage(ex,"Encrypt");
            }
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Decrypt.Password = Password;
                tDecryptedText.Text = Decrypt.DecryptText(tTextToDecrypt.Text);
            }
            catch (Exception ex)
            {

                ErrorManage(ex, "Decrypt");
            }
        }
        void ErrorManage(Exception ex, string from) {
            MessageBox.Show(ex.Message, from,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
