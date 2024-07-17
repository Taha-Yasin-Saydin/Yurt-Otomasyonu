using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//namespace Yurt_Sistemi
//{
//    public class Sqlbaglanti
//    {
//        public SqlConnection baglanti()
//        {
//            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-RS9MSH0;Initial Catalog=yurt_vt;Integrated Security=True");
//            // Bağlantıyı sadece oluştur, açma
//            return baglan;
//        }
//    }
//}




//using System.Data.SqlClient;
//
namespace Yurt_Sistemi
{
    public class Sqlbaglanti
    {
        public SqlConnection baglanti()
        {
           SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-RS9MSH0;Initial Catalog=yurt_vt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}