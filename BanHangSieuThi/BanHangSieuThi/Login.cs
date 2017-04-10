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

namespace BanHangSieuThi
{
    public partial class frm_login : Form
    {
        SqlConnection conn = Connection.Conn();
        public frm_login()
        {
            InitializeComponent();
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối SQL");
            }
            string func_login="select dbo.dangnhap("+txt_pass.Text+","+txt_user.Text+")";
            SqlCommand cm = new SqlCommand("dbo.dangnhap", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@id", SqlDbType.VarChar).Value = txt_user.Text;
            cm.Parameters.Add("@pass", SqlDbType.VarChar).Value = txt_pass.Text;
            SqlParameter ma = new SqlParameter("@Result", SqlDbType.VarChar);
            ma.Direction = ParameterDirection.ReturnValue;
            cm.Parameters.Add(ma);
            cm.ExecuteNonQuery();
            conn.Close();
            switch(ma.Value.ToString())
            {
                case "-1":
                    {
                        MessageBox.Show("Nhập sai mật khẩu, mời nhập lại !");
                        break;
                    }
                case "-2":
                    {
                        MessageBox.Show("Nhập sai tên đăng nhập, mời nhập lại !");
                        break;
                    }
                default:
                    {
                        string manhanvien = ma.Value.ToString();
                        Menu f = new Menu();
                        f.ShowDialog();
                        this.Close();
                        break;
                    }
            }    
        }

    }
}
