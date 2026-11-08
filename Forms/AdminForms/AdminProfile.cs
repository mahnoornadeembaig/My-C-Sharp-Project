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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminC a = new AdminC();
            DataTable dt = a.read();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminC s = new AdminC();
            s.Name = textBox2.Text;
            s.Email = textBox3.Text;
            s.Password = textBox4.Text;
            s.update(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Update Sucessful!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminC s = new AdminC();
            dataGridView1.DataSource = s.read(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
            this.Hide();
        }
    }
}
