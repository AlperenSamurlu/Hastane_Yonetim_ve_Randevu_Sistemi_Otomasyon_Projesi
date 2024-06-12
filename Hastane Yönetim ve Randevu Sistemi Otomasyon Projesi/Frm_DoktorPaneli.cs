using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    public partial class Frm_DoktorPaneli : Form
    {
        public Frm_DoktorPaneli()
        {
            InitializeComponent();
        }

        SQL_Baglanti bagla = new SQL_Baglanti();
        private void Frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select *  from Tbl_Doktorlar", bagla.baglanti()); // as diyerek datagriddeki sütuna ad atayabiliyoruz 
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.RowHeadersVisible = false;
            bagla.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select Brans_Ad from Tbl_Branslar", bagla.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) // burada if koyarsak sadece 1 tane branş cmb ye eklenecektir
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bagla.baglanti().Close();


        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ad.Text) &&!string.IsNullOrEmpty(txt_soyad.Text) &&!string.IsNullOrEmpty(cmb_brans.Text) &&!string.IsNullOrEmpty(msktxt_tc.Text) &&!string.IsNullOrEmpty(txt_sifre.Text))
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Doktorlar (Doktor_Ad,Doktor_Soyad,Doktor_Brans,Doktor_Tc,Doktor_Sifre) values (@p1,@p2,@p3,@p4,@p5)", bagla.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", txt_ad.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txt_soyad.Text);
                sqlCommand.Parameters.AddWithValue("@p3", cmb_brans.Text);
                sqlCommand.Parameters.AddWithValue("@p4", msktxt_tc.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txt_sifre.Text);
                sqlCommand.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text    = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktxt_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msktxt_tc.Text))
            {
                SqlCommand sqlCommand = new SqlCommand("Delete Tbl_Doktorlar where Doktor_Tc=@p1", bagla.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", msktxt_tc.Text);
                sqlCommand.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Kayıt silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msktxt_tc.Text))
            {
                SqlCommand sqlCommand = new SqlCommand("Update Tbl_Doktorlar set Doktor_Ad=@p1,Doktor_Soyad=@p2,Doktor_Brans=@p3,Doktor_Tc=@p4,Doktor_Sifre=@p5 where Doktor_Tc=@p6",bagla.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", txt_ad.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txt_soyad.Text);
                sqlCommand.Parameters.AddWithValue("@p3", cmb_brans.Text);
                sqlCommand.Parameters.AddWithValue("@p4", msktxt_tc.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txt_sifre.Text);
                sqlCommand.Parameters.AddWithValue("@p6", msktxt_tc.Text);
                sqlCommand.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Doktor Bilgisi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen TC alanını doldurunuz!");
            }
        }
    }
}
