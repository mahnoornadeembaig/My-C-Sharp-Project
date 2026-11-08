using AMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.Forms
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Id = Convert.ToInt32(textBox1.Text);
            s.Name = textBox2.Text;
            s.Email = textBox3.Text;
            s.Password = textBox4.Text;
            s.create();
            MessageBox.Show("Student Registered!");
        }
    }
}
