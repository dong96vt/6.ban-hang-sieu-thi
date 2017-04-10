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

namespace BanHangSieuThi
{
    public partial class Banhang : Form
    {
        SqlConnection conn= Connection.Conn();
        private string tien;
        public Banhang()
        {
            InitializeComponent();
            initGrid(dgvhanghoa);
        }
        protected void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "mahienthi";
            cl.HeaderText = "MÃ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ten";
            cl.HeaderText = "TÊN SẢN PHẨM";
            cl.Width = 167;
            dgv.Columns.Add(cl);
        }

        private void butquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Banhang_Load(sender, e);
        }

        private void butthanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void Banhang_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();          
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối SQL");
            }
            string selec_hanghoa;
            if (!String.IsNullOrEmpty(txtkhoa.Text))
            {
                selec_hanghoa = "Select * from hanghoa where ma="+txtkhoa.Text+"or ten="+txtkhoa.Text;
            }
            else selec_hanghoa = "Select * from hanghoa";
            SqlCommand cm = new SqlCommand(selec_hanghoa, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            try
            {
                da.Fill(ds, "hanghoa");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            dgvhanghoa.DataSource = ds.Tables["hanghoa"].DefaultView;
            dgvhanghoa.Refresh();
            conn.Close();
        }

        private void butmua_Click(object sender, EventArgs e)
        {
            if(dgvhanghoa.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm");
                return;
            }
            DataRowView drview = (DataRowView) dgvhanghoa.SelectedRows[0].DataBoundItem;
            DataRow dr = drview.Row;
            hanghoa_o hh = new hanghoa_o();
            hh.ma = dr["ma"].ToString();
            hh.mahienthi = dr["mahienthi"].ToString();
            hh.ten = dr["ten"].ToString();
            hh.gia = dr["gia"].ToString();
            showList(hh);
            txtsoluong.Text = "0";
        }
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
            ListViewItem item = new ListViewItem();
            item.Text = hh.ten;
            item.SubItems.Add(txtsoluong.Text);
            item.SubItems.Add(hh.gia);
            ls_chon.Items.Add(item);
            tien = (Convert.ToInt32(tien) + Convert.ToInt32(txtsoluong.Text) * Convert.ToInt32(hh.gia)).ToString();
            showTien(tien);
            txttienchu.Text = ReadNumber.ByWords(decimal.Parse(txttien.Text));
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
            txttien.Text = tien;
        }

        private void cbboqua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbboqua.Checked == true)
            {
                cb_khachquen.Enabled = false;
                txthoten.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtdiachi.ReadOnly = true;
                txtcmtnd.ReadOnly = true;
            }
            else
            {
                cb_khachquen.Enabled = true;
                txthoten.ReadOnly = false;
                txtsdt.ReadOnly = false;
                txtdiachi.ReadOnly = false;
                txtcmtnd.ReadOnly = false;
            }
        }

        private void cb_khachquen_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_khachquen.Checked == true)
            {
                cbboqua.Enabled = false;
                txthoten.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtdiachi.ReadOnly = true;
                txtcmtnd.ReadOnly = true;
                cbb_khachquen.Enabled = true;
            }
            else
            {
                cbboqua.Enabled = true;
                txthoten.ReadOnly = false;
                txtsdt.ReadOnly = false;
                txtdiachi.ReadOnly = false;
                txtcmtnd.ReadOnly = false;
                cbb_khachquen.Enabled = false;
            }
        }

    }
}
