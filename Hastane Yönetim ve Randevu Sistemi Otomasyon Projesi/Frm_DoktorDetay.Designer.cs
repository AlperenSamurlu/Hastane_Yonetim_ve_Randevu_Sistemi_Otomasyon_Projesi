namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_DoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnk_bilgiGuncelle = new System.Windows.Forms.LinkLabel();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rch_sikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.btn_duyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lnk_bilgiGuncelle);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lnk_bilgiGuncelle
            // 
            this.lnk_bilgiGuncelle.AutoSize = true;
            this.lnk_bilgiGuncelle.Location = new System.Drawing.Point(32, 126);
            this.lnk_bilgiGuncelle.Name = "lnk_bilgiGuncelle";
            this.lnk_bilgiGuncelle.Size = new System.Drawing.Size(284, 23);
            this.lnk_bilgiGuncelle.TabIndex = 17;
            this.lnk_bilgiGuncelle.TabStop = true;
            this.lnk_bilgiGuncelle.Text = "Bilgilerinizi Güncellemek için Basınız";
            this.lnk_bilgiGuncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_bilgiGuncelle_LinkClicked);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(199, 42);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(76, 23);
            this.lbl_tc.TabIndex = 15;
            this.lbl_tc.Text = "Null Null";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(199, 82);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(76, 23);
            this.lbl_adsoyad.TabIndex = 14;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "TC Kimlik No: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adınız Soyadınız: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.rch_sikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 306);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rch_sikayet
            // 
            this.rch_sikayet.Enabled = false;
            this.rch_sikayet.Location = new System.Drawing.Point(20, 38);
            this.rch_sikayet.Name = "rch_sikayet";
            this.rch_sikayet.Size = new System.Drawing.Size(388, 228);
            this.rch_sikayet.TabIndex = 1;
            this.rch_sikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(476, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1104, 608);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.btn_cıkıs);
            this.groupBox4.Controls.Add(this.btn_duyuru);
            this.groupBox4.Location = new System.Drawing.Point(12, 528);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 102);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(226, 35);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(154, 41);
            this.btn_cıkıs.TabIndex = 1;
            this.btn_cıkıs.Text = "Çıkış";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // btn_duyuru
            // 
            this.btn_duyuru.Location = new System.Drawing.Point(43, 35);
            this.btn_duyuru.Name = "btn_duyuru";
            this.btn_duyuru.Size = new System.Drawing.Size(154, 41);
            this.btn_duyuru.TabIndex = 0;
            this.btn_duyuru.Text = "Duyurular";
            this.btn_duyuru.UseVisualStyleBackColor = true;
            this.btn_duyuru.Click += new System.EventHandler(this.btn_duyuru_Click);
            // 
            // Frm_DoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1592, 703);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_DoktorDetay";
            this.Text = "Doktor Randevu Sayfası";
            this.Load += new System.EventHandler(this.Frm_DoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.Button btn_duyuru;
        private System.Windows.Forms.LinkLabel lnk_bilgiGuncelle;
        private System.Windows.Forms.RichTextBox rch_sikayet;
    }
}