using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AMS.Classes;
using static System.Collections.Specialized.BitVector32;

namespace AMS.Classes
{
    internal class Students:Person
    {
        string course;
        DbConnection connection;
        public string Course { get => course; set => course = value; }

        public override void create()
        {
            connection = new DbConnection();
            string query = $"insert into Student(Sid,name,email,password) values({Id},'{Name}','{Email}','{Password}')";
            connection.ExecuteQuery(query,true);
        }
        public DataTable read()
        {
            connection = new DbConnection();
            string query = $"select * from Student";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        
        
        public override DataTable read(int id)
        {
            connection = new DbConnection();
            string query = $"select * from Student where Sid = {id}";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public override void update(int id)
        {
            connection = new DbConnection();
            string query = $"update Student set name ='{Name}' , email = '{Email}'," +
                $" password='{Password}' where Sid={id}";
            connection.ExecuteQuery(query, true);
        }
        public override DataTable delete(int id)
        {
            connection = new DbConnection();
            string query = $"delete from Student where Sid = {id}";
            DataTable dt = (DataTable) connection.ExecuteQuery(query, false);
            return dt;
        }
    }
}
