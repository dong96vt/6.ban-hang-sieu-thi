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
    public partial class Menu : Form
    {
        private bool check = true;
        public Menu(string manv)
        {
            InitializeComponent();
            lb_manv.Text = manv;
            string chucvu = new nhanvien_b().check_chucvu(manv);
            if (chucvu != "admin") button5.Enabled = false;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            QLNhanvien f= new QLNhanvien();
            f.ShowDialog();
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            frm_quanlyKH f = new frm_quanlyKH();
            f.ShowDialog();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Themhang f = new Themhang();
            f.ShowDialog();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Timhang f = new Timhang();
            f.ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Banhang f = new Banhang(lb_manv.Text);
            f.ShowDialog();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Kho f = new Kho();
            f.ShowDialog();
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            Huongdan f = new Huongdan();
            f.ShowDialog();
        }
         protected override bool ProcessCmdKey(ref Message msg, Keys keydata) 
        { 
            if (keydata == Keys.F1) 
            {
                Huongdan f = new Huongdan();
                f.ShowDialog(); 
                return true; 
            } 
            return false; 
        }

         private void btn_Logout_Click(object sender, EventArgs e)
         {
             lb_manv.Text = null;
             check = false;
             this.Close();
             frm_login f = new frm_login();
             f.Visible = true;
         }

         private void Menu_FormClosing(object sender, FormClosingEventArgs e)
         {
             if (check == false) check = true;
             else
             {
                 Application.Exit();
             }
         } 

    }
}
