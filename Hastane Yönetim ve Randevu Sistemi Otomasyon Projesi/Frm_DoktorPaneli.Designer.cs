namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorPaneli));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktxt_tc = new System.Windows.Forms.MaskedTextBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Branş: ";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(112, 391);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(97, 36);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 564);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(215, 391);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(97, 36);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(157, 433);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(106, 36);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(140, 195);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(156, 30);
            this.txt_soyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Soyad: ";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(140, 148);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(156, 30);
            this.txt_ad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "TC: ";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(140, 289);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(156, 30);
            this.txt_sifre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Şifre: ";
            // 
            // msktxt_tc
            // 
            this.msktxt_tc.Location = new System.Drawing.Point(140, 239);
            this.msktxt_tc.Mask = "00000000000";
            this.msktxt_tc.Name = "msktxt_tc";
            this.msktxt_tc.Size = new System.Drawing.Size(156, 30);
            this.msktxt_tc.TabIndex = 4;
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(140, 344);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(156, 30);
            this.cmb_brans.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "UYARI: TC GÜNCELLENEMEZ!!!";
            // 
            // Frm_DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1506, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.msktxt_tc);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_DoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.Frm_DoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktxt_tc;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label1;
    }
}