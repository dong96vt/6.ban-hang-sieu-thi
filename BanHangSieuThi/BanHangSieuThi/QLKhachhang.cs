using BanHangSieuThi.Class;
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
    public partial class frm_quanlyKH : Form
    {
        public frm_quanlyKH()
        {
            InitializeComponent();
            initGrid(dgv_khachhang);
        }
        protected void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "mahienthi";
            cl.HeaderText = "MÃ";
            cl.Width = 90;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "hoten";
            cl.HeaderText = "HỌ TÊN";
            cl.Width = 145;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "sdt";
            cl.HeaderText = "SĐT";
            cl.Width = 90;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "diachi";
            cl.HeaderText = "ĐỊA CHỈ";
            cl.Width = 140;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "gioitinh";
            cl.HeaderText = "GIỚI TÍNH";
            cl.Width = 90;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ngaysinh";
            cl.HeaderText = "NGÀY SINH";
            cl.Width = 100;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "cmtnd";
            cl.HeaderText = "CMTND";
            cl.Width = 90;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ma";
            cl.Width = 0;
            dgv.Columns.Add(cl);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_hoten.Text) && !string.IsNullOrWhiteSpace(txt_sdt.Text) &&!string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                khachhang_o kh = new khachhang_o();
                kh.ma = DateTime.Now.ToString("yymmddhhss");
                kh.mahienthi = "KH " + kh.ma;
                kh.hoten = txt_hoten.Text;
                kh.ngaysinh = Convert.ToDateTime(dtp_ngaysinh.Text);
                kh.sdt = txt_sdt.Text;
                kh.cmtnd = txt_cmt.Text;
                kh.diachi = txt_diachi.Text;
                kh.gioitinh = -1;
                if (rbt_nam.Checked == true) kh.gioitinh = 1;
                if (rbt_nu.Checked == true) kh.gioitinh = 0;
                int kt = new khachhang_b().insert(kh);
                if (kt == -1)
                {
                    MessageBox.Show("Lỗi kết nối SQL !");
                    return;
                }
                if (kt == -2)
                {
                    MessageBox.Show("Lỗi insert khách hàng !");
                    return;
                }
                frm_quanlyKH_Load(sender,e);
            }
            else
            {
                MessageBox.Show("Đề nghị nhập đầy đủ thông tin càn thiết (mục có dấu *) !");
                return;
            }
            
        }
        private void frm_quanlyKH_Load(object sender, EventArgs e)
        {
            khachhang_b b = new khachhang_b();
            int kt = b.select(dgv_khachhang, "hanghoa", txt_khoatk.Text);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                this.Close();
            }
            if (kt == -2)
            {
                MessageBox.Show("Lỗi thực thi !");
                this.Close();
            }
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_makh.Text = dgv_khachhang[0, e.RowIndex].Value.ToString();
            txt_hoten.Text = dgv_khachhang[1, e.RowIndex].Value.ToString();
            txt_diachi.Text = dgv_khachhang[3, e.RowIndex].Value.ToString();
            txt_sdt.Text = dgv_khachhang[2, e.RowIndex].Value.ToString();
            txt_cmt.Text = dgv_khachhang[6, e.RowIndex].Value.ToString();
            dtp_ngaysinh.Text = dgv_khachhang[5, e.RowIndex].Value.ToString();
            lb_ma_ht.Text = dgv_khachhang[7, e.RowIndex].Value.ToString();
            string gt = dgv_khachhang[4, e.RowIndex].Value.ToString();
            switch (gt)
            {
                case "1":
                    rbt_nam.Checked = true;
                    break;
                case "0":
                    rbt_nu.Checked = true;
                    break;
                default:
                    rbt_khac.Checked = true;
                    break;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            frm_quanlyKH_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lb_ma_ht.Text==null)
            {
                MessageBox.Show("Chưa chọn khách hàng !");
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này ?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int kt = new khachhang_b().delete(lb_ma_ht.Text);
                if (kt == -1)
                {
                    MessageBox.Show("Lỗi kết nối SQL !");
                    return;
                }
                if (kt == -2)
                {
                    MessageBox.Show("Khách hàng đã từng mua hàng, không thể xóa !");
                    return;
                }
                if (kt == 1)
                {
                    MessageBox.Show("Xóa thành công !");
                    frm_quanlyKH_Load(sender, e);
                    return;
                }
            }
            else return;
           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lb_makh.Text = null;
            txt_hoten.Text = null;
            txt_diachi.Text = null;
            txt_sdt.Text = null;
            txt_cmt.Text = null;
            dtp_ngaysinh.Text = null;
            lb_ma_ht.Text = null;
            rbt_khac.Checked = false;
            rbt_nam.Checked = false;
            rbt_nu.Checked = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lb_ma_ht.Text == null)
            {
                MessageBox.Show("Chưa chọn khách hàng !");
                return;
            }
            khachhang_o kh = new khachhang_o();
            kh.ma = lb_ma_ht.Text;
            kh.hoten = txt_hoten.Text;
            kh.ngaysinh = Convert.ToDateTime(dtp_ngaysinh.Text);
            kh.sdt = txt_sdt.Text;
            kh.cmtnd = txt_cmt.Text;
            kh.diachi = txt_diachi.Text;
            kh.gioitinh = -1;
            if (rbt_nam.Checked == true) kh.gioitinh = 1;
            if (rbt_nu.Checked == true) kh.gioitinh = 0;
            int kt = new khachhang_b().Update(kh);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                return;
            }
            if (kt == -2)
            {
                MessageBox.Show("Lỗi thực thi !");
                return;
            }
            if (kt == 1)
            {
                MessageBox.Show("Sửa thành công !");
                frm_quanlyKH_Load(sender, e);
                return;
            }
        }
    }
}
