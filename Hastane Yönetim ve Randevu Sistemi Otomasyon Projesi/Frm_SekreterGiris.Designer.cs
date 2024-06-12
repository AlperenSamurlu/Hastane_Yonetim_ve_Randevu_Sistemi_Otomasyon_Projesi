namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_SekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SekreterGiris));
            this.button_sifreGoster = new System.Windows.Forms.Button();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sifreGoster
            // 
            this.button_sifreGoster.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sifreGoster.Location = new System.Drawing.Point(399, 180);
            this.button_sifreGoster.Name = "button_sifreGoster";
            this.button_sifreGoster.Size = new System.Drawing.Size(104, 36);
            this.button_sifreGoster.TabIndex = 4;
            this.button_sifreGoster.Text = "Şifremi Göster";
            this.button_sifreGoster.UseVisualStyleBackColor = true;
            this.button_sifreGoster.Click += new System.EventHandler(this.button_sifreGoster_Click);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Location = new System.Drawing.Point(254, 222);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(125, 37);
            this.btn_girisYap.TabIndex = 3;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(237, 136);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(156, 30);
            this.msk_tc.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(237, 180);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(156, 30);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şifre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "TC Kimlik No: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 53);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // Frm_SekreterGiris
            // 
            this.AcceptButton = this.btn_girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(637, 334);
            this.Controls.Add(this.button_sifreGoster);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_SekreterGiris";
            this.Text = "Sekreter Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sifreGoster;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}