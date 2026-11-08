using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    internal class Teachers:Person
    {
        string course;
        string qualification;
        DbConnection connection;
        public string Course { get => course; set => course = value; }
        public string Qualification { get => qualification; set => qualification = value; }

        public override void create()
        {
            connection = new DbConnection();
            string query = $"insert into Teacher(Tid,name,email,password,qualification,course) values({Id},'{Name}','{Email}','{Password}','{Qualification}','{Course}')";
            connection.ExecuteQuery(query, true);
        }
        public DataTable read()
        {
            connection = new DbConnection();
            string query = $"select * from Teacher";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public override DataTable read(int id)
        {
            connection = new DbConnection();
            string query = $"select * from Teacher where Tid = {id}";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public override void update(int id)
        {
            connection = new DbConnection();
            string query = $"update Teacher set name ='{Name}' , email = '{Email}'," +
                $" password='{Password}',qualification='{Qualification}',course='{Course}' where Tid={id}";
            connection.ExecuteQuery(query, true);
        }
        public override DataTable delete(int id)
        {
            connection = new DbConnection();
            string query = $"delete from Teacher where Tid = {id}";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable readTeacher()
        {
            DbConnection connection = new DbConnection();
            string query = $"select name from Teacher";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }

    }
}
