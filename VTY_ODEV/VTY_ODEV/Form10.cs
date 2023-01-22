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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From Çalışanlar where Çalışan_Ad like '%" + textBox1.Text + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Çalışan_İd"].ToString();
                ekle.SubItems.Add(oku["Çalışan_Ad"].ToString());
                ekle.SubItems.Add(oku["Çalışan_Soyad"].ToString());
                ekle.SubItems.Add(oku["Çalışan_DTarihi"].ToString());
                ekle.SubItems.Add(oku["Çalışan_TelNo"].ToString());
                ekle.SubItems.Add(oku["Çalışan_Adres"].ToString());
                ekle.SubItems.Add(oku["Çalışan_Departmanı"].ToString());


                listView1.Items.Add(ekle);
            }

            baglantı.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verilerigoster_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From Çalışanlar", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Çalışan_İd"].ToString();
                ekle.SubItems.Add(oku["Çalışan_Ad"].ToString());
                ekle.SubItems.Add(oku["Çalışan_Soyad"].ToString());
                ekle.SubItems.Add(oku["Çalışan_DTarihi"].ToString());
                ekle.SubItems.Add(oku["Çalışan_TelNo"].ToString());
                ekle.SubItems.Add(oku["Çalışan_Adres"].ToString());
                ekle.SubItems.Add(oku["Çalışan_Departmanı"].ToString());


                listView1.Items.Add(ekle);
            }

            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
            this.Hide();
        }

        private void kisiekle_btn_Click(object sender, EventArgs e)
        {
            Form11 form11= new Form11();
            form11.Show();
            this.Hide();
        }
    }
}
