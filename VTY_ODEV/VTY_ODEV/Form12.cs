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

namespace VTY_ODEV
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From Kar_Zarar where Durum like '%" + textBox1.Text + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["GünId"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Durum"].ToString());
              

                listView1.Items.Add(ekle);
            }

            baglantı.Close();

        }

        private void verilerigoster_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From Kar_Zarar", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["GünId"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Durum"].ToString());


                listView1.Items.Add(ekle);
            }

            
            baglantı.Close();
        }
        public int VarMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select COUNT(urun_ismi) from urunler Where urun_ismi='" + aranan + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglantı);
            baglantı.Open();
            sonuc = Convert.ToInt32(komut.ExecuteScalar());

            baglantı.Close();
            return sonuc;
        }
        private void BtnYenİEkle_Click(object sender, EventArgs e)
        {
            if (VarMi(textBox6.Text) != 0)
            {
                MessageBox.Show("Aynı Tarih Var.İşlem yapılamaz!");
            }
            else
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand("insert into Kar_Zarar(Tarih,Durum) values(@Tarih,@Durum)", baglantı);
                //cmd.Parameters.AddWithValue("@urun_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Tarih", textBox6.Text);
                cmd.Parameters.AddWithValue("@Durum", textBox2.Text);
               
         

                cmd.ExecuteNonQuery();

                baglantı.Close();
                MessageBox.Show("Durum eklendi");
                
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
