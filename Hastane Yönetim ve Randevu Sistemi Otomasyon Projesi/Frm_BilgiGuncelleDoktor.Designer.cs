namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_BilgiGuncelleDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BilgiGuncelleDoktor));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KayitGuncelle_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KayitGuncelle_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KayitGuncelle_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.msk_KayitGuncelle_tc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 50);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bilgi Güncelleme Ekranı";
            // 
            // txt_KayitGuncelle_sifre
            // 
            this.txt_KayitGuncelle_sifre.Location = new System.Drawing.Point(228, 277);
            this.txt_KayitGuncelle_sifre.Name = "txt_KayitGuncelle_sifre";
            this.txt_KayitGuncelle_sifre.Size = new System.Drawing.Size(173, 30);
            this.txt_KayitGuncelle_sifre.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Şifre: ";
            // 
            // txt_KayitGuncelle_soyad
            // 
            this.txt_KayitGuncelle_soyad.Location = new System.Drawing.Point(228, 147);
            this.txt_KayitGuncelle_soyad.Name = "txt_KayitGuncelle_soyad";
            this.txt_KayitGuncelle_soyad.Size = new System.Drawing.Size(173, 30);
            this.txt_KayitGuncelle_soyad.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Soyadınız: ";
            // 
            // txt_KayitGuncelle_ad
            // 
            this.txt_KayitGuncelle_ad.Location = new System.Drawing.Point(228, 102);
            this.txt_KayitGuncelle_ad.Name = "txt_KayitGuncelle_ad";
            this.txt_KayitGuncelle_ad.Size = new System.Drawing.Size(173, 30);
            this.txt_KayitGuncelle_ad.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Adınız: ";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(250, 319);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(109, 40);
            this.btn_guncelle.TabIndex = 52;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // msk_KayitGuncelle_tc
            // 
            this.msk_KayitGuncelle_tc.Enabled = false;
            this.msk_KayitGuncelle_tc.Location = new System.Drawing.Point(228, 192);
            this.msk_KayitGuncelle_tc.Mask = "00000000000";
            this.msk_KayitGuncelle_tc.Name = "msk_KayitGuncelle_tc";
            this.msk_KayitGuncelle_tc.Size = new System.Drawing.Size(173, 30);
            this.msk_KayitGuncelle_tc.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "TC Kimlik No: ";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(228, 234);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(173, 30);
            this.cmb_brans.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Branş: ";
            // 
            // Frm_BilgiGuncelleDoktor
            // 
            this.AcceptButton = this.btn_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(603, 476);
            this.Controls.Add(this.msk_KayitGuncelle_tc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_KayitGuncelle_soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KayitGuncelle_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_KayitGuncelle_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_BilgiGuncelleDoktor";
            this.Text = "Bilgi Güncelleme Sayfası";
            this.Load += new System.EventHandler(this.Frm_BilgiGuncelleDoktor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KayitGuncelle_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KayitGuncelle_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KayitGuncelle_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.MaskedTextBox msk_KayitGuncelle_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label2;
    }
}