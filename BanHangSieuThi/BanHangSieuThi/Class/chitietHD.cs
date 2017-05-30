using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi.Class
{
    public class GioHang
    {
        public string masanpham;
        public string soluong;
        public string tensp;
        public string gia;
    }
    public class chitietHD
    {
        public string mahoadon;
        public string manhanvien;
        public DateTime ngayviet;
        public string hoten_kh;
        public string diachi_kh;
        public string tien;
        public List<GioHang> giohang;
    }
}
