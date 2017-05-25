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
using BanHangSieuThi.Class;

namespace BanHangSieuThi
{
    public partial class frm_login : Form
    {
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
            nhanvien_b b = new nhanvien_b();
            string manv = b.login(txt_user.Text, txt_pass.Text);
            switch(manv)
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
                case null:
                    { break; }
                default:
                    {
                        Menu f = new Menu(manv);
                        this.Visible = false;
                        f.ShowDialog();
                        this.Close();
                        break;
                    }
            }    
        }
    }
}
