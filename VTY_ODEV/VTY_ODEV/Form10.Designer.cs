namespace VTY_ODEV
{
    partial class Form10
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
            this.button2 = new System.Windows.Forms.Button();
            this.kisiekle_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.verilerigoster_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Çalışan_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Çalışan_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Çalışan_Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Çalışan_DTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Çalışan_TelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Çalışan_Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Çalışan_Departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(609, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kisiekle_btn
            // 
            this.kisiekle_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kisiekle_btn.Location = new System.Drawing.Point(63, 82);
            this.kisiekle_btn.Name = "kisiekle_btn";
            this.kisiekle_btn.Size = new System.Drawing.Size(169, 41);
            this.kisiekle_btn.TabIndex = 12;
            this.kisiekle_btn.Text = "Kişi Ekle";
            this.kisiekle_btn.UseVisualStyleBackColor = false;
            this.kisiekle_btn.Click += new System.EventHandler(this.kisiekle_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ARANACAK KİŞİ  ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(416, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verilerigoster_btn
            // 
            this.verilerigoster_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.verilerigoster_btn.Location = new System.Drawing.Point(238, 81);
            this.verilerigoster_btn.Name = "verilerigoster_btn";
            this.verilerigoster_btn.Size = new System.Drawing.Size(186, 44);
            this.verilerigoster_btn.TabIndex = 8;
            this.verilerigoster_btn.Text = "Verileri Göster";
            this.verilerigoster_btn.UseVisualStyleBackColor = false;
            this.verilerigoster_btn.Click += new System.EventHandler(this.verilerigoster_btn_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Silver;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Çalışan_Id,
            this.Çalışan_Ad,
            this.Çalışan_Soyad,
            this.Çalışan_DTarihi,
            this.Çalışan_TelNo,
            this.Çalışan_Adres,
            this.Çalışan_Departman});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(955, 314);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Çalışan_Id
            // 
            this.Çalışan_Id.Text = "Çalışan_Id";
            this.Çalışan_Id.Width = 127;
            // 
            // Çalışan_Ad
            // 
            this.Çalışan_Ad.Text = "Çalışan_Ad";
            this.Çalışan_Ad.Width = 125;
            // 
            // Çalışan_Soyad
            // 
            this.Çalışan_Soyad.Text = "Çalışan_Soyad";
            this.Çalışan_Soyad.Width = 138;
            // 
            // Çalışan_DTarihi
            // 
            this.Çalışan_DTarihi.Text = "Çalışan_DTarihi";
            this.Çalışan_DTarihi.Width = 118;
            // 
            // Çalışan_TelNo
            // 
            this.Çalışan_TelNo.Text = "Çalışan_TelNo";
            this.Çalışan_TelNo.Width = 125;
            // 
            // Çalışan_Adres
            // 
            this.Çalışan_Adres.Text = "Çalışan_Adres";
            this.Çalışan_Adres.Width = 155;
            // 
            // Çalışan_Departman
            // 
            this.Çalışan_Departman.Text = "Çalışan_Departman";
            this.Çalışan_Departman.Width = 143;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(954, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kisiekle_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verilerigoster_btn);
            this.Controls.Add(this.listView1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button kisiekle_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verilerigoster_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Çalışan_Id;
        private System.Windows.Forms.ColumnHeader Çalışan_Ad;
        private System.Windows.Forms.ColumnHeader Çalışan_Soyad;
        private System.Windows.Forms.ColumnHeader Çalışan_DTarihi;
        private System.Windows.Forms.ColumnHeader Çalışan_TelNo;
        private System.Windows.Forms.ColumnHeader Çalışan_Adres;
        private System.Windows.Forms.ColumnHeader Çalışan_Departman;
    }
}