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
    class hanghoa_b
    {
        public int select(DataGridView dgv, string table, string khoatk)
        {
            string selec_hanghoa;
            if (!String.IsNullOrEmpty(khoatk))
            {
                selec_hanghoa = "Select * from hanghoa where ten like '%'+@khoatk+'%'";
            }
            else selec_hanghoa = "Select * from hanghoa";
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
        public hanghoa_o oject4Row(DataRow dr)
        {
            if (dr == null) return null;
            hanghoa_o hh = new hanghoa_o();
            hh.ma = dr["ma"].ToString();
            hh.mahienthi = dr["mahienthi"].ToString();
            hh.ten = dr["ten"].ToString();
            hh.gia = dr["gia"].ToString();
            return hh;
        }
        public string check_kho(string ma, int soluong)
        {
            SqlConnection conn = Connection.Conn();
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối SQL");
            }

            SqlCommand cm = new SqlCommand("dbo.check_kho", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
            cm.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            SqlParameter kq = new SqlParameter("@Result", SqlDbType.Int);
            kq.Direction = ParameterDirection.ReturnValue;
            cm.Parameters.Add(kq);
            cm.ExecuteNonQuery();
            conn.Close();
            return kq.Value.ToString();
        }
    }
}
