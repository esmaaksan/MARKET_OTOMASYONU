namespace VTY_ODEV
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.urun_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urun_ismi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satis_fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urun_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urun_adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alis_fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.verilerigoster_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Silver;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urun_id,
            this.urun_ismi,
            this.kategori,
            this.satis_fiyat,
            this.firma,
            this.urun_STT,
            this.urun_adet,
            this.alis_fiyat});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(963, 314);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // urun_id
            // 
            this.urun_id.Text = "urun_id";
            this.urun_id.Width = 127;
            // 
            // urun_ismi
            // 
            this.urun_ismi.Text = "urun_ismi";
            this.urun_ismi.Width = 125;
            // 
            // kategori
            // 
            this.kategori.Text = "kategori";
            this.kategori.Width = 138;
            // 
            // satis_fiyat
            // 
            this.satis_fiyat.Text = "satis_fiyat";
            this.satis_fiyat.Width = 118;
            // 
            // firma
            // 
            this.firma.Text = "firma";
            this.firma.Width = 125;
            // 
            // urun_STT
            // 
            this.urun_STT.Text = "urun_STT";
            this.urun_STT.Width = 155;
            // 
            // urun_adet
            // 
            this.urun_adet.Text = "urun_adet";
            // 
            // alis_fiyat
            // 
            this.alis_fiyat.Text = "alis_fiyat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "ARANACAK ÜRÜN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(424, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 44);
            this.button1.TabIndex = 62;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verilerigoster_btn
            // 
            this.verilerigoster_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.verilerigoster_btn.Location = new System.Drawing.Point(424, 69);
            this.verilerigoster_btn.Name = "verilerigoster_btn";
            this.verilerigoster_btn.Size = new System.Drawing.Size(186, 44);
            this.verilerigoster_btn.TabIndex = 61;
            this.verilerigoster_btn.Text = "Verileri Göster";
            this.verilerigoster_btn.UseVisualStyleBackColor = false;
            this.verilerigoster_btn.Click += new System.EventHandler(this.verilerigoster_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(541, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 44);
            this.button2.TabIndex = 64;
            this.button2.Text = "ANA EKRAN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(733, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 44);
            this.button3.TabIndex = 65;
            this.button3.Text = "SATIŞ EKRANI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(958, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verilerigoster_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader urun_id;
        private System.Windows.Forms.ColumnHeader urun_ismi;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.ColumnHeader satis_fiyat;
        private System.Windows.Forms.ColumnHeader firma;
        private System.Windows.Forms.ColumnHeader urun_STT;
        private System.Windows.Forms.ColumnHeader urun_adet;
        private System.Windows.Forms.ColumnHeader alis_fiyat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verilerigoster_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}