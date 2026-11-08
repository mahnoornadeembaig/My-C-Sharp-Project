using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    internal class AdminC:Person
    {
        DbConnection connection;

        public override void create()
        {

        }
        public DataTable read()
        {
            connection = new DbConnection();
            string query = $"select * from Admin";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }


        public override DataTable read(int id)
        {
            connection = new DbConnection();
            string query = $"select * from Admin where Aid = {id}";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public override void update(int id)
        {
            connection = new DbConnection();
            string query = $"update Admin set name ='{Name}' , email = '{Email}'," +
                $" password='{Password}' where Aid={id}";
            connection.ExecuteQuery(query, true);
        }
        public override DataTable delete(int id)
        {
            connection = new DbConnection();
            string query = $"delete from Student where Aid = {id}";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }
    }
}
