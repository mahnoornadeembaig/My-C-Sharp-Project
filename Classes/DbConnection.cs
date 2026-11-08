using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    sealed internal class DbConnection
    {
        string con = "Data Source=DESKTOP-8FTFURH\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;TrustServerCertificate=True";
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dt);
            return dt;
        }
        public DataTable ExecuteQuery(string query, bool flag)
        {
            SqlConnection connection = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, connection);
            if (flag)
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
