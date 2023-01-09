using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DavaTakipOtomasyonu
{
    public partial class Form3 : Form
    {
        OleDbConnection db = new OleDbConnection(@"Provider=microsoft.ace.oledb.12.0;data source=DavaTakipVeriTabani.accdb");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
             
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
            db.Open();
            OleDbCommand cmd = new OleDbCommand("insert into KullaniciVeri(TCno,Sifre)values(@TCno,@Sifre)",db);
            cmd.Parameters.AddWithValue("@TCno", MtxtTCnoKayit.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifreKayit.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt işlemi başarılıdır");

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bilgiler ile kayıt olunuz");
            }
            finally
            {
                db.Close();
                txtSifreKayit.Clear();
                MtxtTCnoKayit.Clear();
            }
            
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Form1 Giris = new Form1();
            Giris.Show();
            this.Close();
        }
    }
}
