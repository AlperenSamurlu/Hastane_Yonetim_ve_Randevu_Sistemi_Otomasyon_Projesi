namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_Girisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Girisler));
            this.btn_hasta_giris = new System.Windows.Forms.Button();
            this.btn_doktor_giris = new System.Windows.Forms.Button();
            this.btn_sekreter_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hasta_giris
            // 
            this.btn_hasta_giris.BackColor = System.Drawing.Color.White;
            this.btn_hasta_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hasta_giris.BackgroundImage")));
            this.btn_hasta_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hasta_giris.Location = new System.Drawing.Point(40, 128);
            this.btn_hasta_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hasta_giris.Name = "btn_hasta_giris";
            this.btn_hasta_giris.Size = new System.Drawing.Size(184, 137);
            this.btn_hasta_giris.TabIndex = 0;
            this.btn_hasta_giris.UseVisualStyleBackColor = false;
            this.btn_hasta_giris.Click += new System.EventHandler(this.btn_hasta_giris_Click);
            // 
            // btn_doktor_giris
            // 
            this.btn_doktor_giris.BackColor = System.Drawing.Color.White;
            this.btn_doktor_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor_giris.BackgroundImage")));
            this.btn_doktor_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doktor_giris.Location = new System.Drawing.Point(245, 128);
            this.btn_doktor_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doktor_giris.Name = "btn_doktor_giris";
            this.btn_doktor_giris.Size = new System.Drawing.Size(184, 137);
            this.btn_doktor_giris.TabIndex = 1;
            this.btn_doktor_giris.UseVisualStyleBackColor = false;
            this.btn_doktor_giris.Click += new System.EventHandler(this.btn_doktor_giris_Click);
            // 
            // btn_sekreter_giris
            // 
            this.btn_sekreter_giris.BackColor = System.Drawing.Color.White;
            this.btn_sekreter_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekreter_giris.BackgroundImage")));
            this.btn_sekreter_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sekreter_giris.Location = new System.Drawing.Point(451, 128);
            this.btn_sekreter_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sekreter_giris.Name = "btn_sekreter_giris";
            this.btn_sekreter_giris.Size = new System.Drawing.Size(184, 137);
            this.btn_sekreter_giris.TabIndex = 2;
            this.btn_sekreter_giris.UseVisualStyleBackColor = false;
            this.btn_sekreter_giris.Click += new System.EventHandler(this.btn_sekreter_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(278, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(489, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter Girişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(118, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "SAMURLU HASTANESİ";
            // 
            // Frm_Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(670, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekreter_giris);
            this.Controls.Add(this.btn_doktor_giris);
            this.Controls.Add(this.btn_hasta_giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Frm_Girisler";
            this.Text = "Giriş Sekmesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hasta_giris;
        private System.Windows.Forms.Button btn_doktor_giris;
        private System.Windows.Forms.Button btn_sekreter_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

