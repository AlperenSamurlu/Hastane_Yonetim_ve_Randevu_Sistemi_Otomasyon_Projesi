using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    public partial class Frm_Girisler : Form
    {
        public Frm_Girisler()
        {
            InitializeComponent();
        }

        private void btn_hasta_giris_Click(object sender, EventArgs e)
        {
            Frm_HastaGiris frm_hg = new Frm_HastaGiris();
            frm_hg.Show();
            this.Hide();
        }

        private void btn_doktor_giris_Click(object sender, EventArgs e)
        {
            Frm_DoktorGiris frm_dg = new Frm_DoktorGiris();
            frm_dg.Show();
            this.Hide();
        }

        private void btn_sekreter_giris_Click(object sender, EventArgs e)
        {
            Frm_SekreterGiris frm_sg = new Frm_SekreterGiris();
            frm_sg.Show();
            this.Hide();
        }
    }
} // Auto size ı böyle ayarla "GrowAndShrink"
