using BanHangSieuThi.Class;
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

namespace BanHangSieuThi
{
    public partial class Themhang : Form
    {
        public void showData()
        {
            //SqlConnection conn = Connection.Conn();
            string sql = "Select * from hanghoa";
            if (!string.IsNullOrWhiteSpace(txtTimkiem.Text)) sql = "Select * from hanghoa where ten like '%" + txtTimkiem.Text + "%'";
            var vv = Connection.getDataTable(sql);
            vv.Columns["ma"].ColumnName = "Mã Hàng Hóa";
            vv.Columns["mahienthi"].ColumnName = "Mã Hiển Thị";
            vv.Columns["ten"].ColumnName = "Tên Hàng Hóa";
            vv.Columns["soluongcon"].ColumnName = "Số Lượng";
            vv.Columns["loaihang"].ColumnName = "Loại Hàng";
            vv.Columns["gia"].ColumnName = "Giá";
            dtHanghoa.DataSource = vv;

        }
        private void load_dropdownlist()
        {
            int kt = new hanghoa_b().Load_DropDowList(cbb_loaihang, @"Select * from loaihanghoa where ma !='0'");
        }
        public void Clear()
        {
            txtMaHH.Clear();
            txtMaHT.Clear();
            txtTenHH.Clear();
            txtSL.Clear();
            cbb_loaihang.Text = null;
            txtGia.Clear();
            txtMaHH.Focus();
        }
        public Themhang()
        {
            InitializeComponent();
            load_dropdownlist();
        }

        private void bntclear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            try
            {
                string a = DateTime.Now.ToString("yymmddhhss");
                string b = txtMaHT.Text;
                string c = txtTenHH.Text;
                string d = txtSL.Text;
                string g = cbb_loaihang.SelectedValue.ToString();
                string h = txtGia.Text;
                string sql = @"Insert into hanghoa values( N'" + a + "' , N'" + b + "' ,N'" + c + "',N'" + d + "',N'" + g + "',N'" + h + "')";
                Connection.Excute(sql);
                //this.showData("Select * from hanghoa");
                
                this.Clear();
                MessageBox.Show("Thêm mới thành công!");
                showData();
            }

            catch
            {
                MessageBox.Show("Không thêm mới được!");
            }
        }

        private void showData(string p)
        {
            throw new NotImplementedException();
        }

        private void dtHanghoa_SelectionChanged(object sender, EventArgs e)
        {
            int chiso = dtHanghoa.CurrentRow.Index;
            txtMaHH.Text = dtHanghoa[0, chiso].Value.ToString();
            txtMaHT.Text = dtHanghoa[1, chiso].Value.ToString();
            txtTenHH.Text = dtHanghoa[2, chiso].Value.ToString();
            txtSL.Text = dtHanghoa[3, chiso].Value.ToString();
            cbb_loaihang.SelectedValue = dtHanghoa[4, chiso].Value.ToString();
            txtGia.Text = dtHanghoa[5, chiso].Value.ToString();
            txtMaHH.Enabled = false;
        }

        private void txtMaHT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTenHH.Focus();
        }

        private void txtTenHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSL.Focus();
        }

        private void txtSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbb_loaihang.Focus();
        }

        private void txtLoaiHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtGia.Focus();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
                //int chiso = dtHanghoa.CurrentRow.Index;
                string a = txtMaHT.Text;
                string b = txtTenHH.Text;
                string c = txtSL.Text;
                string d = cbb_loaihang.SelectedValue.ToString();
                string g = txtGia.Text;
                string sql = @"UPDATE [dbo].[hanghoa] SET [mahienthi] = N'" + a + "' ,  [ten] = N'" + b + "' , [soluongcon] = N'" + c + "' ,[loaihang] = N'" + d + "',gia = N'" + g + "'  where ma = '" + txtMaHH.Text + "' ";
                Connection.Excute(sql);
                this.showData();
                this.Clear();
                MessageBox.Show("Sửa thành công!");
            }

            catch
            {
                MessageBox.Show("Không sửa được!");
            }
        }

        private void Themhang_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                //int chiso = dtHanghoa.CurrentRow.Index;
                string sql = @"DELETE FROM [dbo].[hanghoa] WHERE  ma = '" + txtMaHH.Text + "' ";
                Connection.Excute(sql);
                this.showData();
                this.Clear();
                MessageBox.Show("Xóa thành công!");
            }

            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Themhang_Load(sender, e);
        }






       
    }
}
