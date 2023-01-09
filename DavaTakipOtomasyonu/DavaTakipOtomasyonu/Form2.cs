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
    public partial class Form2 : Form
    {
        OleDbConnection db = new OleDbConnection(@"Provider=microsoft.ace.oledb.12.0;data source=" +Application.StartupPath + "\\DavaTakipVeriTabani.accdb");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();

        
        public void listele()
        {
            tablo.Clear();
            db.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from dosya", db);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
        }

        public void listele2()
        {
            tablo2.Clear();
            db.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from durusma", db);
            adtr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDosyaIslemleri_Click(object sender, EventArgs e)
        {
            Dosya Dosya = new Dosya();
            Dosya.Show();
            this.Hide();
        }

        private void btnDurusmaIslemleri_Click(object sender, EventArgs e)
        {
            durusma duruşma = new durusma();
            duruşma.Show();
            this.Hide();
        }

        private void btnDosyaListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnDurusmaListele_Click(object sender, EventArgs e)
        {
            listele2();
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
