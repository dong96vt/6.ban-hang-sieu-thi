using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangSieuThi.Class;

namespace BanHangSieuThi
{
    public partial class frm_InHD : Form
    {
        public frm_InHD(chitietHD hd)
        { 
            InitializeComponent();
            lb_manv.Text = hd.manhanvien;
            lb_mahd.Text = hd.mahoadon;
            lb_hoten.Text = hd.hoten_kh;
            lb_diachi.Text = hd.diachi_kh;
            lb_thoigian.Text = hd.ngayviet.ToString();
            ShowList_sp(hd.giohang);
            showTien(hd.tien);
            lb_tchu.Text = ReadNumber.ByWords(decimal.Parse(lb_gia.Text));

        }
        private void ShowList_sp(List<GioHang> giohang)
        {
            int i=0;
            foreach(var gh in giohang)
            {
                i++;
                ListViewItem item = new ListViewItem();
                item.Text = gh.tensp;
                item.SubItems.Add(gh.gia);
                item.SubItems.Add(gh.soluong);
                item.SubItems.Add(i.ToString());
                lv_sanpham.Items.Add(item);
            }            
        }
        private void showTien(string tien)
        {
            string txt;
            txt = tien.Replace(",", "");
            tien = "";
            int n = txt.Length;
            int dem = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (dem == 2 && i != 0)
                {
                    tien = "." + txt.Substring(i, 1) + tien;
                    dem = 0;
                }
                else
                {
                    tien = txt.Substring(i, 1) + tien;
                    dem += 1;
                }
            }
            lb_gia.Text = tien;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
            this.Close();
        }
    }
}
