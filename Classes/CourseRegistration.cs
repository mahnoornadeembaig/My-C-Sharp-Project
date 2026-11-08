using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AMS.Classes
{
    internal class CourseRegistration
    {
        DbConnection connection;

        int crid,cid,sid;
        string sname,cname;

        public int CRid { get => Crid; set => Crid = value; }
        public int Crid { get => crid; set => crid = value; }
        public int Cid { get => cid; set => cid = value; }
        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Cname { get => cname; set => cname = value; }

        public void create()
        {
            connection = new DbConnection();
            string query = $"insert into CourseRegistration(CRid,Cid,Sid) values({CRid},{Cid},{Sid})";
            connection.ExecuteQuery(query, true);
        }
        public DataTable read()
        {
            connection = new DbConnection();
            string query = $"select cr.CRid,s.Sid,s.name,c.Cid,c.name from CourseRegistration cr join Student s on cr.Sid=s.Sid join Course c on cr.Cid=c.Cid;";
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
            string query = $"select * from Course;";
            DataTable dt = connection.ExecuteQuery(query, false);
            return dt;
        }
        public DataTable delete(int id)
        {
            connection = new DbConnection();
            string query = $"delete from CourseRegistration where CRid = {id}";
            DataTable dt = (DataTable)connection.ExecuteQuery(query, false);
            return dt;
        }
    }
}
