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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTY_ODEV
{
    public partial class Form2 : Form
    {
        public Form2()

        {
           // CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
        
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void loginActivity(string username, string password)
        {
            try
            {
                Form2 login = new Form2();
                SqlCommand cmd = new SqlCommand("Select Kullanıcı_Adı,Sifre,yetki From giris where Kullanıcı_Adı='" + username + "' and Sifre='" + password + "' and yetki='" + comboBox1.Text + "'", baglantı);
                baglantı.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Başarılı giriş yaptınız ! " + comboBox1.Text, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //--------------------------------------------------------
                    string authority_str = comboBox1.SelectedItem.ToString();
                    string str = "1";
                    string str2 = "3";
                    string str4 = "4";

                    if (authority_str == str)
                    {
                        Form3 mn = new Form3();
                        mn.butongizle();

                        dr.Close();
                        login.Hide();
                        mn.Show();
                    }
                   
                    else if (authority_str == str2)
                    {
                        Form3 mn = new Form3();
                        mn.butongizle2();

                        dr.Close();
                        login.Hide();
                        mn.Show();
                    }
                    else if (authority_str == str4)
                    {
                        Form3 mn = new Form3();
                        mn.butongizle4();

                        dr.Close();
                        login.Hide();
                        mn.Show();
                    }
                    //---------------------------------------------------------
                    else
                    {
                        dr.Close();
                        login.Hide();
                        Form3 mm = new Form3();
                        mm.Show();
                    }

                }
                else
                {
                   
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            baglantı.Close();
            
        }

        public void veriçekme()
        {
            SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select distinct yetki from giris", baglantı);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]).ToString();
            }
            dr.Close();
            baglantı.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {

            /* SqlConnection baglantı = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
             baglantı.Open();
             SqlDataAdapter da = new SqlDataAdapter("select * from giris where Kullanıcı_Adı=@Kullanıcı_Adı and Sifre=@Sifre", baglantı);
             da.SelectCommand.Parameters.AddWithValue("Kullanıcı_Adı", textBox1.Text);
             da.SelectCommand.Parameters.AddWithValue("Sifre", textBox2.Text);
             DataTable dt = new DataTable();
             da.Fill(dt);
             if(dt.Rows.Count>0)
             {
               //      ((Form3)this.ParentForm).satıs_btn.Enabled = false;
            //     MessageBox.Show("giriş yapıldı");

                 Form3 form3= new Form3();
                 form3.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("yanlış kullanıcı");
             }
             baglantı.Close();*/
            string username = textBox1.Text;
            string password = textBox2.Text;
            loginActivity(username, password);
            this.Hide();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Form3 form3 = new Form3();
            string Kullanıcı_Adı = textBox1.Text;
            string Sifre = textBox2.Text;
            SqlConnection con = new SqlConnection("server=LAPTOP-5MD3DQG1; Initial Catalog=veritabanı1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM giris where Kullanıcı_Adı='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {   form3.Show();
                this.Hide();
                
              //  MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();


        }

        private void Çıkış_Btn_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            veriçekme();
        }
    }
}
