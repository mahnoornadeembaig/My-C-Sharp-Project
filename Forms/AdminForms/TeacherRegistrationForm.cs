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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AMS.Forms
{
    public partial class TeacherRegistrationForm : Form
    {
        public TeacherRegistrationForm()
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
            Classes.Teachers t = new Classes.Teachers();
            t.Id = Convert.ToInt32(textBox1.Text);
            t.Name = textBox2.Text;
            t.Email = textBox3.Text;
            t.Password = textBox4.Text;
            t.Qualification = textBox6.Text;
            t.Course = comboBox1.Text;
            t.create();
            MessageBox.Show("Teacher Registered!");
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            Courses c = new Courses();
            DataTable dt = c.readCourse();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
