namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_BilgiGuncelleHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BilgiGuncelleHasta));
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_KayitGuncelle_cinsiyet = new System.Windows.Forms.ComboBox();
            this.msk_KayitGuncelle_tel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KayitGuncelle_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KayitGuncelle_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_KayitGuncelle_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_KayitGuncelle_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(57, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(429, 50);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kayıt Güncelleme Ekranı";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(291, 417);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(109, 40);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cinsiyet: ";
            // 
            // cmb_KayitGuncelle_cinsiyet
            // 
            this.cmb_KayitGuncelle_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KayitGuncelle_cinsiyet.FormattingEnabled = true;
            this.cmb_KayitGuncelle_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_KayitGuncelle_cinsiyet.Location = new System.Drawing.Point(268, 284);
            this.cmb_KayitGuncelle_cinsiyet.Name = "cmb_KayitGuncelle_cinsiyet";
            this.cmb_KayitGuncelle_cinsiyet.Size = new System.Drawing.Size(156, 30);
            this.cmb_KayitGuncelle_cinsiyet.TabIndex = 4;
            // 
            // msk_KayitGuncelle_tel
            // 
            this.msk_KayitGuncelle_tel.Location = new System.Drawing.Point(268, 235);
            this.msk_KayitGuncelle_tel.Mask = "(999) 000-0000";
            this.msk_KayitGuncelle_tel.Name = "msk_KayitGuncelle_tel";
            this.msk_KayitGuncelle_tel.Size = new System.Drawing.Size(156, 30);
            this.msk_KayitGuncelle_tel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefon No: ";
            // 
            // txt_KayitGuncelle_soyad
            // 
            this.txt_KayitGuncelle_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_KayitGuncelle_soyad.Location = new System.Drawing.Point(268, 185);
            this.txt_KayitGuncelle_soyad.Name = "txt_KayitGuncelle_soyad";
            this.txt_KayitGuncelle_soyad.Size = new System.Drawing.Size(156, 30);
            this.txt_KayitGuncelle_soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Soyadınız: ";
            // 
            // txt_KayitGuncelle_ad
            // 
            this.txt_KayitGuncelle_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_KayitGuncelle_ad.Location = new System.Drawing.Point(268, 140);
            this.txt_KayitGuncelle_ad.Name = "txt_KayitGuncelle_ad";
            this.txt_KayitGuncelle_ad.Size = new System.Drawing.Size(156, 30);
            this.txt_KayitGuncelle_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Adınız: ";
            // 
            // msk_KayitGuncelle_tc
            // 
            this.msk_KayitGuncelle_tc.Location = new System.Drawing.Point(268, 331);
            this.msk_KayitGuncelle_tc.Mask = "00000000000";
            this.msk_KayitGuncelle_tc.Name = "msk_KayitGuncelle_tc";
            this.msk_KayitGuncelle_tc.ReadOnly = true;
            this.msk_KayitGuncelle_tc.Size = new System.Drawing.Size(156, 30);
            this.msk_KayitGuncelle_tc.TabIndex = 5;
            // 
            // txt_KayitGuncelle_sifre
            // 
            this.txt_KayitGuncelle_sifre.Location = new System.Drawing.Point(268, 375);
            this.txt_KayitGuncelle_sifre.Name = "txt_KayitGuncelle_sifre";
            this.txt_KayitGuncelle_sifre.Size = new System.Drawing.Size(156, 30);
            this.txt_KayitGuncelle_sifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Şifre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Kimlik No: ";
            // 
            // Frm_BilgiGuncelleHasta
            // 
            this.AcceptButton = this.btn_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(645, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_KayitGuncelle_cinsiyet);
            this.Controls.Add(this.msk_KayitGuncelle_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_KayitGuncelle_soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KayitGuncelle_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_KayitGuncelle_tc);
            this.Controls.Add(this.txt_KayitGuncelle_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_BilgiGuncelleHasta";
            this.Text = "Frm_BilgiDuzenle";
            this.Load += new System.EventHandler(this.Frm_BilgiGuncelleHasta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_KayitGuncelle_cinsiyet;
        private System.Windows.Forms.MaskedTextBox msk_KayitGuncelle_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KayitGuncelle_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KayitGuncelle_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_KayitGuncelle_tc;
        private System.Windows.Forms.TextBox txt_KayitGuncelle_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}