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
//public class Ini
//{
//    private string path;
//    [DllImport("kernel32")]
//    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
//    [DllImport("kernel32")]
//    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
//    private Ini() { }
//    public Ini(string path_ini) { path = path_ini; }
//    public string ReadValue(string Section, string Key)
//    {
//        StringBuilder temp = new StringBuilder(255);
//        int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
//        return temp.ToString();
//    }
//    public void WriteValue(string Section, string Key, string Value)
//    {
//        WritePrivateProfileString(Section, Key, Value, this.path);
//    }
//}

