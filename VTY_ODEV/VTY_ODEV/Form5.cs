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
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace VTY_ODEV
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        DataTable tablo = new DataTable();
        DataSet daset = new DataSet();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        SqlCommand komut = new SqlCommand();


       private void listele()
        {
            baglantı.Open();
            string query = "SELECT urun_id,urun_ismi,satis_fiyat FROM urunler ";
            SqlDataAdapter sda = new SqlDataAdapter(query,baglantı);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
            baglantı.Close();


        }
        private void listele2()
        {
            baglantı.Open();
            string query = "SELECT barkod_No,urun_ismi,urun_miktar FROM Fiş ";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglantı);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            baglantı.Close();


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            /*
            baglantı.Open();
            SqlCommand komut = new SqlCommand(" Select * From urunler where urun_id like '%" + textBox3.Text + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
              
              
    

              
            }

            baglantı.Close();*/
        }

        private void kampanya_btn_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.Show();
            this.Hide();
        }

        private void stok_btn_Click(object sender, EventArgs e)
        {

            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void satis_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listele();
            listele2();

           

        }

        private  void tusTakimi(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*textBox3.Text = textBox3.Text.Substring(textBox3.Text.Length - 1);
            textBox3.Text = "";
            textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 1);
            textBox1.Text = "";
            textBox6.Text = textBox6.Text.Substring(textBox6.Text.Length - 1);
            textBox6.Text = "";*/
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBox3;
            }
        }
        int grdtotal = 0 , n=0;
        private void button10_Click_1(object sender, EventArgs e)
        {
            
            if(textBox3.Text=="" || textBox1.Text=="")
            {
                MessageBox.Show("girilmiş ürün miktarı bulunmamaktadır.");
            }
            else {
                
                

                int total = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text);
                textBox6.Text = total.ToString();
            DataGridViewRow newRow= new DataGridViewRow();
            newRow.CreateCells(dataGridView2);
           // newRow.Cells[0].Value = n+1;
            newRow.Cells[0].Value = textBox3.Text;
            newRow.Cells[1].Value = textBox4.Text;
             newRow.Cells[2].Value = textBox2.Text;
            newRow.Cells[3].Value= textBox1.Text;
            newRow.Cells[4].Value = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text);
            dataGridView2.Rows.Add(newRow);
           // n++;
            grdtotal = grdtotal + total;
            label4.Text = grdtotal+"tl" ;
            string sorgu = "UPDATE urunler SET urun_adet=urun_adet-'" + Convert.ToInt32(textBox1.Text)  + "' WHERE urun_id=@urun_id";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglantı);
            }
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Veriler Görüntülenemedi");
            }
            else
            {
                try
                {
                    baglantı.Open();
                    string query = "insert into Fiş(barkod_No,urun_ismi,urun_miktar) values(" + textBox3.Text + " ,'" + textBox4.Text + "'," + textBox1.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, baglantı);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ekleme Başarılı");
                    baglantı.Close();
                    listele2();
                    string sorgu = "UPDATE urunler SET urun_adet=urun_adet-'" + Convert.ToInt32(textBox1.Text) + "' WHERE urun_id=@urun_id";
                    SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglantı);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // Convert.ToInt32(label4.Text)
                    //'" + aranan + "'
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
          
        }

        private void z_rapor_btn_Click(object sender, EventArgs e)
        {
         

        }
    }
}
