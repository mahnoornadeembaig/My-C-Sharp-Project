using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    internal class Courses
    {
        string course;

        public string Course { get => course; set => course = value; }

        public DataTable readCourse()
        {
            DbConnection connection = new DbConnection();
            string query = $"select name from Course";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }
    }
}
