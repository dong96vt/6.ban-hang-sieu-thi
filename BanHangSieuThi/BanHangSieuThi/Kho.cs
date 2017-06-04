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
    public partial class Kho : Form
    {
        int a;

        public Kho()
        {
            InitializeComponent();
        }
        public void showData()
        {
            //SqlConnection conn = Connection.Conn();
            var vv = Connection.getDataTable("Select * from hanghoa");
            vv.Columns["ma"].ColumnName = "Mã Hàng Hóa";
            vv.Columns["mahienthi"].ColumnName = "Mã Hiển Thị";
            vv.Columns["ten"].ColumnName = "Tên Hàng Hóa";
            vv.Columns["soluongcon"].ColumnName = "Số Lượng";
            vv.Columns["loaihang"].ColumnName = "Loại Hàng";
            vv.Columns["gia"].ColumnName = "Giá";
            dgv_hanghoa.DataSource = vv;

        }

        private void Kho_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string s = "Select * from hanghoa where ten like '%" + txt_khoatk.Text + "%'";
            var vv = Connection.getDataTable(s);
            dgv_hanghoa.DataSource = vv;
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {

            try
            {
                int.TryParse(txt_soluong.Text, out a);
                string s = "update hanghoa set soluongcon = soluongcon +" + a + " where ma='" + dgv_hanghoa.CurrentRow.Cells[0].Value.ToString() + "'";
                Connection.getDataTable(s);
                MessageBox.Show("Cập nhật số lượng thành công!");
                showData();
            }
            catch
            {
                MessageBox.Show("Phải là số");
            }

        }

        private void btn_themhang_Click(object sender, EventArgs e)
        {
            (new Themhang()).ShowDialog();
            showData();
        }
    }
}
