using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class Huongdan : Form
    {
        public Huongdan()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênThêmSửaXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Nhan Vien.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Khach Hang.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Ban Hang.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\HDSD.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void thêmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Them Hang.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void kiểmTraKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Kiem Tra Kho.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void tìmKiếmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Tim Hang.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }
    }
}
