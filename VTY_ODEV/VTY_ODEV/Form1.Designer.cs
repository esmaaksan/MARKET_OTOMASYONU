namespace VTY_ODEV
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_mağza_müdürü = new System.Windows.Forms.Button();
            this.button_kasiyer = new System.Windows.Forms.Button();
            this.button_Muhasabe = new System.Windows.Forms.Button();
            this.roundbutton1 = new VTY_ODEV.roundbutton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-2, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "SÜPERMARKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-2, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "YÖNETİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(-2, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "SİSTEMİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "VERSİON 1.0";
            // 
            // button_mağza_müdürü
            // 
            this.button_mağza_müdürü.BackColor = System.Drawing.Color.DarkGray;
            this.button_mağza_müdürü.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_mağza_müdürü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_mağza_müdürü.Location = new System.Drawing.Point(209, 157);
            this.button_mağza_müdürü.Margin = new System.Windows.Forms.Padding(2);
            this.button_mağza_müdürü.Name = "button_mağza_müdürü";
            this.button_mağza_müdürü.Size = new System.Drawing.Size(449, 47);
            this.button_mağza_müdürü.TabIndex = 7;
            this.button_mağza_müdürü.Text = "MAĞAZA MÜDÜRÜ";
            this.button_mağza_müdürü.UseVisualStyleBackColor = false;
            this.button_mağza_müdürü.Click += new System.EventHandler(this.button_mağza_müdürü_Click);
            // 
            // button_kasiyer
            // 
            this.button_kasiyer.BackColor = System.Drawing.Color.DarkGray;
            this.button_kasiyer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_kasiyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_kasiyer.Location = new System.Drawing.Point(209, 219);
            this.button_kasiyer.Margin = new System.Windows.Forms.Padding(2);
            this.button_kasiyer.Name = "button_kasiyer";
            this.button_kasiyer.Size = new System.Drawing.Size(449, 47);
            this.button_kasiyer.TabIndex = 8;
            this.button_kasiyer.Text = "KASİYER";
            this.button_kasiyer.UseVisualStyleBackColor = false;
            this.button_kasiyer.Click += new System.EventHandler(this.button_kasiyer_Click);
            // 
            // button_Muhasabe
            // 
            this.button_Muhasabe.BackColor = System.Drawing.Color.DarkGray;
            this.button_Muhasabe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_Muhasabe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Muhasabe.Location = new System.Drawing.Point(209, 279);
            this.button_Muhasabe.Margin = new System.Windows.Forms.Padding(2);
            this.button_Muhasabe.Name = "button_Muhasabe";
            this.button_Muhasabe.Size = new System.Drawing.Size(449, 47);
            this.button_Muhasabe.TabIndex = 10;
            this.button_Muhasabe.Text = "MUHASABE";
            this.button_Muhasabe.UseVisualStyleBackColor = false;
            this.button_Muhasabe.Click += new System.EventHandler(this.button_Muhasabe_Click);
            // 
            // roundbutton1
            // 
            this.roundbutton1.BackColor = System.Drawing.Color.LightGray;
            this.roundbutton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roundbutton1.Location = new System.Drawing.Point(-141, -39);
            this.roundbutton1.Name = "roundbutton1";
            this.roundbutton1.Size = new System.Drawing.Size(379, 526);
            this.roundbutton1.TabIndex = 0;
            this.roundbutton1.Text = "     ";
            this.roundbutton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(731, 480);
            this.Controls.Add(this.button_Muhasabe);
            this.Controls.Add(this.button_kasiyer);
            this.Controls.Add(this.button_mağza_müdürü);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundbutton1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_mağza_müdürü;
        private System.Windows.Forms.Button button_kasiyer;
        private System.Windows.Forms.Button button_Muhasabe;
        private roundbutton roundbutton1;
    }
}

