namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_hastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_hastaKayit));
            this.msk_hastaKayit_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_hastaKayit_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hastaKayit_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hastaKayit_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_hastaKayit_tel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_hastaKayit_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kayitYap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msk_hastaKayit_tc
            // 
            this.msk_hastaKayit_tc.Location = new System.Drawing.Point(180, 290);
            this.msk_hastaKayit_tc.Mask = "00000000000";
            this.msk_hastaKayit_tc.Name = "msk_hastaKayit_tc";
            this.msk_hastaKayit_tc.Size = new System.Drawing.Size(156, 30);
            this.msk_hastaKayit_tc.TabIndex = 5;
            // 
            // txt_hastaKayit_sifre
            // 
            this.txt_hastaKayit_sifre.Location = new System.Drawing.Point(180, 329);
            this.txt_hastaKayit_sifre.Name = "txt_hastaKayit_sifre";
            this.txt_hastaKayit_sifre.Size = new System.Drawing.Size(156, 30);
            this.txt_hastaKayit_sifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No: ";
            // 
            // txt_hastaKayit_ad
            // 
            this.txt_hastaKayit_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_hastaKayit_ad.Location = new System.Drawing.Point(180, 123);
            this.txt_hastaKayit_ad.Name = "txt_hastaKayit_ad";
            this.txt_hastaKayit_ad.Size = new System.Drawing.Size(156, 30);
            this.txt_hastaKayit_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adınız: ";
            // 
            // txt_hastaKayit_soyad
            // 
            this.txt_hastaKayit_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_hastaKayit_soyad.Location = new System.Drawing.Point(180, 162);
            this.txt_hastaKayit_soyad.Name = "txt_hastaKayit_soyad";
            this.txt_hastaKayit_soyad.Size = new System.Drawing.Size(156, 30);
            this.txt_hastaKayit_soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyadınız: ";
            // 
            // msk_hastaKayit_tel
            // 
            this.msk_hastaKayit_tel.Location = new System.Drawing.Point(180, 206);
            this.msk_hastaKayit_tel.Mask = "(999) 000-0000";
            this.msk_hastaKayit_tel.Name = "msk_hastaKayit_tel";
            this.msk_hastaKayit_tel.Size = new System.Drawing.Size(156, 30);
            this.msk_hastaKayit_tel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefon No: ";
            // 
            // cmb_hastaKayit_cinsiyet
            // 
            this.cmb_hastaKayit_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hastaKayit_cinsiyet.FormattingEnabled = true;
            this.cmb_hastaKayit_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_hastaKayit_cinsiyet.Location = new System.Drawing.Point(180, 249);
            this.cmb_hastaKayit_cinsiyet.Name = "cmb_hastaKayit_cinsiyet";
            this.cmb_hastaKayit_cinsiyet.Size = new System.Drawing.Size(156, 30);
            this.cmb_hastaKayit_cinsiyet.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cinsiyet: ";
            // 
            // btn_kayitYap
            // 
            this.btn_kayitYap.Location = new System.Drawing.Point(203, 369);
            this.btn_kayitYap.Name = "btn_kayitYap";
            this.btn_kayitYap.Size = new System.Drawing.Size(109, 40);
            this.btn_kayitYap.TabIndex = 7;
            this.btn_kayitYap.Text = "Kayıt Yap";
            this.btn_kayitYap.UseVisualStyleBackColor = true;
            this.btn_kayitYap.Click += new System.EventHandler(this.btn_kayitYap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 50);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hasta Kayıt Ekranı";
            // 
            // Frm_hastaKayit
            // 
            this.AcceptButton = this.btn_kayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(416, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_kayitYap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_hastaKayit_cinsiyet);
            this.Controls.Add(this.msk_hastaKayit_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_hastaKayit_soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hastaKayit_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_hastaKayit_tc);
            this.Controls.Add(this.txt_hastaKayit_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_hastaKayit";
            this.Text = "Kayıt Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_hastaKayit_tc;
        private System.Windows.Forms.TextBox txt_hastaKayit_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hastaKayit_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hastaKayit_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msk_hastaKayit_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_hastaKayit_cinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kayitYap;
        private System.Windows.Forms.Label label5;
    }
}