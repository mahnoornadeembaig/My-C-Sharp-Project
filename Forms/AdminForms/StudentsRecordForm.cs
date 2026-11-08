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
    public partial class StudentsRecordForm : Form
    {
        public StudentsRecordForm()
        {
            InitializeComponent();
        }
        void read()
        {
            Students s = new Students();
            DataTable dt = s.read();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.delete(Convert.ToInt32(textBox1.Text));
            read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            dataGridView1.DataSource = s.read(Convert.ToInt32(textBox1.Text));
            // read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Name = textBox2.Text;
            s.Email = textBox3.Text;
            s.Password = textBox4.Text;

            s.update(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Update Sucessful!");
            read();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
