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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTY_ODEV
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

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
            if(VarMi(textBox6.Text)!=0)
            {
                MessageBox.Show("Ürün zaten var.İşlem yapılamaz!");
            }
            else
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand("insert into urunler(urun_ismi,urun_adet,alis_fiyat,satis_fiyat,urun_STT,kategori,firma) values(@urun_ismi,@urun_adet,@alis_fiyat,@satis_fiyat,@urun_STT,@kategori,@firma)", baglantı);
                //cmd.Parameters.AddWithValue("@urun_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@urun_ismi", textBox6.Text);
                cmd.Parameters.AddWithValue("@urun_adet", textBox2.Text);
                cmd.Parameters.AddWithValue("@alis_fiyat", textBox5.Text);
                cmd.Parameters.AddWithValue("@satis_fiyat", textBox4.Text);
                cmd.Parameters.AddWithValue("@urun_STT", textBox3.Text);
                cmd.Parameters.AddWithValue("@kategori", comboBox1.Text);
                cmd.Parameters.AddWithValue("@firma", comboBox2.Text);

                cmd.ExecuteNonQuery();

                baglantı.Close();
                MessageBox.Show("ürün eklendi");
                comboBox2.Items.Clear();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is System.Windows.Forms.ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox8.Text == "")
            {
                label1.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }

                }
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from urunler where urun_ismi like '" + textBox8.Text + "' ");
            SqlDataReader read = komut.ExecuteReader();
    
            
            while (read.Read())
            {
               // textBox7.Text = read["urun_id"].ToString();
                label1.Text = read["urun_adet"].ToString();
                textBox12.Text = read["satis_fiyat"].ToString();
                textBox10.Text = read["alis_fiyat"].ToString();
                textBox11.Text = read["urun_STT"].ToString();
                comboBox3.Text = read["kategori"].ToString();
                comboBox4.Text = read["firma"].ToString();
            }
            baglantı.Close();*/
        }
        void Urungetir()
        {
            //videoda adam sql buraya bagladı
            baglantı.Open();
            da = new SqlDataAdapter("SELECT * FROM urunler", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource= tablo;
            baglantı.Close();
        }



        private void Form6_Load(object sender, EventArgs e)
        {
            Urungetir();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urun_ıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urun_adı.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            urun_adeti.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            urun_alıs.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            urun_satıs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            urun_stt.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString() ;
            kategori.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            marka.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void btn_sılme_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM urunler WHERE urun_ismi=@urun_ismi";
            komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@urun_ismi",Convert.ToString(urun_adı.Text));
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            Urungetir();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE urunler SET urun_ismi=@urun_ismi,kategori=@kategori,alis_fiyat=@alis_fiyat,firma=@firma,urun_STT=@urun_STT,urun_adet=@urun_adet,satis_fiyat=@satis_fiyat WHERE urun_id=@urun_id";
           
            komut = new SqlCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@urun_id",Convert.ToInt32(urun_ıd.Text));
            komut.Parameters.AddWithValue("@urun_ismi", urun_adı.Text);
            komut.Parameters.AddWithValue("@kategori",kategori.Text);
            komut.Parameters.AddWithValue("@satis_fiyat", Convert.ToInt32(urun_satıs.Text));
            komut.Parameters.AddWithValue("@firma",marka.Text);
            komut.Parameters.AddWithValue("@urun_STT", urun_stt.Text);
            komut.Parameters.AddWithValue("@urun_adet",Convert.ToInt32(urun_adeti.Text));
            komut.Parameters.AddWithValue("@alis_fiyat",Convert.ToInt32(urun_alıs.Text));
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            Urungetir();

                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
