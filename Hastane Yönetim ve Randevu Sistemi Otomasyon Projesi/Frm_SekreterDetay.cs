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
    public partial class Frm_SekreterDetay : Form
    {
        public Frm_SekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        SQL_Baglanti bagla=new SQL_Baglanti();


        private void Frm_SekreterDetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;

            ////////////////////////////////// LABEL A AD SOYAD ÇEKME  /////////////////////////////////////////////////////////
            SqlCommand komut1 = new SqlCommand("select Sekreter_AdSoyad From Tbl_Sekreter where Sekreter_Tc=@p1",bagla.baglanti());
            komut1.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr= komut1.ExecuteReader();
            if (dr.Read())
            {
                lbl_adsoyad.Text = dr[0].ToString();
            }
            bagla.baglanti().Close();

            ////////////////////////////////// CMB YE BRANŞ ÇEKME  //////////////////////////////////////////////////////////////

            SqlCommand komut2 = new SqlCommand("select Brans_Ad from Tbl_Branslar",bagla.baglanti());
            SqlDataReader dr2= komut2.ExecuteReader();
            while(dr2.Read()) // burada if koyarsak sadece 1 tane branş cmb ye eklenecektir
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bagla.baglanti().Close();

            

            ////////////////////////////////  BRANŞLARI DATA GRIDE AKTARMA //////////////////////////////////////////////////////
            
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Branslar",bagla.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.RowHeadersVisible = false; // datagriddeki en baştaki boş sütunu kaldırma

            ///////////////////////////////  DOKTORLARI DATAGRİDE AKTARMA  //////////////////////////////////////////////////////
            
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select Doktor_Id as Id ,(Doktor_Ad +' '+ Doktor_Soyad) as' Adı Soyadı ' , Doktor_Brans as ' Branşı ' from Tbl_Doktorlar",bagla.baglanti()); // as diyerek datagriddeki sütuna ad atayabiliyoruz 
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.RowHeadersVisible = false;
        }



        ////////////////////////////////  CMB YE DOKTOR ÇEKME  /////////////////////////////////////////////////////////////
        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut1 = new SqlCommand("select Doktor_Ad , Doktor_Soyad from Tbl_Doktorlar where Doktor_Brans=@p1", bagla.baglanti());
            komut1.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr1= komut1.ExecuteReader();
            while(dr1.Read())
            {
                cmb_doktor.Items.Add(dr1[0]+" " + dr1[1]);
            }
            bagla.baglanti().Close();
        }



        void temizle()
        {
            
            msk_tarih.Text = string.Empty;
            msk_saat.Text = string.Empty;
            cmb_doktor.Text = string.Empty;
            cmb_brans.SelectedIndex = -1;
        }


        //////////////////////////// BOŞ RANDEVU OLUŞTURMA (HASTA BURADAN OLUŞTURULMUŞ RANDEVULARI SEÇECEK  )  ///////////////////////////////////////////

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(msk_saat.Text) && !string.IsNullOrEmpty(msk_tarih.Text) && !string.IsNullOrEmpty(cmb_brans.Text) && !string.IsNullOrEmpty(cmb_doktor.Text))
            {
                SqlCommand komut1 = new SqlCommand("insert into Tbl_Randevular (Randevu_Tarih , Randevu_Saat , Randevu_Brans , Randevu_Doktor) values (@p1,@p2,@p3,@p4)", bagla.baglanti());
                komut1.Parameters.AddWithValue("@p1", msk_tarih.Text);
                komut1.Parameters.AddWithValue("@p2", msk_saat.Text);
                komut1.Parameters.AddWithValue("@p3", cmb_brans.Text);
                komut1.Parameters.AddWithValue("@p4", cmb_doktor.Text);
                komut1.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Randevu Oluşturuldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Lütfen randevu bilgilerini girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        ///////////////////////////////////////////////////  DUYURU OLUŞTURMA  ////////////////////////////////////////////////
       
        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rch_duyuru.Text))
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bagla.baglanti());
                komut.Parameters.AddWithValue("@p1", rch_duyuru.Text);
                komut.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Lütfen ilk önce duyuru metnini yazın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        /////////////////////////////////////////////  RİCHTEXTBOX KARAKTER HESAPLAMA  ///////////////////////////////////////////
        private void rch_duyuru_TextChanged(object sender, EventArgs e)
        {
            string metin = rch_duyuru.Text;
            int maxKarakter = 200;
            int mevcutKarakter=metin.Length;
            int kalanKarakter = maxKarakter - mevcutKarakter;
            

            if (kalanKarakter < 0)
            {
                // Eklenmeye çalışan metni kesip sadece ilk 200 karakteri alın
                rch_duyuru.Text = metin.Substring(0, maxKarakter);
                //    MessageBox.Show("Maksimum karakter sayısını aştınız.");
                lbl_karakter.ForeColor = Color.Red;
                lbl_karakter.Text = "Maksimum 200 karakter sınırını aştınız!";
            }
            else
            {
                lbl_karakter.ForeColor = Color.Black;
                lbl_karakter.Text = "Kalan Karakter Sayısı : " + kalanKarakter;
            }

        }

        /////////////////////////////////////////////  DOKTOR PANELİ AÇMA  ///////////////////////////////////////////
        private void btn_DoktorPaneli_Click(object sender, EventArgs e)
        {
            Frm_DoktorPaneli dpanel =new Frm_DoktorPaneli();
            dpanel.Show();
        }

        /////////////////////////////////////////////  BRANŞ PANELİ AÇMA  ///////////////////////////////////////////
        private void btn_BransPaneli_Click(object sender, EventArgs e)
        {
            Frm_BransPaneli frm_BransPaneli = new Frm_BransPaneli();
            frm_BransPaneli.Show();
        }

        /////////////////////////////////////////////  RANDEVU PANELİ AÇMA  ///////////////////////////////////////////

        private void btn_RandevuListe_Click(object sender, EventArgs e)
        {
            Frm_RandevuListesi randevuListesi=new Frm_RandevuListesi();
            randevuListesi.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular frm_Duyurular = new Frm_Duyurular();
            frm_Duyurular.Show();
        }

        
        /// /////////////////////////////////////  RANDEVU SİLER   ///////////////////////////////////////
        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                SqlCommand cmd = new SqlCommand("Delete Tbl_Randevular where Randevu_Id=@p1", bagla.baglanti());
                cmd.Parameters.AddWithValue("@p1", txt_id.Text);
                cmd.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Randevu Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen ID giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
