namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_HastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hasta_sifre = new System.Windows.Forms.TextBox();
            this.msk_hasta_tc = new System.Windows.Forms.MaskedTextBox();
            this.Lnk_uyeOl = new System.Windows.Forms.LinkLabel();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_sifreGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta  Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre: ";
            // 
            // txt_hasta_sifre
            // 
            this.txt_hasta_sifre.Location = new System.Drawing.Point(202, 136);
            this.txt_hasta_sifre.Name = "txt_hasta_sifre";
            this.txt_hasta_sifre.Size = new System.Drawing.Size(156, 30);
            this.txt_hasta_sifre.TabIndex = 2;
            this.txt_hasta_sifre.UseSystemPasswordChar = true;
            // 
            // msk_hasta_tc
            // 
            this.msk_hasta_tc.Location = new System.Drawing.Point(202, 99);
            this.msk_hasta_tc.Mask = "00000000000";
            this.msk_hasta_tc.Name = "msk_hasta_tc";
            this.msk_hasta_tc.Size = new System.Drawing.Size(156, 30);
            this.msk_hasta_tc.TabIndex = 1;
            // 
            // Lnk_uyeOl
            // 
            this.Lnk_uyeOl.AutoSize = true;
            this.Lnk_uyeOl.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lnk_uyeOl.Location = new System.Drawing.Point(261, 247);
            this.Lnk_uyeOl.Name = "Lnk_uyeOl";
            this.Lnk_uyeOl.Size = new System.Drawing.Size(54, 19);
            this.Lnk_uyeOl.TabIndex = 5;
            this.Lnk_uyeOl.TabStop = true;
            this.Lnk_uyeOl.Text = "Üye Ol";
            this.Lnk_uyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_uyeOl_LinkClicked);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Location = new System.Drawing.Point(219, 178);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(125, 37);
            this.btn_girisYap.TabIndex = 3;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hemen üye ol ->";
            // 
            // button_sifreGoster
            // 
            this.button_sifreGoster.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sifreGoster.Location = new System.Drawing.Point(364, 136);
            this.button_sifreGoster.Name = "button_sifreGoster";
            this.button_sifreGoster.Size = new System.Drawing.Size(104, 31);
            this.button_sifreGoster.TabIndex = 4;
            this.button_sifreGoster.Text = "Şifremi Göster";
            this.button_sifreGoster.UseVisualStyleBackColor = true;
            this.button_sifreGoster.Click += new System.EventHandler(this.button_sifreGoster_Click);
            // 
            // Frm_HastaGiris
            // 
            this.AcceptButton = this.btn_girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(534, 289);
            this.Controls.Add(this.button_sifreGoster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.Lnk_uyeOl);
            this.Controls.Add(this.msk_hasta_tc);
            this.Controls.Add(this.txt_hasta_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_HastaGiris";
            this.Text = "Hasta Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hasta_sifre;
        private System.Windows.Forms.MaskedTextBox msk_hasta_tc;
        private System.Windows.Forms.LinkLabel Lnk_uyeOl;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_sifreGoster;
    }
}