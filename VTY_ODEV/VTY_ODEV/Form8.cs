using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTY_ODEV
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From urunler", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["urun_id"].ToString();
                ekle.SubItems.Add(oku["urun_ismi"].ToString());
                ekle.SubItems.Add(oku["kategori"].ToString());
                ekle.SubItems.Add(oku["satis_fiyat"].ToString());
                ekle.SubItems.Add(oku["firma"].ToString());
                ekle.SubItems.Add(oku["urun_STT"].ToString());
                ekle.SubItems.Add(oku["urun_adet"].ToString());
                ekle.SubItems.Add(oku["alis_fiyat"].ToString());


                listView1.Items.Add(ekle);
            }

            baglantı.Close();
        }




        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From urunler where urun_ismi like '%" + textBox1.Text + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["urun_id"].ToString();
                ekle.SubItems.Add(oku["urun_ismi"].ToString());
                ekle.SubItems.Add(oku["kategori"].ToString());
                ekle.SubItems.Add(oku["satis_fiyat"].ToString());
                ekle.SubItems.Add(oku["firma"].ToString());
                ekle.SubItems.Add(oku["urun_STT"].ToString());
                ekle.SubItems.Add(oku["urun_adet"].ToString());
                ekle.SubItems.Add(oku["alis_fiyat"].ToString());


                listView1.Items.Add(ekle);
            }

            baglantı.Close();


        }

        private void verilerigoster_btn_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5=new Form5();
            form5.Show();
            this.Hide();
        }

        private void btn_ürünekleme_Click(object sender, EventArgs e)
        {
            Form6 form6=new Form6();
            form6.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
