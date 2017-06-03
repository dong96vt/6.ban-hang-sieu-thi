using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace BanHangSieuThi
{
    class Connection
    {
        public static SqlConnection conn = Conn();
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlConnection Conn()
        {
            Ini ini = new Ini("C:\\Program Files (x86)\\Ban_hang_sieu_thi\\My Product Name\\Conn.ini");
            //ini.WriteValue("a", "b", @"Data Source=SUPER\SQLEXPRESS;Initial Catalog=TTN_banhangsieuthi;Integrated Security=True");
            string connString = ini.ReadValue("ConnString", "conn");
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static DataTable getDataTable(string sql)
        {
            conn.Open();
            // tạo đối tượng trỏ tới dl trong database 
            cmd = new SqlCommand(sql, conn);
            // dtg để lưu dữ liệu lên database 
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            // tạo database để hiển thị dl
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cmd.Dispose();
            conn.Close();
            return table;
        }
        public static void Excute(string sql)
        {
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            //gọi hàm để có thể thực hiện thao tác Delete Insert Update
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public class Ini
        {
            private string path; 
            [DllImport("kernel32")] 
            private static extern int GetPrivateProfileString(string section,string key,string def,StringBuilder retVal,int size,string filePath); 
            [DllImport("kernel32")] 
            private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);
            private Ini(){} 
            public Ini(string path_ini) { path=path_ini; } 
            public string ReadValue(string Section,string Key) 
            { 
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section,Key,"",temp,255,this.path);
                return temp.ToString(); 
            } 
            public void WriteValue(string Section,string Key,string Value) 
            { 
                WritePrivateProfileString(Section,Key,Value,this.path); 
            }
        }



    }
}
