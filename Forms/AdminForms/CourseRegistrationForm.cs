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

namespace AMS.Forms.Admin
{
    public partial class CourseRegistrationForm : Form
    {
        public CourseRegistrationForm()
        {
            InitializeComponent();
        }

        private void CourseRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseRegistration cr = new CourseRegistration();
            DataTable dt = cr.readStudents();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseRegistration cr = new CourseRegistration();

            cr.Sid = Convert.ToInt32(textBox1.Text);
            cr.Sname = textBox2.Text;
            cr.Cid = Convert.ToInt32(textBox4.Text);
            cr.Cname = textBox3.Text;
            cr.Crid = Convert.ToInt32(textBox5.Text);
            cr.create();
            MessageBox.Show("Course Registered!");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CourseRegistration cr = new CourseRegistration();
            DataTable dt = cr.read();
            dataGridView3.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CourseRegistration cr = new CourseRegistration();
            DataTable dt = cr.readCourse();
            dataGridView2.DataSource = dt;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseRegistration cr = new CourseRegistration();
            DataTable dt = cr.read();
            dataGridView3.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            textBox3.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(textBox5.Text);
            CourseRegistration cr = new CourseRegistration();
            cr.delete(id);
            MessageBox.Show("Deleted!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
