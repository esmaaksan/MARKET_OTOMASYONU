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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");


      

        private void BtnYenİEkle_Click(object sender, EventArgs e)
        {

           
                baglantı.Open();
                SqlCommand cmd = new SqlCommand("insert into Çalışanlar(Çalışan_Ad,Çalışan_Soyad,Çalışan_DTarihi,Çalışan_TelNo,Çalışan_Adres,Çalışan_Departmanı) values(@Çalışan_Ad,@Çalışan_Soyad,@Çalışan_DTarihi,@Çalışan_TelNo,@Çalışan_Adres,@Çalışan_Departmanı)", baglantı);
                //cmd.Parameters.AddWithValue("@urun_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Çalışan_Ad", textBox6.Text);
                cmd.Parameters.AddWithValue("@Çalışan_Soyad", textBox2.Text);
                cmd.Parameters.AddWithValue("@Çalışan_DTarihi", textBox5.Text);
                cmd.Parameters.AddWithValue("@Çalışan_TelNo", textBox4.Text);
                cmd.Parameters.AddWithValue("@Çalışan_Adres", textBox1.Text);
                cmd.Parameters.AddWithValue("@Çalışan_Departmanı", textBox3.Text);

                cmd.ExecuteNonQuery();

                baglantı.Close();
                MessageBox.Show("Çalışan Eklendi ");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10= new Form10();
            form10.Show();
            this.Hide();
        }
    }
}
