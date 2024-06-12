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
    public partial class Frm_BilgiGuncelleHasta : Form
    {
        public Frm_BilgiGuncelleHasta()
        {
            InitializeComponent();
        }

        public string tc_no,Id;

        SQL_Baglanti bagla = new SQL_Baglanti();

        
       
        /// //////////////////////////////  BOŞLUKLARI OTOMATİK DOLDURUR  //////////////////////////////////////////////////
        
        private void Frm_BilgiGuncelleHasta_Load(object sender, EventArgs e)
        {
            msk_KayitGuncelle_tc.Text = tc_no;

            SqlCommand komut1 = new SqlCommand("select * from Tbl_Hastalar where Hasta_Tc=@p1",bagla.baglanti());
            komut1.Parameters.AddWithValue("@p1", tc_no);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                Id = dr1[0].ToString();
                txt_KayitGuncelle_ad.Text = dr1[1].ToString();
                txt_KayitGuncelle_soyad.Text = dr1[2].ToString();
                msk_KayitGuncelle_tc.Text = dr1[3].ToString();
                msk_KayitGuncelle_tel.Text = dr1[4].ToString();
                txt_KayitGuncelle_sifre.Text = dr1[5].ToString();
                cmb_KayitGuncelle_cinsiyet.Text = dr1[6].ToString();
            }
            bagla.baglanti().Close();
        }


        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_KayitGuncelle_ad.Text) && !string.IsNullOrEmpty(txt_KayitGuncelle_soyad.Text) && !string.IsNullOrEmpty(msk_KayitGuncelle_tc.Text) && !string.IsNullOrEmpty(msk_KayitGuncelle_tel.Text) && !string.IsNullOrEmpty(txt_KayitGuncelle_sifre.Text) && !string.IsNullOrEmpty(cmb_KayitGuncelle_cinsiyet.Text))
            {
                SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set Hasta_Ad=@p1 ,Hasta_Soyad=@p2 , Hasta_Telefon=@p4 ,Hasta_Sifre=@p5 , Hasta_Cinsiyet=@p6 where Hasta_Id=@p7", bagla.baglanti());
                komut2.Parameters.AddWithValue("@p7", Id);
                komut2.Parameters.AddWithValue("@p1", txt_KayitGuncelle_ad.Text);
                komut2.Parameters.AddWithValue("@p2", txt_KayitGuncelle_soyad.Text);
                //  komut2.Parameters.AddWithValue("@p3", msk_KayitGuncelle_tc.Text);
                komut2.Parameters.AddWithValue("@p4", msk_KayitGuncelle_tel.Text);
                komut2.Parameters.AddWithValue("@p5", txt_KayitGuncelle_sifre.Text);
                komut2.Parameters.AddWithValue("@p6", cmb_KayitGuncelle_cinsiyet.Text);
                komut2.ExecuteNonQuery(); // insert update delete de koyulur
                bagla.baglanti().Close();
                MessageBox.Show("Bilgileriniz Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
 
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
