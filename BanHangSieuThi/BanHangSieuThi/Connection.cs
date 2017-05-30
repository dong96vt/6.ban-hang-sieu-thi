using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi
{
    class Connection
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlConnection Conn()
        {
           string connString = @"Data Source=SUPER\SQLEXPRESS ;Initial Catalog=TTN_banhangsieuthi ;Persist Security Info=True; User ID=detai6 ;Password=detai6 ";
           SqlConnection conn = new SqlConnection(connString);
           return conn;
        }
        public static DataTable getDataTable(string sql)
        {
            // tạo đối tượng trỏ tới dl trong database 
            cmd = new SqlCommand(sql, conn);
            // dtg để lưu dữ liệu lên database 
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            // tạo database để hiển thị dl
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cmd.Dispose();
            return table;
        }
        public static void Excute(string sql)
        {
            Conn();
            cmd = new SqlCommand(sql, conn);
            //gọi hàm để có thể thực hiện thao tác Delete Insert Update
            cmd.ExecuteNonQuery();

        }
       
    }
}
