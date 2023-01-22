using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTY_ODEV
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand( " Select * From Müşteri_Tablo", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müşteri_İd"].ToString();
                ekle.SubItems.Add(oku["Müşteri_Ad"].ToString());
                ekle.SubItems.Add(oku["Müşteri_Soyad"].ToString());
                ekle.SubItems.Add(oku["Müşteri_TelNo"].ToString());
                ekle.SubItems.Add(oku["Müşteri_DTarihi"].ToString());


                listView1.Items.Add(ekle);
            }

            baglantı.Close();
        }
        private void verilerigoster_btn_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From Müşteri_Tablo where Müşteri_TelNo like '%" +textBox1.Text+ "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müşteri_İd"].ToString();
                ekle.SubItems.Add(oku["Müşteri_Ad"].ToString());
                ekle.SubItems.Add(oku["Müşteri_Soyad"].ToString());
                ekle.SubItems.Add(oku["Müşteri_TelNo"].ToString());
                ekle.SubItems.Add(oku["Müşteri_DTarihi"].ToString());


                listView1.Items.Add(ekle);
            }

            baglantı.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kisiekle_btn_Click(object sender, EventArgs e)
        {
            Form9 form9= new Form9();
            form9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
