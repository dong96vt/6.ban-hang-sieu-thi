using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace BanHangSieuThi.Class
{
    class nhanvien_b
    {
        public string login(string user, string pass)
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

            SqlCommand cm = new SqlCommand("dbo.dangnhap", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@id", SqlDbType.VarChar).Value = user;
            cm.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            SqlParameter ma = new SqlParameter("@Result", SqlDbType.VarChar);
            ma.Direction = ParameterDirection.ReturnValue;
            cm.Parameters.Add(ma);
            cm.ExecuteNonQuery();
            conn.Close();
            return ma.Value.ToString();
        }
    }
}
