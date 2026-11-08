using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Classes
{
    internal abstract class Person
    {
        int id;
        string name;
     //   int age;
        string email;
        string password;
        public string Name { get => name; set => name = value; }
    //    public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public abstract void create();
        public abstract DataTable read(int id);
        public abstract void update(int id);
        public abstract DataTable delete(int id);
    }
}
