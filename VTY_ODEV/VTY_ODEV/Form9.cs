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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTY_ODEV
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");


        public int VarMi(string aranan)
        {
            int sonuc;
            string sorgu = "Select COUNT(Müşteri_TelNo) from Müşteri_Tablo Where Müşteri_TelNo='" + aranan + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglantı);
            baglantı.Open();
            sonuc=Convert.ToInt32(komut.ExecuteScalar());

            baglantı.Close();
            return sonuc;
        }

        private void BtnYenİEkle_Click(object sender, EventArgs e)
        {
            if(VarMi(textBox5.Text)!=0)
            {
                MessageBox.Show("Bu Numara Kayıtlı .İşlem Yapılamaz !");
            }
            else
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand("insert into Müşteri_Tablo(Müşteri_Ad,Müşteri_Soyad,Müşteri_TelNo,Müşteri_DTarihi) values(@Müşteri_Ad,@Müşteri_Soyad,@Müşteri_TelNo,@Müşteri_DTarihi)", baglantı);
                //cmd.Parameters.AddWithValue("@urun_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Müşteri_Ad", textBox6.Text);
                cmd.Parameters.AddWithValue("@Müşteri_Soyad", textBox2.Text);
                cmd.Parameters.AddWithValue("@Müşteri_TelNo", textBox5.Text);
                cmd.Parameters.AddWithValue("@Müşteri_DTarihi", textBox4.Text);

                cmd.ExecuteNonQuery();

                baglantı.Close();
                MessageBox.Show("Müşteri eklendi");
            }
           
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4= new Form4();
            form4.Show();
            this.Hide();
        }
    }
    
}
