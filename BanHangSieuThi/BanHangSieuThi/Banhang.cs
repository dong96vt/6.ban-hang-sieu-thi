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
    public partial class Banhang : Form
    {
        private string tien; // Biến lưu tổng tiền của hóa đơn
        public Banhang(string manv)
        {
            InitializeComponent();
            initGrid(dgvhanghoa); 
            lb_manhanvien.Text = manv;
            cbboqua.Checked = true;
        }
        // Khởi tạo các cột cho DataGridView dgvhanghoa
        protected void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "mahienthi";
            cl.HeaderText = "MÃ";
            cl.Width = 90;
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ten";
            cl.HeaderText = "TÊN SẢN PHẨM";
            cl.Width = 160;
            dgv.Columns.Add(cl);
        }
        // Load dữ liệu vào combobox cbb_khachquen
        public void Load_cbb()
        {
            int kt = new khachhang_b().Load_DropDowList(cbb_khachquen);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                this.Close();
            }
        }
        // Click button butquaylai
        private void butquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Click button butthanhtoan
        private void butthanhtoan_Click(object sender, EventArgs e)
        {
            string ma = DateTime.Now.ToString("yymmddhhss");
            //lấy dữ liệu từ listview và kiểm tra
            List<sanpham_o> ls = new List<sanpham_o>();
            int i = 0;
            foreach (ListViewItem item in ls_chon.Items)
            {
                sanpham_o sp = new sanpham_o();
                hanghoa_b bus = new hanghoa_b();
                sp.ma = (Convert.ToInt32(ma) + i).ToString();
                sp.mahienthi = "SP" + sp.ma;
                sp.soluong = Convert.ToInt32(item.SubItems[2].Text);
                sp.hoadonma = ma;
                sp.hanghoama = item.SubItems[0].Text;
                ls.Add(sp);
                string ck = bus.check_kho(sp.hanghoama, sp.soluong);
                if (ck == "0") 
                {
                    MessageBox.Show("Kho đã hết sản phẩm "+sp.hanghoama+"!");
                    return;
                }
                i++;
            }
            if (i == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm !");
                return;
            }
            //INSERT
            int kt;
            hoadon_o hd = new hoadon_o();
            hoadon_b bushd = new hoadon_b();
            hd.ma = ma;
            hd.ngayviet = DateTime.Now;
            hd.nhanvienma = lb_manhanvien.Text;
            hd.tonggia = Convert.ToInt32(tien);
            hd.mahienthi = "HD" + ma;
            
             //insert khách hàng (Nếu là khách mới) và gán giá trị cho khachhangma
            if (cbboqua.Checked == true) hd.khachhangma = "KHNULL";
            else
            {
                if (cb_khachquen.Checked == false)
                {
                    if (txthoten.Text == null && txtcmtnd.Text == null && txtsdt.Text == null) MessageBox.Show("Chưa điền thông tin khách hàng !");
                    khachhang_o kh = new khachhang_o();
                    khachhang_b b = new khachhang_b();
                    kh.ma = ma;
                    kh.mahienthi = "KH" + kh.ma;
                    kh.sdt = txtsdt.Text;
                    kh.hoten = txthoten.Text;
                    kh.diachi = txtdiachi.Text;
                    kh.cmtnd = txtcmtnd.Text;
                    if (rbt_nam.Checked == true) kh.gioitinh = 1;
                    if (rbt_nu.Checked == true) kh.gioitinh = 0;
                    else kh.gioitinh = -1;
                    kt = b.insert(kh);
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
                    hd.khachhangma = ma;
                }
                else
                {
                    if (cbb_khachquen.SelectedValue.ToString().Length > 10) MessageBox.Show("Chưa chọn khách hàng !");
                    else hd.khachhangma = cbb_khachquen.SelectedValue.ToString();
                }
            }
            
             //insert hóa đơn
            kt = bushd.insert(hd);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                return;
            }
            if (kt == -2)
            {
                MessageBox.Show("Lỗi insert hóa đơn !");
                return;
            }

            // insert các sản phẩm 
            
            sanpham_b bussp = new sanpham_b();
            kt = bussp.insert_list(ls);
            if (kt == -1)
            {
                MessageBox.Show("Lỗi kết nối SQL !");
                return;
            }
            if (kt == -2)
            {
                MessageBox.Show("Lỗi insert sản phẩm !");
                return;
            }
            if (kt == 1)
            {
                ls_chon.Items.Clear(); // Xóa sảm phẩm đã mua trong list View
                MessageBox.Show("Thành công !");
                return;
            }
            
            
        }
        // Load dữ liệu lên DataGridView dgvhanghoa
        private void Banhang_Load(object sender, EventArgs e)
        {
            hanghoa_b b = new hanghoa_b();
            int kt = b.select(dgvhanghoa, "hanghoa", txtkhoa.Text);
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
        // Click button butmua
        private void butmua_Click(object sender, EventArgs e)
        {
            if(dgvhanghoa.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm");
                return;
            }
            DataRowView drview = (DataRowView) dgvhanghoa.SelectedRows[0].DataBoundItem;
            hanghoa_b b = new hanghoa_b();
            hanghoa_o hh = b.oject4Row(drview.Row);
            showList(hh);
            txtsoluong.Text = "0";
        }
        // Hàm hiển thị ListView ls_chon và tiền trong txttien, txttienchu
        private void showList(hanghoa_o hh)
        {   
            if (String.IsNullOrEmpty(txttien.Text)) txttien.Text = "0";
            try
            {
                int sl = Convert.ToInt32(txtsoluong.Text);
                if (sl == 0)
                {
                    MessageBox.Show("Số lượng mua phải khác 0, mời nhập lại !");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai số lượng, mời nhập lại !");
                return;
            }
            foreach (ListViewItem find in ls_chon.Items)
            {
                if (hh.ma == find.SubItems[0].Text)
                {
                    find.SubItems[2].Text = (Convert.ToInt32(find.SubItems[2].Text) + Convert.ToInt32(txtsoluong.Text)).ToString();
                    if (Convert.ToInt32(find.SubItems[2].Text) <= 0) ls_chon.Items.Remove(find);
                    return;
                }
            }
            ListViewItem item = new ListViewItem();
            item.Text = hh.ma;
            item.SubItems.Add(hh.ten);
            item.SubItems.Add(txtsoluong.Text);
            item.SubItems.Add(hh.gia);
            ls_chon.Items.Add(item);
            tien = (Convert.ToInt32(tien) + Convert.ToInt32(txtsoluong.Text) * Convert.ToInt32(hh.gia)).ToString();
            showTien(tien);
            txttienchu.Text = ReadNumber.ByWords(decimal.Parse(txttien.Text));
            return;
        }
        // Hàm hiển thị tiền vào txttien
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
            txttien.Text = tien;
        }
        // Thay đổi trạng thái check của checkbox cb_boqua
        private void cbboqua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbboqua.Checked == true)
            {
                cb_khachquen.Enabled = false;
                txthoten.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtdiachi.ReadOnly = true;
                txtcmtnd.ReadOnly = true;
                rbt_khac.Enabled = false;
                rbt_nam.Enabled = false;
                rbt_nu.Enabled = false;
            }
            else
            {
                cb_khachquen.Enabled = true;
                txthoten.ReadOnly = false;
                txtsdt.ReadOnly = false;
                txtdiachi.ReadOnly = false;
                txtcmtnd.ReadOnly = false;
                rbt_khac.Enabled = true;
                rbt_nam.Enabled = true;
                rbt_nu.Enabled = true;
            }
        }
        // Thay đổi trạng thái check của checkbox cb_khachquen
        private void cb_khachquen_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_khachquen.Checked == true)
            {
                Load_cbb();
                cbboqua.Enabled = false;
                txthoten.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtdiachi.ReadOnly = true;
                txtcmtnd.ReadOnly = true;
                cbb_khachquen.Enabled = true;
                rbt_khac.Enabled = false;
                rbt_nam.Enabled = false;
                rbt_nu.Enabled = false;
            }
            else
            {
                cbboqua.Enabled = true;
                txthoten.ReadOnly = false;
                txthoten.Text = null;
                txtsdt.ReadOnly = false;
                txtsdt.Text = null;
                txtdiachi.ReadOnly = false;
                txtdiachi.Text = null;
                txtcmtnd.ReadOnly = false;
                txtcmtnd.Text = null;
                cbb_khachquen.Enabled = false;
                rbt_khac.Enabled = true;
                rbt_nam.Enabled = true;
                rbt_nu.Enabled = true;
            }
        }
        // Chọn 1 đối tượng trong ComboBox cbb_khachquen
        private void cbb_khachquen_SelectedIndexChanged(object sender, EventArgs e)
        {
            khachhang_b b = new khachhang_b();
            string id = cbb_khachquen.SelectedValue.ToString();
            if (id.Length > 10) return;
            khachhang_o kh = b.oject4ComboBox(id);

            if (cb_khachquen.Checked == true)
            {
                txtcmtnd.Text = kh.cmtnd.ToString();
                txtdiachi.Text = kh.diachi.ToString();
                txthoten.Text = kh.hoten.ToString();
                txtsdt.Text = kh.sdt.ToString();
                switch (kh.gioitinh)
                {
                    case 1:
                        rbt_nam.Checked = true;
                        break;
                    case 0:
                        rbt_nu.Checked = true;
                        break;
                    default:
                        rbt_khac.Checked = true;
                        break;
                }
            }
        }
        private void txtkhoa_TextChanged(object sender, EventArgs e)
        {
            Banhang_Load(sender, e);
        }
    }
}
