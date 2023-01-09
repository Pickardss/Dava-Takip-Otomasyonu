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
    public partial class Form1 : Form
    {
        OleDbConnection db = new OleDbConnection(@"Provider=microsoft.ace.oledb.12.0;data source=DavaTakipVeriTabani.accdb");
        public Form1()
        {
            InitializeComponent();
        }

         

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
            db.Open();
            OleDbCommand sorgu = new OleDbCommand("select TCno,Sifre from KullaniciVeri where TCno=@TCno and Sifre=@Sifre",db);
            sorgu.Parameters.AddWithValue("@TCno", MtxtTCno.Text);
            sorgu.Parameters.AddWithValue("@Sifre", txtsifre.Text);
            OleDbDataReader dr;
            dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                Form2 Menu = new Form2();
                Menu.Show();
                this.Visible = false;
            }
            else
            {
                db.Close();
                MessageBox.Show("bilgilerinizi yanlış girdiniz");
            }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen TCno ve Şifrenizi doğru giriniz ");
            }
            finally
            {
                MtxtTCno.Clear();
                txtsifre.Clear();
            }
            
        
        }

        private void txtkadi_TextChanged(object sender, EventArgs e)
        {

        }
        private void linkLblKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 YeniKayit = new Form3();
            YeniKayit.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
