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
    public partial class Frm_HastaDetay : Form
    {
        public Frm_HastaDetay()
        {
            InitializeComponent();
        }

        public string tc;// diğer formdan erişebilmek için


        SQL_Baglanti bagla = new SQL_Baglanti();

        private void Frm_HastaDetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            ////////////////////////////////////////// LABEL'A AD SOYAD ÇEKME/////////////////////////////////

            SqlCommand komut = new SqlCommand("select Hasta_Ad , Hasta_Soyad from Tbl_Hastalar where Hasta_Tc=@p1", bagla.baglanti()); // *from hepsini getiri biz sadece istediğimizi getirsin istiyoruz
            komut.Parameters.AddWithValue("@p1",lbl_tc.Text);
            SqlDataReader dr= komut.ExecuteReader();

/*            while (dr.Read())  // if doğru mu değil mi diye bakıyor while verileri alıyor
              {
                  lbl_adsoyad.Text = dr[0] + " " + dr[1];
              }*/
              if (dr.Read())
              {
                  lbl_adsoyad.Text = dr[0] + " " + dr[1];  // dr[0] adı dr[1] soyadı alır
              }
       /*   dr.Read();
            lbl_adsoyad.Text = dr[0] + " " + dr[1];  // dr.read() okudu sonra yazdırdık         //bu 3 ü de çalışıyor
       */
            bagla.baglanti().Close();




            /////////////////////////////////////////// RANDEVU GEÇMİŞİ////////////////////////////////

            DataTable dt = new DataTable(); //  İlk olarak, DataTable adında bir veri tablosu oluşturuyoruz. DataTable, verileri saklamak ve işlemek için kullanabileceğiniz bir veri yapısıdır
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where Hasta_Tc="+tc,bagla.baglanti()); //data gride verileri aktarmak için olan command
            // data adapter da parametre kullanılmıyor  aynı satırda kullanılıyor
            da.Fill(dt); // SqlDataAdapter ile çekilen verileri DataTable içine doldurmak için Fill yöntemini kullanıyoruz. Bu, veritabanından verileri çeker ve DataTable'a yükler.
            dataGridView1.DataSource = dt; // datagridde bağlantı açıp kapatmaya gerek yok



            //////////////////////////////////////// BRANŞLARI ÇEKME //////////////////////////////////////
            SqlCommand komut2 = new SqlCommand("select Brans_Ad  from Tbl_Branslar",bagla.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }

            bagla.baglanti() .Close();
        }

        ////////////////////////////////  CMB YE DOKTOR ÇEKME  /////////////////////////////////////////////////////////////
        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select Doktor_Ad , Doktor_Soyad from Tbl_Doktorlar where Doktor_Brans=@p1",bagla.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            bagla.baglanti().Close();
        }






        ////////////////////////////////  DATAGRID E RANDEVU GETİRME /////////////////////////////////////////////////////////////

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // datagrid wiev e aktaracağımız için
            SqlDataAdapter da = new SqlDataAdapter("select * From Tbl_Randevular where Randevu_Brans='"+cmb_brans.Text+"' and Randevu_Doktor='"+cmb_doktor.Text+"' and Randevu_Doluluk='False'",bagla.baglanti()); //her şeyi istediğimiz için *from kullandık 
            //sql de string ifadeye tek tırnak ile sorgu yapılır
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        public string ad_guncel, soyad_guncel;

        ////////////////////////////////  TXTID ye RANDEVU ID ATAMA  /////////////////////////////////////////////////////////////
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_Id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        ////////////////////////////////  RANDEVU ALMA /////////////////////////////////////////////////////////////
        private void btn_randevuAl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                SqlCommand sqlCommand = new SqlCommand("Update Tbl_Randevular set Randevu_Doluluk='True', Hasta_Tc=@p1 ,Hasta_Sikayet=@p2 where Randevu_Id=@p3", bagla.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", lbl_tc.Text);
                sqlCommand.Parameters.AddWithValue("@p2", rtxt_sikayet.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txt_Id.Text);
                sqlCommand.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Randevu alındı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir randevu seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        ////////////////////////////////  MAKSİMUM KARAKTER HESAPLAMA  /////////////////////////////////////////////////////////////
        private void rtxt_sikayet_TextChanged(object sender, EventArgs e)
        {
            string metin = rtxt_sikayet.Text;
            int maxKarakter = 250;
            int mevcutKarakter = metin.Length;
            int kalanKarakter = maxKarakter - mevcutKarakter;


            if (kalanKarakter < 0)
            {
                // Eklenmeye çalışan metni kesip sadece ilk 250 karakteri alın
                rtxt_sikayet.Text = metin.Substring(0, maxKarakter);
                //    MessageBox.Show("Maksimum karakter sayısını aştınız.");
                lbl_karakter.ForeColor = Color.Red;
                lbl_karakter.Text = "Maksimum 250 karakter sınırını aştınız!";
            }
            else
            {
                lbl_karakter.ForeColor = Color.Black;
                lbl_karakter.Text = "Kalan Karakter Sayısı : " + kalanKarakter;
            }
        }


        ////////////////////////////////  Link label  /////////////////////////////////////////////////////////////
        private void lnk_bilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_BilgiGuncelleHasta frm = new Frm_BilgiGuncelleHasta();
            frm.tc_no = tc;
            frm.ShowDialog();

            SqlCommand komut = new SqlCommand("select Hasta_Ad , Hasta_Soyad from Tbl_Hastalar where Hasta_Tc=@p1", bagla.baglanti()); // *from hepsini getiri biz sadece istediğimizi getirsin istiyoruz
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];  // dr[0] adı dr[1] soyadı alır
            }
        }
    }
}





/* BAŞKA BİR YOL
 *  DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuBrans LIKE @randevuBrans", baglaniyorum.baglanti());

            da.SelectCommand.Parameters.AddWithValue("@randevuBrans", "%" + cmbBrans.Text + "%");

            da.Fill(dt);

*/