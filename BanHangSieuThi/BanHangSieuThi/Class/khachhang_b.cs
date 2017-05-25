using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi.Class
{
    class khachhang_b
    {
        public int insert(khachhang_o kh)
        {
            SqlConnection conn = Connection.Conn();
            string sql = @"INSERT INTO [dbo].[khachhang]
                                       ([ma]
                                       ,[mahienthi]
                                       ,[hoten]
                                       ,[diachi]
                                       ,[gioitinh]
                                       
                                       ,[cmtnd]
                                       ,[sdt])
                                 VALUES
                                       (@ma
                                       ,@mahienthi
                                       ,@hoten
                                       ,@diachi
                                       ,@gioitinh
                                       
                                       ,@cmtnd
                                       ,@sdt)";
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.Add("@ma", SqlDbType.VarChar).Value = kh.ma;
            cm.Parameters.Add("@mahienthi", SqlDbType.NVarChar).Value = kh.mahienthi;
            cm.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = kh.hoten;
            cm.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh.diachi;
            cm.Parameters.Add("@cmtnd", SqlDbType.VarChar).Value = kh.cmtnd;
            cm.Parameters.Add("@gioitinh", SqlDbType.Int).Value = kh.gioitinh;
            //cm.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = null;
            cm.Parameters.Add("@sdt", SqlDbType.VarChar).Value = kh.sdt;
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
        public int Load_DropDowList(ComboBox cbb)
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from khachhang where ma != 'KHNULL'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close(); 
            cbb.DataSource = dt;
            cbb.DisplayMember ="hoten";
            cbb.ValueMember = "ma";
            return 1;
        }
        public khachhang_o oject4ComboBox(string ma)
        {
            SqlConnection conn = Connection.Conn();
            khachhang_o kh = new khachhang_o();

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from khachhang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["ma"].ToString() == ma)
                {
                    kh.hoten = dr["hoten"].ToString();
                    kh.diachi = dr["diachi"].ToString();
                    kh.sdt = dr["sdt"].ToString();
                    kh.cmtnd = dr["cmtnd"].ToString();
                    kh.gioitinh = Convert.ToInt32(dr["gioitinh"].ToString());
                }    
            }
            return kh;
        }
    }
}
