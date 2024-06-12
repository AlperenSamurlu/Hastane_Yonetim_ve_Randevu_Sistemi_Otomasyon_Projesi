using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Yönetim_ve_Randevu_Sistemi_Otomasyon_Projesi
{
    internal class SQL_Baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-EABSTBN;Initial Catalog=\"Hastane Proje\";Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
// Proje kısmına gel data source eklede ve adresi al
// adres:  Data Source=DESKTOP-EABSTBN;Initial Catalog="Hastane Proje";Integrated Security=True