using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Proje
{
    class baglanti
    {
        
        public SqlConnection baglan()
        {
            SqlConnection yeni = new SqlConnection();
            yeni.ConnectionString = "Data Source=127.0.0.1\\CEMRE;Integrated Security=SSPI;Initial Catalog=KAYITISLEMLERI";//baglanılacak veritabanı belirlendi.
            yeni.Open();
            return yeni;
        }
     
    }
}
