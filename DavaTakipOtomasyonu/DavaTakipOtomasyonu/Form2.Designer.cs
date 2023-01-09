
namespace DavaTakipOtomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDosyaIslemleri = new System.Windows.Forms.Button();
            this.btnDosyaListele = new System.Windows.Forms.Button();
            this.btnDurusmaIslemleri = new System.Windows.Forms.Button();
            this.btnDurusmaListele = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.btnKapatma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDosyaIslemleri
            // 
            this.btnDosyaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaIslemleri.Image")));
            this.btnDosyaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaIslemleri.Location = new System.Drawing.Point(12, 367);
            this.btnDosyaIslemleri.Name = "btnDosyaIslemleri";
            this.btnDosyaIslemleri.Size = new System.Drawing.Size(243, 62);
            this.btnDosyaIslemleri.TabIndex = 7;
            this.btnDosyaIslemleri.Text = "Dosya İşlemleri";
            this.btnDosyaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaIslemleri.UseVisualStyleBackColor = true;
            this.btnDosyaIslemleri.Click += new System.EventHandler(this.btnDosyaIslemleri_Click);
            // 
            // btnDosyaListele
            // 
            this.btnDosyaListele.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaListele.Image")));
            this.btnDosyaListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaListele.Location = new System.Drawing.Point(334, 367);
            this.btnDosyaListele.Name = "btnDosyaListele";
            this.btnDosyaListele.Size = new System.Drawing.Size(243, 62);
            this.btnDosyaListele.TabIndex = 9;
            this.btnDosyaListele.Text = "Dosyaları Listele";
            this.btnDosyaListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaListele.UseVisualStyleBackColor = true;
            this.btnDosyaListele.Click += new System.EventHandler(this.btnDosyaListele_Click);
            // 
            // btnDurusmaIslemleri
            // 
            this.btnDurusmaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnDurusmaIslemleri.Image")));
            this.btnDurusmaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDurusmaIslemleri.Location = new System.Drawing.Point(675, 367);
            this.btnDurusmaIslemleri.Name = "btnDurusmaIslemleri";
            this.btnDurusmaIslemleri.Size = new System.Drawing.Size(243, 62);
            this.btnDurusmaIslemleri.TabIndex = 10;
            this.btnDurusmaIslemleri.Text = "Duruşma İşlemleri";
            this.btnDurusmaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDurusmaIslemleri.UseVisualStyleBackColor = true;
            this.btnDurusmaIslemleri.Click += new System.EventHandler(this.btnDurusmaIslemleri_Click);
            // 
            // btnDurusmaListele
            // 
            this.btnDurusmaListele.Image = ((System.Drawing.Image)(resources.GetObject("btnDurusmaListele.Image")));
            this.btnDurusmaListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDurusmaListele.Location = new System.Drawing.Point(999, 367);
            this.btnDurusmaListele.Name = "btnDurusmaListele";
            this.btnDurusmaListele.Size = new System.Drawing.Size(243, 62);
            this.btnDurusmaListele.TabIndex = 12;
            this.btnDurusmaListele.Text = "Duruşmaları Listele";
            this.btnDurusmaListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDurusmaListele.UseVisualStyleBackColor = true;
            this.btnDurusmaListele.Click += new System.EventHandler(this.btnDurusmaListele_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReturnBtn.Image")));
            this.ReturnBtn.Location = new System.Drawing.Point(12, 12);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(89, 78);
            this.ReturnBtn.TabIndex = 13;
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // btnKapatma
            // 
            this.btnKapatma.Image = ((System.Drawing.Image)(resources.GetObject("btnKapatma.Image")));
            this.btnKapatma.Location = new System.Drawing.Point(1153, 12);
            this.btnKapatma.Name = "btnKapatma";
            this.btnKapatma.Size = new System.Drawing.Size(89, 78);
            this.btnKapatma.TabIndex = 14;
            this.btnKapatma.UseVisualStyleBackColor = true;
            this.btnKapatma.Click += new System.EventHandler(this.btnKapatma_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1254, 711);
            this.Controls.Add(this.btnKapatma);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.btnDurusmaListele);
            this.Controls.Add(this.btnDurusmaIslemleri);
            this.Controls.Add(this.btnDosyaListele);
            this.Controls.Add(this.btnDosyaIslemleri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDosyaIslemleri;
        private System.Windows.Forms.Button btnDosyaListele;
        private System.Windows.Forms.Button btnDurusmaIslemleri;
        private System.Windows.Forms.Button btnDurusmaListele;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button btnKapatma;
    }
}