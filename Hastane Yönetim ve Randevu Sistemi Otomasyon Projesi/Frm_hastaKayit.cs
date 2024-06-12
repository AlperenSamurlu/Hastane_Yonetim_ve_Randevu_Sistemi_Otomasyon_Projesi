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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    public partial class Frm_hastaKayit : Form
    {
        public Frm_hastaKayit()
        {
            InitializeComponent();
        }


        void temizle()
        {
            txt_hastaKayit_ad.Text = string.Empty;
            txt_hastaKayit_soyad.Text = string.Empty;
            msk_hastaKayit_tc.Text = string.Empty;
            msk_hastaKayit_tel.Text = string.Empty;
            txt_hastaKayit_sifre.Text = string.Empty;
            cmb_hastaKayit_cinsiyet.SelectedIndex = -1;
        }



        SQL_Baglanti bagla = new SQL_Baglanti();

        private void btn_kayitYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_hastaKayit_ad.Text) && !string.IsNullOrEmpty(txt_hastaKayit_soyad.Text) && !string.IsNullOrEmpty(msk_hastaKayit_tc.Text) && !string.IsNullOrEmpty(msk_hastaKayit_tel.Text) && !string.IsNullOrEmpty(txt_hastaKayit_sifre.Text) && !string.IsNullOrEmpty(cmb_hastaKayit_cinsiyet.Text))
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (Hasta_Ad,Hasta_Soyad,Hasta_Tc,Hasta_Telefon,Hasta_Sifre,Hasta_Cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bagla.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_hastaKayit_ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_hastaKayit_soyad.Text);
                komut.Parameters.AddWithValue("@p3", msk_hastaKayit_tc.Text);
                komut.Parameters.AddWithValue("@p4", msk_hastaKayit_tel.Text);
                komut.Parameters.AddWithValue("@p5", txt_hastaKayit_sifre.Text);
                komut.Parameters.AddWithValue("@p6", cmb_hastaKayit_cinsiyet.Text);
                komut.ExecuteNonQuery();  //Sql formunu çalıştırıyor (listeyi güncellemek için)
                bagla.baglanti().Close();
                temizle();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur", "Kayıt Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

