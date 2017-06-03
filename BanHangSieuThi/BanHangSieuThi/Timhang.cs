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
    public partial class Timhang : Form
    {
        public Timhang()
        {
            InitializeComponent();
            Timhang_Load();
            load_dropdownlist();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void load_dropdownlist()
        {
            int kt = new hanghoa_b().Load_DropDowList(cbb_loai);
        }
        private void Timhang_Load()
        {
            IEnumerable<hanghoa_o> list = new hanghoa_b().list_obj();
            if (cbb_loai.SelectedValue != null && cbb_loai.SelectedValue.ToString() != "0") list = list.Where(h => h.loaihang == cbb_loai.SelectedValue.ToString());
            if (!string.IsNullOrWhiteSpace(txt_ten.Text)) list = list.Where(h => h.ten.ToUpper().Contains(txt_ten.Text.ToUpper()));
            if (!(string.IsNullOrWhiteSpace(txt_min.Text) && string.IsNullOrWhiteSpace(txt_max.Text)))
            {
                int max, min;
                try
                {
                    if (!string.IsNullOrWhiteSpace(txt_max.Text)) max = Convert.ToInt32(txt_max.Text);
                    else max = 999999999;
                    if (!string.IsNullOrWhiteSpace(txt_min.Text)) min = Convert.ToInt32(txt_min.Text);
                    else min = 0;
                    list = list.Where(h => Convert.ToInt32(h.gia) > min && Convert.ToInt32(h.gia) <= max);
                }
                catch
                {
                    MessageBox.Show("Mức giá phải là số, mời nhập lại !");
                    return;
                }  
                
            }
            foreach(var hh in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = hh.ma;
                item.SubItems.Add(hh.mahienthi);
                item.SubItems.Add(hh.ten);
                item.SubItems.Add(hh.soluongcon);
                item.SubItems.Add(hh.gia);
                item.SubItems.Add(hh.loaihang);
                lv_hanghoa.Items.Add(item);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_min.Text) && !string.IsNullOrWhiteSpace(txt_max.Text))
            {
                try 
                {
                    Convert.ToInt32(txt_min.Text);
                   Convert.ToInt32(txt_max.Text);
                }
                catch
                {
                    MessageBox.Show("Mức giá phải là số, mời nhập lại !");
                    return;
                }
            }
            
            lv_hanghoa.Items.Clear();
            Timhang_Load();
        }

        private void cbb_loai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_tim_Click(sender, e);
        }
    }
}
