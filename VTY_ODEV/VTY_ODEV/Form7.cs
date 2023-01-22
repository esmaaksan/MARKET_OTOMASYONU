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
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VTY_ODEV
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        private void btn_ürünekleme_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        void listele()
        {
            da= new SqlDataAdapter("select * from urunler",baglantı);
            baglantı.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }
        private void Yenile()
        {
            baglantı.Open();
            SqlDataAdapter tdGrvAdpter = new SqlDataAdapter("select * from urunler", baglantı);
            DataSet dtGrv = new DataSet();
            tdGrvAdpter.Fill(dtGrv);
            dataGridView1.DataSource = dtGrv.Tables[0];
            baglantı.Close();

            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells["urun_id"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["urun_ismi"].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells["urun_adet"].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells["alis_fiyat"].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells["satis_fiyat"].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells["urun_STT"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells["firma"].Value.ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            /* baglantı.Open();
             SqlCommand komut = new SqlCommand("update urunler set urun_ismi=@urun_ismi,urun_adet=@urun_adet,alis_fiyat=@alis_fiyat,satis_fiya=@satis_fiyat where urun_id=@urun_id", baglantı);
             komut.Parameters.AddWithValue("@urun_id", textBox7.Text);
             komut.Parameters.AddWithValue("@urun_ismi", textBox8.Text);
             komut.Parameters.AddWithValue("@urun_adet",int.Parse(textBox9.Text));
             komut.Parameters.AddWithValue("@alis_fiyat",double.Parse(textBox10.Text));
             komut.Parameters.AddWithValue("@satis_fiyat",double.Parse(textBox12.Text));

             komut.ExecuteNonQuery();
             baglantı.Close();
             MessageBox.Show("Güncelleme Yapıldı");

             foreach (Control item in this.Controls)
             {
                 if (item is System.Windows.Forms.TextBox)
                 {
                     item.Text = "";
                 }

             }*/
            baglantı.Open();
            SqlDataAdapter sqladaptör = new SqlDataAdapter("select count(*) from urunler where urun_id = '" + textBox7.Text + "'", baglantı);
            DataTable dtablo = new DataTable();
            sqladaptör.Fill(dtablo);

            if (dtablo.Rows[0][0].ToString() == "1")
            {
                SqlCommand komut = new SqlCommand("update urunler set urun_ismi=@urun_ismi,urun_adet=@urun_adet,alis_fiyat=@alis_fiyat,satis_fiya=@satis_fiyat where urun_id=@urun_id", baglantı);
                komut.Parameters.AddWithValue("@urun_id", textBox7.Text);
                komut.Parameters.AddWithValue("@urun_ismi", textBox8.Text);
                komut.Parameters.AddWithValue("@urun_adet", int.Parse(textBox9.Text));
                komut.Parameters.AddWithValue("@alis_fiyat", double.Parse(textBox10.Text));
                komut.Parameters.AddWithValue("@satis_fiyat", double.Parse(textBox12.Text));
                komut.ExecuteNonQuery();

            }
            else
            {

            }
            baglantı.Close();
            Yenile();
        
    }

    private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlDataAdapter veri=new SqlDataAdapter("select * from urunler",baglantı);
            DataSet dtGrv=new DataSet();
            veri.Fill(dtGrv);
            dataGridView1.DataSource = dtGrv.Tables[0];
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* baglantı.Open();
            SqlCommand verioku = new SqlCommand("select * from urunler where urun_id = '" + textBox1.Text.ToString() + "'", baglantı);
            verioku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = verioku.ExecuteReader();

            while (oku.Read())
            {

                textBox1.Text = oku["urun_id"].ToString();
              

            }
            oku.Close();
            baglantı.Close();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "urun_id LIKE'" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
