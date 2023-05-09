namespace ConejoHelper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tTextToEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tEncrypted = new System.Windows.Forms.TextBox();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tTextToDecrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tDecryptedText = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to encrypt:";
            // 
            // tTextToEncrypt
            // 
            this.tTextToEncrypt.Location = new System.Drawing.Point(151, 24);
            this.tTextToEncrypt.Name = "tTextToEncrypt";
            this.tTextToEncrypt.Size = new System.Drawing.Size(630, 20);
            this.tTextToEncrypt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted text:";
            // 
            // tEncrypted
            // 
            this.tEncrypted.Location = new System.Drawing.Point(151, 71);
            this.tEncrypted.Name = "tEncrypted";
            this.tEncrypted.Size = new System.Drawing.Size(630, 20);
            this.tEncrypted.TabIndex = 3;
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(659, 119);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(121, 21);
            this.bEncrypt.TabIndex = 4;
            this.bEncrypt.Text = "&Encrypt";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text to decrypt:";
            // 
            // tTextToDecrypt
            // 
            this.tTextToDecrypt.Location = new System.Drawing.Point(151, 173);
            this.tTextToDecrypt.Name = "tTextToDecrypt";
            this.tTextToDecrypt.Size = new System.Drawing.Size(630, 20);
            this.tTextToDecrypt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Decrypted text:";
            // 
            // tDecryptedText
            // 
            this.tDecryptedText.Location = new System.Drawing.Point(151, 220);
            this.tDecryptedText.Name = "tDecryptedText";
            this.tDecryptedText.Size = new System.Drawing.Size(630, 20);
            this.tDecryptedText.TabIndex = 8;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(441, 280);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(121, 21);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "&Clear all";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(659, 280);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(121, 21);
            this.bDecrypt.TabIndex = 10;
            this.bDecrypt.Text = "&Decrypt";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDecrypt);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tDecryptedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tTextToDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.tEncrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tTextToEncrypt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tTextToEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tEncrypted;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTextToDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tDecryptedText;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bDecrypt;
    }
}

