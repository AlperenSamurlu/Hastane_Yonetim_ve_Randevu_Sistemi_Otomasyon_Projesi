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
    public partial class Frm_DoktorDetay : Form
    {
        public Frm_DoktorDetay()
        {
            InitializeComponent();
        }

        public string tc;
        SQL_Baglanti bagla=new SQL_Baglanti();
        private void Frm_DoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;
            ////////////////////////////////// LABEL A AD SOYAD ÇEKME  /////////////////////////////////////////////////////////
            SqlCommand komut1 = new SqlCommand("select Doktor_Ad , Doktor_Soyad From Tbl_Doktorlar where Doktor_Tc=@p1", bagla.baglanti());
            komut1.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                lbl_adsoyad.Text = dr[0]+" " + dr[1];
            }
            bagla.baglanti().Close();



            /////////////////////////////////////////  RANDEVULAR  /////////////////////////////////////////////////////////
             DataTable dataTable    = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where Randevu_Doktor='"+lbl_adsoyad.Text+"' and Randevu_Doluluk='True'",bagla.baglanti());
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.RowHeadersVisible = false;
            bagla.baglanti().Close();


        }

        private void lnk_bilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_BilgiGuncelleDoktor bilgiGuncelleDoktor=new Frm_BilgiGuncelleDoktor();
            bilgiGuncelleDoktor.tc = lbl_tc.Text;
            bilgiGuncelleDoktor.Show();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            Frm_Duyurular frm_Duyurular = new Frm_Duyurular();
            frm_Duyurular.Show();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ///             Şikayeti TExtbox a alma
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            rch_sikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
