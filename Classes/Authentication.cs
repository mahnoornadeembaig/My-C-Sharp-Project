using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    static internal class Authentication
    {
        public static string login(string email, string password,string user)
        {
            DbConnection db = new DbConnection();
            string query = $"select * from {user} where email = '{email}' AND password = '{password}'";
            DataTable dt = db.ExecuteQuery(query,false);
            if (dt.Rows.Count > 0) {
                return user;
            }
            else { return "notFound"; }
        }
    }
}
