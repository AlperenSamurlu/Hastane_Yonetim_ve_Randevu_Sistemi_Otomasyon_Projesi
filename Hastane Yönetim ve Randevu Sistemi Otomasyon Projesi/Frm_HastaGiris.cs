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
    public partial class Frm_HastaGiris : Form
    {
        public Frm_HastaGiris()
        {
            InitializeComponent();
        }


        private void Lnk_uyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_hastaKayit fr_hk = new Frm_hastaKayit();
            fr_hk.Show();
            
        }

        void temizle()
        {
            msk_hasta_tc.Text = string.Empty;
            txt_hasta_sifre.Text = string.Empty; 
        }



        SQL_Baglanti bagla = new SQL_Baglanti();

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msk_hasta_tc.Text) && !string.IsNullOrEmpty(txt_hasta_sifre.Text))
            {
                SqlCommand komut = new SqlCommand("select * From Tbl_Hastalar where Hasta_Tc=@p1 and Hasta_Sifre=@p2", bagla.baglanti());
                komut.Parameters.AddWithValue("@p1", msk_hasta_tc.Text);
                komut.Parameters.AddWithValue("@p2", txt_hasta_sifre.Text);
                SqlDataReader rd= komut.ExecuteReader();
                
                if(rd.Read()) // if sadece doğru mu diye bakar o yüzden while yerine if kullanıyoruz
                {
                    Frm_HastaDetay frm =new Frm_HastaDetay();
                    frm.tc = msk_hasta_tc.Text;
                    frm.Show();
                    this.Hide();
                }

                else
                {
                    temizle();
                    MessageBox.Show("Tc kimlik no veya şifre hatalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bagla.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_sifreGoster_Click(object sender, EventArgs e)
        {
            if (txt_hasta_sifre.UseSystemPasswordChar == true)
            {
                txt_hasta_sifre.UseSystemPasswordChar = false;
                button_sifreGoster.Text = "Şifreyi Gizle";
            }
            else
            {
                txt_hasta_sifre.UseSystemPasswordChar = true;
                button_sifreGoster.Text = "Şifreyi Göster";
            }
        }
    }
}
