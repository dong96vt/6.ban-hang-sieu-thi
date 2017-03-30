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
        public Banhang()
        {
            try
            {
                conn.Open();
            }
            catch
            {

            }
            string selec_hanghoa="Select * from hanghoa";
            SqlCommand sl = new SqlCommand(selec_hanghoa, conn);
            InitializeComponent();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
