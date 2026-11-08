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
    public partial class AttendenceRecordForm : Form
    {
        public AttendenceRecordForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AttendenceRecord ar = new AttendenceRecord();
            ar.read();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            AttendenceRecord ar = new AttendenceRecord();
            DataTable dt = ar.readDate();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Date";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AttendenceRecord s = new AttendenceRecord();
            string date = comboBox1.Text;
            dataGridView1.DataSource = s.read(date);
            //   int id = Convert.ToInt32(textBox2.Text);
            //    dataGridView1.DataSource = s.read(id);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendenceRecord s = new AttendenceRecord();
            int id = Convert.ToInt32(textBox2.Text);
            s.delete(id);
        }
    }
}
