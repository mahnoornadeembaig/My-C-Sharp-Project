using AMS.Classes;
using Microsoft.SqlServer.Server;
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

namespace AMS.Forms.Teacher
{
    public partial class MarkAttendence : Form
    {
        public MarkAttendence()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            Courses c = new Courses();
            DataTable dt = c.readCourse();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            DataTable dt = t.readTeacher();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
        }

        void read()
        {
            AttendenceRecord ar = new AttendenceRecord();
            DataTable dt = ar.read();
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            read();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AttendenceRecord ar = new AttendenceRecord();
            DataTable dt = ar.readStudents();
            dataGridView3.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AttendenceRecord ar = new AttendenceRecord();
            DataTable dt = ar.readCourse();
            dataGridView2.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AttendenceRecord ar = new AttendenceRecord();
            ar.C_id = Convert.ToInt32(textBox1.Text);
            ar.S_id = Convert.ToInt32(textBox2.Text);
            ar.S_name = textBox3.Text;
            ar.C_name = comboBox1.Text;
            ar.T_name = comboBox2.Text;
            ar.Status = comboBox3.Text;
            ar.Date = dateTimePicker1.Text;
            ar.create();
            read();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[0].Value);
            textBox3.Text = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[1].Value);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            comboBox1.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForm f = new TeacherForm();
            f.Show();
            this.Hide();
        }
    }
}
