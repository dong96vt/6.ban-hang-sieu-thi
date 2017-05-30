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
                                       ,[ngaysinh]
                                       ,[cmtnd]
                                       ,[sdt])
                                 VALUES
                                       (@ma
                                       ,@mahienthi
                                       ,@hoten
                                       ,@diachi
                                       ,@gioitinh
                                       ,@ngaysinh
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
            if (kh.ngaysinh == null) kh.ngaysinh = Convert.ToDateTime("1-1-0");
            cm.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = kh.ngaysinh;
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
        public int select(DataGridView dgv, string table, string khoatk)
        {
            string selec_hanghoa;
            if (!String.IsNullOrWhiteSpace(khoatk))
            {
                selec_hanghoa = "Select * from khachhang where hoten like '%'+@khoatk+'%' and ma != 'KHNULL'";
            }
            else selec_hanghoa = "Select * from khachhang where ma != 'KHNULL'";
            SqlConnection conn = Connection.Conn();
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            SqlCommand cm = new SqlCommand(selec_hanghoa, conn);
            cm.Parameters.Add("@khoatk", SqlDbType.NVarChar).SqlValue = khoatk;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            conn.Close();
            try
            {
                da.Fill(ds, table);
            }
            catch
            {
                return -2;
            }
            dgv.DataSource = ds.Tables[table].DefaultView;
            dgv.Refresh();
            return 1;
        }
        public int delete(string ma)
        {
            SqlConnection conn = Connection.Conn();
            string sql = @"DELETE FROM [dbo].[khachhang] WHERE ma = @ma";
            try
            {
                conn.Open();
            }
            catch
            {
                return -1;
            }
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
            
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
        public int Update(khachhang_o kh)
        {
            SqlConnection conn = Connection.Conn();
            string sql = @"UPDATE [dbo].[khachhang]
                                SET   [hoten] = @hoten
                                      ,[diachi] = @diachi
                                      ,[gioitinh] = @gioitinh
                                      ,[ngaysinh] = @ngaysinh
                                      ,[cmtnd] = @cmtnd
                                      ,[sdt] = @sdt
                                WHERE ma = @ma";
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
            cm.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = kh.hoten;
            cm.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = kh.diachi;
            cm.Parameters.Add("@cmtnd", SqlDbType.VarChar).Value = kh.cmtnd;
            cm.Parameters.Add("@gioitinh", SqlDbType.Int).Value = kh.gioitinh;
            if (kh.ngaysinh == null) kh.ngaysinh = Convert.ToDateTime("1-1-0");
            cm.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = kh.ngaysinh;
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
                    kh.ma = dr["ma"].ToString();
                    kh.mahienthi = dr["mahienthi"].ToString();
                    kh.ngaysinh = Convert.ToDateTime(dr["ngaysinh"]);
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
