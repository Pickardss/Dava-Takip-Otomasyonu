
namespace DavaTakipOtomasyonu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblTCnoKayit = new System.Windows.Forms.Label();
            this.lblSifreKayit = new System.Windows.Forms.Label();
            this.txtSifreKayit = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.MtxtTCnoKayit = new System.Windows.Forms.MaskedTextBox();
            this.btnKapatma = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTCnoKayit
            // 
            this.lblTCnoKayit.AutoSize = true;
            this.lblTCnoKayit.Location = new System.Drawing.Point(215, 142);
            this.lblTCnoKayit.Name = "lblTCnoKayit";
            this.lblTCnoKayit.Size = new System.Drawing.Size(42, 17);
            this.lblTCnoKayit.TabIndex = 1;
            this.lblTCnoKayit.Text = "TCno";
            // 
            // lblSifreKayit
            // 
            this.lblSifreKayit.AutoSize = true;
            this.lblSifreKayit.Location = new System.Drawing.Point(215, 183);
            this.lblSifreKayit.Name = "lblSifreKayit";
            this.lblSifreKayit.Size = new System.Drawing.Size(37, 17);
            this.lblSifreKayit.TabIndex = 2;
            this.lblSifreKayit.Text = "Şifre";
            // 
            // txtSifreKayit
            // 
            this.txtSifreKayit.Location = new System.Drawing.Point(270, 180);
            this.txtSifreKayit.Name = "txtSifreKayit";
            this.txtSifreKayit.PasswordChar = '*';
            this.txtSifreKayit.Size = new System.Drawing.Size(149, 22);
            this.txtSifreKayit.TabIndex = 4;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.Location = new System.Drawing.Point(308, 225);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(111, 31);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // MtxtTCnoKayit
            // 
            this.MtxtTCnoKayit.Location = new System.Drawing.Point(270, 142);
            this.MtxtTCnoKayit.Mask = "00000000000";
            this.MtxtTCnoKayit.Name = "MtxtTCnoKayit";
            this.MtxtTCnoKayit.Size = new System.Drawing.Size(149, 22);
            this.MtxtTCnoKayit.TabIndex = 7;
            this.MtxtTCnoKayit.ValidatingType = typeof(int);
            // 
            // btnKapatma
            // 
            this.btnKapatma.Image = ((System.Drawing.Image)(resources.GetObject("btnKapatma.Image")));
            this.btnKapatma.Location = new System.Drawing.Point(600, 12);
            this.btnKapatma.Name = "btnKapatma";
            this.btnKapatma.Size = new System.Drawing.Size(90, 79);
            this.btnKapatma.TabIndex = 8;
            this.btnKapatma.UseVisualStyleBackColor = true;
            this.btnKapatma.Click += new System.EventHandler(this.btnKapatma_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReturnBtn.Image")));
            this.ReturnBtn.Location = new System.Drawing.Point(12, 13);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(89, 78);
            this.ReturnBtn.TabIndex = 14;
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(702, 429);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.btnKapatma);
            this.Controls.Add(this.MtxtTCnoKayit);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtSifreKayit);
            this.Controls.Add(this.lblSifreKayit);
            this.Controls.Add(this.lblTCnoKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTCnoKayit;
        private System.Windows.Forms.Label lblSifreKayit;
        private System.Windows.Forms.TextBox txtSifreKayit;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.MaskedTextBox MtxtTCnoKayit;
        private System.Windows.Forms.Button btnKapatma;
        private System.Windows.Forms.Button ReturnBtn;
    }
}