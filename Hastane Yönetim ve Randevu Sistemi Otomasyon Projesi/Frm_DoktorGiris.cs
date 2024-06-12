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
    public partial class Frm_DoktorGiris : Form
    {
        public Frm_DoktorGiris()
        {
            InitializeComponent();
        }


        SQL_Baglanti bagla = new SQL_Baglanti();

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msk_tc.Text) && !string.IsNullOrEmpty(txt_sifre.Text))
            {
                SqlCommand komut1 = new SqlCommand("select * From Tbl_Doktorlar where Doktor_Tc=@p1 and Doktor_Sifre=@p2", bagla.baglanti());
                komut1.Parameters.AddWithValue("@p1", msk_tc.Text);
                komut1.Parameters.AddWithValue("@p2", txt_sifre.Text);
                SqlDataReader dr = komut1.ExecuteReader();

                if (dr.Read())
                {
                    Frm_DoktorDetay frm = new Frm_DoktorDetay();
                    frm.tc = msk_tc.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                   
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
