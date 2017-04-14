using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi.Class
{
    class sanpham_b
    {
        public int insert_list(List<sanpham_o> ls)
        {
            SqlConnection conn = Connection.Conn();
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            foreach (sanpham_o sp in ls)
            {
                List<SqlParameter> li = new List<SqlParameter>();
                string sql = @"INSERT INTO [dbo].[sanpham]
                                           ([ma]
                                           ,[soluong]
                                           ,[hanghoama]
                                           ,[hoadonma]
                                           ,[mahienthi])
                                     VALUES (@ma
                                           ,@soluong
                                           ,@hanghoama
                                           ,@hoadonma
                                           ,@mahienthi)"; 
                
                try
                {
                    SqlCommand cm = new SqlCommand(sql, conn);
                    cm.Parameters.Add("@ma", SqlDbType.VarChar).Value = sp.ma;
                    cm.Parameters.Add("@mahienthi", SqlDbType.NVarChar).Value = sp.mahienthi;
                    cm.Parameters.Add("@soluong", SqlDbType.Int).Value = sp.soluong;
                    cm.Parameters.Add("@hanghoama", SqlDbType.VarChar).Value = sp.hanghoama;
                    cm.Parameters.Add("@hoadonma", SqlDbType.VarChar).Value = sp.hoadonma;
                    cm.ExecuteNonQuery();
                }
                catch
                {
                    return -2;
                }
            }
           
            conn.Close();
            return 1;
        }
    }
}
