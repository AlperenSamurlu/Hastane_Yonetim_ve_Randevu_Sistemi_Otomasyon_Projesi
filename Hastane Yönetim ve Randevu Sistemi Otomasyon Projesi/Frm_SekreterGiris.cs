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
    public partial class Frm_SekreterGiris : Form
    {
        public Frm_SekreterGiris()
        {
            InitializeComponent();
        }
        void temizle()
        {
            msk_tc.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        SQL_Baglanti bagla = new SQL_Baglanti();
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msk_tc.Text) && !string.IsNullOrEmpty(txt_sifre.Text))
            {
                SqlCommand komut1 = new SqlCommand("select * From Tbl_Sekreter where Sekreter_Tc=@p1 and Sekreter_Sifre=@p2", bagla.baglanti());
                komut1.Parameters.AddWithValue("@p1", msk_tc.Text);
                komut1.Parameters.AddWithValue("@p2", txt_sifre.Text);
                SqlDataReader dr = komut1.ExecuteReader();

                if (dr.Read())
                {
                    Frm_SekreterDetay frm = new Frm_SekreterDetay();
                    frm.tc = msk_tc.Text;
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
            if (txt_sifre.UseSystemPasswordChar == true)
            {
                txt_sifre.UseSystemPasswordChar = false;
                button_sifreGoster.Text = "Şifreyi Gizle";
            }
            else
            {
                txt_sifre.UseSystemPasswordChar = true;
                button_sifreGoster.Text = "Şifreyi Göster";
            }
        }
    }
}
