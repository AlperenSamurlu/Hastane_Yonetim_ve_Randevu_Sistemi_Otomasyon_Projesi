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
    public partial class Frm_BransPaneli : Form
    {
        public Frm_BransPaneli()
        {
            InitializeComponent();
        }

        SQL_Baglanti bagla = new SQL_Baglanti();
        private void Frm_BransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Tbl_Branslar",bagla.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            bagla.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_bransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_bransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_bransAd.Text))
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (Brans_Ad) values (@p1)",bagla.baglanti());
                komut.Parameters.AddWithValue("@p1",txt_bransAd.Text);
                komut.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Branş AD giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_bransID.Text))
            {
                SqlCommand komut = new SqlCommand("Delete Tbl_Branslar  where Brans_Id=@p1", bagla.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_bransID.Text);
                komut.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Branş ID giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_bransID.Text))
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Branslar set Brans_Ad=@p1 where Brans_Id=@p2", bagla.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_bransAd.Text);
                komut.Parameters.AddWithValue("@p2", txt_bransID.Text);
                komut.ExecuteNonQuery();
                bagla.baglanti().Close();
                MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Branş ID giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
