using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHLT
{
    class Functions
    {
        public static SqlConnection Conn;    

        public static void Connect()
        {
            Conn = new SqlConnection();
            Conn.ConnectionString = @"Data Source=VANSIUNHAN\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True";
            Conn.Open();
            if (Conn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
}
