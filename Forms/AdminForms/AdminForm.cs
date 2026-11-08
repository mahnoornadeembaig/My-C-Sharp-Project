using AMS.Classes;
using AMS.Forms.Admin;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void read()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            read();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentRegistrationForm f = new StudentRegistrationForm();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeacherRegistrationForm f = new TeacherRegistrationForm();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentsRecordForm f = new StudentsRecordForm();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TeachersRecordForm f = new TeachersRecordForm();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AttendenceRecordForm f = new AttendenceRecordForm();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminProfile f = new AdminProfile();
            f.Show();
            this.Hide();
        }
    }
}
