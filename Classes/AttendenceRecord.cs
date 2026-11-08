using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    internal class AttendenceRecord
    {
        DbConnection connection;
        int c_id, s_id;
        string s_name,c_name,t_name;
         string date;
         string status;

        public string Date { get => date; set => date = value; }
        public int C_id { get => c_id; set => c_id = value; }
        public string Status { get => status; set => status = value; }
        public int S_id { get => s_id; set => s_id = value; }
        public string S_name { get => s_name; set => s_name = value; }
        public string C_name { get => c_name; set => c_name = value; }
        public string T_name { get => t_name; set => t_name = value; }

        public void create()
        {
            connection = new DbConnection();
            string query = $"insert into ARecord(Tname,Cname,Sname,Date,status,C_id,S_id) values('{T_name}','{C_name}','{S_name}','{Date}','{status}',{C_id},{S_id})";
            connection.ExecuteQuery(query, true);
        }
        public DataTable read(string date)
        {
            connection = new DbConnection();
            string query = $"select S_id,Sname,Cname,status from ARecord where Date = '{date}'";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable read(int id)
        {
            connection = new DbConnection();
            string query = $"select S_id,Sname,Cname,status from ARecord where S_id = {id}";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable read()
        {
            connection = new DbConnection();
            string query = $"select S_id,Sname,Cname,status from ARecord";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }

        public DataTable readStudents()
        {
            connection = new DbConnection();
            string query = $"select Sid,name from Student;";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable readCourse()
        {
            connection = new DbConnection();
            string query = $"select Cid,name from Course;";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable readDate()
        {
            DbConnection connection = new DbConnection();
            string query = $"select Date from ARecord";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable delete(int id)
        {
            connection = new DbConnection();
            //delete from ARecord where Date = '{date}' ||
            string query = $"delete from ARecord where S_id = {id}";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }
    }
}
