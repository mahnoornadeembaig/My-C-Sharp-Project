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
    public partial class TeachersRecordForm : Form
    {
        public TeachersRecordForm()
        {
            InitializeComponent();
        }
        void read()
        {
            Classes.Teachers t = new Classes.Teachers();
            DataTable dt = t.read();
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            read();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Teachers t = new Classes.Teachers();
            t.Name = textBox2.Text;
            t.Course = textBox5.Text;
            t.Email = textBox3.Text;
            t.Password = textBox4.Text;
            t.Qualification = textBox6.Text;
            t.update(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Update Sucessful!");
            read();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teachers s = new Teachers();
            s.delete(Convert.ToInt32(textBox1.Text));
        }
    }
}
