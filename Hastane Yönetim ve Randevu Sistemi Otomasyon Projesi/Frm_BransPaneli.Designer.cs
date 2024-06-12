namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    partial class Frm_BransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BransPaneli));
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bransID = new System.Windows.Forms.TextBox();
            this.txt_bransAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(144, 225);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(106, 36);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(202, 183);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(97, 36);
            this.btn_Sil.TabIndex = 4;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 289);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(99, 183);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(97, 36);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Branş Id: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 74;
            this.label1.Text = "Branş Ad: ";
            // 
            // txt_bransID
            // 
            this.txt_bransID.Enabled = false;
            this.txt_bransID.Location = new System.Drawing.Point(130, 97);
            this.txt_bransID.Name = "txt_bransID";
            this.txt_bransID.Size = new System.Drawing.Size(158, 30);
            this.txt_bransID.TabIndex = 1;
            // 
            // txt_bransAd
            // 
            this.txt_bransAd.Location = new System.Drawing.Point(130, 137);
            this.txt_bransAd.Name = "txt_bransAd";
            this.txt_bransAd.Size = new System.Drawing.Size(158, 30);
            this.txt_bransAd.TabIndex = 2;
            // 
            // Frm_BransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(905, 381);
            this.Controls.Add(this.txt_bransAd);
            this.Controls.Add(this.txt_bransID);
            this.Controls.Add(this.label1);
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
            this.Name = "Frm_BransPaneli";
            this.Text = "Branş Sayfası";
            this.Load += new System.EventHandler(this.Frm_BransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bransID;
        private System.Windows.Forms.TextBox txt_bransAd;
    }
}