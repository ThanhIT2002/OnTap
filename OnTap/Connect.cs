using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace OnTap
{
    internal class Connect
    {
        private static string connect = "Data Source=DESKTOP-6HJIDLF\\QUANLITAISAN;Initial Catalog=TeamLeaderBai1;Integrated Security=True";
        private static SqlConnection CreateConnection()
        {
            return new SqlConnection(connect);
        }
        public static DataTable GetTable(string sql)
        {
            SqlConnection conn = CreateConnection ();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void AddUpdateDelete(string sql) {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand sc = new SqlCommand(sql, conn);
            sc.ExecuteNonQuery();
            conn.Close();
            sc.Dispose();
        }
    }
}
