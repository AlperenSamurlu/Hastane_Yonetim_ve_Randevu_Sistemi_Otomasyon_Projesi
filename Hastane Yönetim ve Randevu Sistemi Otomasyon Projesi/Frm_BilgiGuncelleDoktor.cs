using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    public partial class Frm_BilgiGuncelleDoktor : Form
    {
        public Frm_BilgiGuncelleDoktor()
        {
            InitializeComponent();
        }
        SQL_Baglanti bagla = new SQL_Baglanti();
        public string tc;
        private void Frm_BilgiGuncelleDoktor_Load(object sender, EventArgs e)
        {
            cmb_brans.Items.Clear();  // CMB deki branş bilgilerini siler

            ///////////////////////////////////// DOKTOR BİLGİLERİNİ YAZMA   //////////////////////////////////////////
            msk_KayitGuncelle_tc.Text = tc;
            SqlCommand sqlCommand = new SqlCommand("select * from Tbl_Doktorlar where Doktor_Tc=@p1",bagla.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr1 = sqlCommand.ExecuteReader();
            if(dr1.Read())
            {
                txt_KayitGuncelle_ad.Text = dr1[1].ToString();
                txt_KayitGuncelle_soyad.Text = dr1[2].ToString();
                cmb_brans.Text = dr1[3].ToString();
                txt_KayitGuncelle_sifre.Text = dr1[5].ToString();
                
            }
            bagla.baglanti().Close();

            //////////////////////////////////////////   CMB ye BRANŞ EKLEME  //////////////////////////////////
            
            SqlCommand komut2 = new SqlCommand("select Brans_Ad from Tbl_Branslar", bagla.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) // burada if koyarsak sadece 1 tane branş cmb ye eklenecektir
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bagla.baglanti().Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_KayitGuncelle_ad.Text) &&!string.IsNullOrEmpty(txt_KayitGuncelle_soyad.Text) && !string.IsNullOrEmpty(cmb_brans.Text) && !string.IsNullOrEmpty(txt_KayitGuncelle_sifre.Text))
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set Doktor_Ad=@p1 , Doktor_Soyad=@p2 , Doktor_Brans=@p3 , Doktor_Sifre=@p4  where Doktor_Tc=@p5", bagla.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_KayitGuncelle_ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_KayitGuncelle_soyad.Text);
                komut.Parameters.AddWithValue("@p3", cmb_brans.Text);
                komut.Parameters.AddWithValue("@p4", txt_KayitGuncelle_sifre.Text);
                komut.Parameters.AddWithValue("@p5", msk_KayitGuncelle_tc.Text);
                komut.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Bilgileriniz Güncelllenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

               

        }
    }
}
