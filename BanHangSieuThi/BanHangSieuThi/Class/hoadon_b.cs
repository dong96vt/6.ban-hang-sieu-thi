using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi.Class
{
    class hoadon_b
    {
        public int insert(hoadon_o hd)
        {
            SqlConnection conn = Connection.Conn();
            string sql = @"INSERT INTO [dbo].[hoadon]
                                         ([ma]
                                        ,[mahienthi]
                                        ,[khachhangma]
                                        ,[nhanvienma]
                                        ,[ngayviet]
                                        ,[khuyenmai]
                                        ,[tonggia]) 
                         VALUES (@ma
                               , @mahienthi
                               , @khachhangma
                               , @nhanvienma
                               , @ngayviet
                               , @khuyenmai
                               , @tonggia )";
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.Add("@ma", SqlDbType.VarChar).Value = hd.ma;
            cm.Parameters.Add("@mahienthi", SqlDbType.NVarChar).Value = hd.mahienthi;
            cm.Parameters.Add("@khachhangma", SqlDbType.VarChar).Value = hd.khachhangma;
            cm.Parameters.Add("@nhanvienma", SqlDbType.VarChar).Value = hd.nhanvienma;
            cm.Parameters.Add("@khuyenmai", SqlDbType.Float).Value = hd.khuyenmai;
            cm.Parameters.Add("@tonggia", SqlDbType.Int).Value = hd.tonggia;
            cm.Parameters.Add("@ngayviet", SqlDbType.DateTime).Value = hd.ngayviet;
            try
            {
                cm.ExecuteNonQuery();
            }
            catch
            {
                return -2;
            }
            conn.Close();
            return 1;
        }
    }
}
