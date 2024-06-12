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
    public partial class Frm_Duyurular : Form
    {
        public Frm_Duyurular()
        {
            InitializeComponent();
        }
        SQL_Baglanti bagla = new SQL_Baglanti();
        private void Frm_Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Duyurular",bagla.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            bagla.baglanti().Close();
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
