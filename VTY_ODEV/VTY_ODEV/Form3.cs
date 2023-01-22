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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void butongizle()
        {
            satıs_btn.Enabled= false;

        }
        public void butongizle2()
        {
            calısansorgula_btn.Enabled = false;
            rapor_btn.Enabled = false;
            button1.Enabled = false;

        }
        public void butongizle4()
        {
            calısansorgula_btn.Enabled = false;
            button1.Enabled = false;
            satıs_btn.Enabled = false;
            müşteribilgileri_btn.Enabled = false;
            stok_btn.Enabled = false;

        }
        private void müşteribilgileri_btn_Click(object sender, EventArgs e)
        {
            
            Form4 form4= new Form4();    
            form4.Show();
            this.Hide();

        }

        private void calısansorgula_btn_Click(object sender, EventArgs e)
        {
            Form10 form10= new Form10();
            form10.Show(); this.Hide();
        }

        private void satıs_btn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void stok_btn_Click(object sender, EventArgs e)
        {
            Form8 form8= new Form8();
            form8.Show();
            this.Hide();
        }

        private void cıkış_btn_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();   
            form2.Show();
            this.Hide();
        }

        private void rapor_btn_Click(object sender, EventArgs e)
        {
            Form12 form12= new Form12();
            form12.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {   
           
        }
    }
}
