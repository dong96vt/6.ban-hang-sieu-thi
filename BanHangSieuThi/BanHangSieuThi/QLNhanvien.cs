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
    public partial class QLNhanvien : Form
    {
        public QLNhanvien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=QUYETTHANG;Initial Catalog=Quanlybanhan1;Integrated Security=True");
        private void hienthi()
        {
            List<nhanvien_o> lstNhanvien = new List<nhanvien_o>();
            conn.Open();
            string sql = "select *  from nhanvien   ";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                nhanvien_o nv = new nhanvien_o();
                nv.ma = dr[0].ToString();
                nv.mahienthi = dr[1].ToString();
                nv.hoten = dr[2].ToString();
                nv.quequan = dr[3].ToString();
                nv.diachi = dr[4].ToString();
                nv.gioitinh = int.Parse(dr[5].ToString());
                nv.ngaysinh = DateTime.Parse(dr[6].ToString());
                nv.luong = int.Parse(dr[7].ToString());
                nv.chucvu = dr[8].ToString();
                nv.id = dr[9].ToString();
                nv.pass = dr[10].ToString();
                lstNhanvien.Add(nv);
            }

            conn.Close();
            dg1.DataSource = tb;
            dg1.Show();
        }
        private void setnull()
        {
            txtma.Clear();
            txtmahienthi.Clear();
            txthvt.Clear();
            txtdiachi.Clear();
            txtadd.Clear();
            txtchucvu.Clear();
            txtluong.Clear();
            txtid.Clear();
            txtpass.Clear();

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            int gt;
            if (rdnam.Checked)
                gt = 1;
            if (rdnu.Checked)
                gt = 0;
            else gt = -1;
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemNhanvien", conn);
            comm.Parameters.Add(new SqlParameter("@ma", txtma.Text));
            comm.Parameters.Add(new SqlParameter("@mahienthi", txtmahienthi.Text));
            comm.Parameters.Add(new SqlParameter("@hoten", txthvt.Text));
            comm.Parameters.Add(new SqlParameter("@quequan", txtadd.Text));
            comm.Parameters.Add(new SqlParameter("@diachi", txtdiachi.Text));
            comm.Parameters.Add(new SqlParameter("@gioitinh", gt));
            comm.Parameters.Add(new SqlParameter("@ngaysinh", dtns.Text));
            comm.Parameters.Add(new SqlParameter("@luong", txtluong.Text));
            comm.Parameters.Add(new SqlParameter("@chucvu", txtchucvu.Text));
            comm.Parameters.Add(new SqlParameter("@id", txtid.Text));
            comm.Parameters.Add(new SqlParameter("@pass", txtpass.Text));
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Nhập lỗi ");

            }
            conn.Close();
            hienthi();
            setnull();


        }

        private void QLNhanvien_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int gt;
            if (rdnam.Checked)
                gt = 1;
            if (rdnu.Checked)
                gt = 0;
            else gt = -1;
            conn.Open();
            SqlCommand comm = new SqlCommand("UpdateNhanvien", conn);
            comm.Parameters.Add(new SqlParameter("@ma", txtma.Text));
            comm.Parameters.Add(new SqlParameter("@mahienthi", txtmahienthi.Text));
            comm.Parameters.Add(new SqlParameter("@hoten", txthvt.Text));
            comm.Parameters.Add(new SqlParameter("@quequan", txtadd.Text));
            comm.Parameters.Add(new SqlParameter("@diachi", txtdiachi.Text));
            comm.Parameters.Add(new SqlParameter("@gioitinh", gt));
            comm.Parameters.Add(new SqlParameter("@ngaysinh", dtns.Text));
            comm.Parameters.Add(new SqlParameter("@luong", txtluong.Text));
            comm.Parameters.Add(new SqlParameter("@chucvu", txtchucvu.Text));
            comm.Parameters.Add(new SqlParameter("@id", txtid.Text));
            comm.Parameters.Add(new SqlParameter("@pass", txtpass.Text));
            comm.CommandType = CommandType.StoredProcedure;
            comm.ExecuteNonQuery();
            conn.Close();
            hienthi();
            setnull();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("XoaNhanvien", conn);
            comm.Parameters.Add(new SqlParameter("@ma", txtma.Text));
            comm.CommandType = CommandType.StoredProcedure;
            DialogResult c = MessageBox.Show("Do you want delete ? ", "  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (c == DialogResult.OK)
            {
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Mã nhân viên không tồn tại");
                    conn.Close();
                    return;
                }
                MessageBox.Show("Xóa thành công");
            }
            conn.Close();
            hienthi();
            setnull();
        }

        private void timkiem(object sender, EventArgs e)
        {
           
            if (cbtimkiem.Text == "Họ tên")
            {
                conn.Open();
                string tk = "select * from nhanvien where hoten like N'" + txttk.Text + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, conn);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dg1.DataSource = dta;
                conn.Close();
               
            }
            else if (cbtimkiem.Text == "Mã hiển thị ")
            {
                
                conn.Open();
                string tk = "select * from nhanvien where mahienthi like N'" + txttk.Text + "%' ";
                SqlDataAdapter add = new SqlDataAdapter(tk, conn);
                DataTable dta = new DataTable();
                add.Fill(dta);
                dg1.DataSource = dta;
                conn.Close();
              
            }
        }
        int index;
        private void dg1_Click(object sender, EventArgs e)
        {
            index = dg1.CurrentRow.Index;
            txtma.Text = dg1.Rows[index].Cells[0].Value.ToString();
            txtmahienthi.Text = dg1.Rows[index].Cells[1].Value.ToString();
            txthvt.Text = dg1.Rows[index].Cells[2].Value.ToString();
            txtadd.Text = dg1.Rows[index].Cells[3].Value.ToString();
            txtdiachi.Text = dg1.Rows[index].Cells[4].Value.ToString();
           
            dtns.Text = dg1.Rows[index].Cells[6].Value.ToString();
            txtluong.Text = dg1.Rows[index].Cells[7].Value.ToString();
            txtchucvu.Text = dg1.Rows[index].Cells[8].Value.ToString();
            txtid.Text = dg1.Rows[index].Cells[9].Value.ToString();
            txtpass.Text = dg1.Rows[index].Cells[10].Value.ToString();

        }
    }
}
