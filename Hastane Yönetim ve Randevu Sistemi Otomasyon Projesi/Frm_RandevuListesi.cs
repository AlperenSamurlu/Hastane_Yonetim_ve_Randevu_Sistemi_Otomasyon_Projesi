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
    public partial class Frm_RandevuListesi : Form
    {
        public Frm_RandevuListesi()
        {
            InitializeComponent();
        }
        
        SQL_Baglanti bagla = new SQL_Baglanti();
        private void Frm_RandevuListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da=new SqlDataAdapter("Select * from Tbl_Randevular",bagla.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            bagla.baglanti().Close();
        }
        
       
    }
}
