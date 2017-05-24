using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi
{
    class Connection
    {
        public static SqlConnection Conn()
        {
           //string connString = @"Data Source=SUPER\SQLEXPRESS ;Initial Catalog=TTN_banhangsieuthi ;Persist Security Info=True; User ID=detai6 ;Password=detai6 ";
            string connString = @"Data Source = QUYETTHANG; Initial Catalog = Quanlybanhan1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
           return conn;
        }
       
    }
}
