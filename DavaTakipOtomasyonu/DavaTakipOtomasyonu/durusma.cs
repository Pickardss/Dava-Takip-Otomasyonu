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
    public partial class durusma : Form
    {
        OleDbConnection db = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\DavaTakipVeritabani.accdb");
        DataTable tablo = new DataTable();
        public durusma()
        {
            InitializeComponent();
        }

        public void doldur()
        {
            db.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from dosya", db);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                comboBox1.Items.Add(dr["dosyano"].ToString());

            }
            db.Close();
        }
        public void listele()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";

            tablo.Clear();
            db.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter
            ("select * from durusma", db);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
        }
        public void listele2()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";

            tablo.Clear();
            db.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter
            ("select * from durusma where dosyano='" + textBox10.Text + "'", db);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            db.Close();
        }
        private void durusma_Load(object sender, EventArgs e)
        {
            doldur();
            listele();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker3.Value.ToShortDateString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
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
            ("INSERT INTO durusma(durusmatarihi,durusmasaat,kesiftarihi,kesifsaat,mehilsuresi,muracaattarihi,davano) values('" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", db);
            cmd.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            db.Open();
            cmd = new OleDbCommand("UPDATE durusma SET durusmatarihi='" + textBox1.Text + "',durusmasaat='" + maskedTextBox1.Text + "',kesiftarihi='" + textBox2.Text + "',kesifsaat='" + maskedTextBox2.Text + "',mehilsuresi='" + textBox3.Text + "',muracaattarihi='" + textBox4.Text + "',davano='" + comboBox1.Text + "'where davano='" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "'", db);
            cmd.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            db.Open();
            cmd = new OleDbCommand("Delete from durusma where davano = '" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "'", db);
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

        private void button5_Click(object sender, EventArgs e)
        {
            listele2();
        }
    }
}
