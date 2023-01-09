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
    public partial class Dosya : Form
    {
        OleDbConnection db = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\DavaTakipVeritabani.accdb");
        DataTable tablo = new DataTable();
        public Dosya()
        {
            InitializeComponent();
        }

        public void listele()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";

            tablo.Clear();
            db.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter
          ("select * from dosya", db);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
        }

        private void Dosya_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (db.State == ConnectionState.Open)
            {
                db.Close();
            }
            db.Open();

            OleDbCommand cmd;

            cmd = new OleDbCommand
            ("INSERT INTO dosya(dosyano,mahkeme,esasno,burono,davanevi,aciklama,tarih,yenilemetarihi,davaci,davali) values('" + textBox11.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", db);
            cmd.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            db.Open();
            OleDbCommand cmd;
            cmd = new OleDbCommand("UPDATE dosya set dosyano='" + textBox11.Text + "',mahkeme='" + textBox1.Text + "',esasno='" + textBox2.Text + "',burono='" + textBox3.Text + "',davanevi='" + textBox4.Text + "',aciklama='" + textBox5.Text + "',tarih='" + textBox6.Text + "',yenilemetarihi='" + textBox7.Text + "',davaci='" + textBox8.Text + "',davali='" + textBox9.Text + "'where dosyano='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", db);
            cmd.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            db.Open();
            cmd = new OleDbCommand("Delete from dosya where dosyano = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", db);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            db.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
            this.Dispose();
        }

        public void listele2()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";

            tablo.Clear();
            db.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter
          ("select * from dosya where dosyano='" + textBox10.Text + "'", db);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            listele2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox7.Text = dateTimePicker2.Value.ToShortDateString();
        }
    }
}
