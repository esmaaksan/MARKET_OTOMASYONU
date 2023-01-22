namespace VTY_ODEV
{
    partial class Form4
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
            this.Müşteri_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Müşteri_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Müşteri_Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Müşteri_Telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Müşteri_Puan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Müşteri_DoğumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.verilerigoster_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kisiekle_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Silver;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Müşteri_Id,
            this.Müşteri_Ad,
            this.Müşteri_Soyad,
            this.Müşteri_Telno,
            this.Müşteri_Puan,
            this.Müşteri_DoğumTarihi});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Müşteri_Id
            // 
            this.Müşteri_Id.Text = "Müşteri_Id";
            this.Müşteri_Id.Width = 127;
            // 
            // Müşteri_Ad
            // 
            this.Müşteri_Ad.Text = "Müşteri_Ad";
            this.Müşteri_Ad.Width = 125;
            // 
            // Müşteri_Soyad
            // 
            this.Müşteri_Soyad.Text = "Müşteri_Soyad";
            this.Müşteri_Soyad.Width = 138;
            // 
            // Müşteri_Telno
            // 
            this.Müşteri_Telno.Text = "Müşteri_Telno";
            this.Müşteri_Telno.Width = 118;
            // 
            // Müşteri_Puan
            // 
            this.Müşteri_Puan.Text = "Müşteri_Puan";
            this.Müşteri_Puan.Width = 125;
            // 
            // Müşteri_DoğumTarihi
            // 
            this.Müşteri_DoğumTarihi.Text = "Müşteri_DoğumTarihi";
            this.Müşteri_DoğumTarihi.Width = 155;
            // 
            // verilerigoster_btn
            // 
            this.verilerigoster_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.verilerigoster_btn.Location = new System.Drawing.Point(191, 84);
            this.verilerigoster_btn.Name = "verilerigoster_btn";
            this.verilerigoster_btn.Size = new System.Drawing.Size(173, 42);
            this.verilerigoster_btn.TabIndex = 1;
            this.verilerigoster_btn.Text = "Verileri Göster";
            this.verilerigoster_btn.UseVisualStyleBackColor = false;
            this.verilerigoster_btn.Click += new System.EventHandler(this.verilerigoster_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(392, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ARANACAK KİŞİ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kisiekle_btn
            // 
            this.kisiekle_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kisiekle_btn.Location = new System.Drawing.Point(16, 84);
            this.kisiekle_btn.Name = "kisiekle_btn";
            this.kisiekle_btn.Size = new System.Drawing.Size(169, 41);
            this.kisiekle_btn.TabIndex = 5;
            this.kisiekle_btn.Text = "Kişi Ekle";
            this.kisiekle_btn.UseVisualStyleBackColor = false;
            this.kisiekle_btn.Click += new System.EventHandler(this.kisiekle_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(623, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kisiekle_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verilerigoster_btn);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Müşteri_Id;
        private System.Windows.Forms.ColumnHeader Müşteri_Ad;
        private System.Windows.Forms.ColumnHeader Müşteri_Soyad;
        private System.Windows.Forms.ColumnHeader Müşteri_Telno;
        private System.Windows.Forms.ColumnHeader Müşteri_Puan;
        private System.Windows.Forms.ColumnHeader Müşteri_DoğumTarihi;
        private System.Windows.Forms.Button verilerigoster_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button kisiekle_btn;
        private System.Windows.Forms.Button button2;
    }
}