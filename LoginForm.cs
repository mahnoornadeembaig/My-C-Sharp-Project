using AMS.Classes;
using AMS.Forms;
using AMS.Forms.Teacher;
using AMS.StudentForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Run(new AdminForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string email = textBox7.Text;
            string password = textBox8.Text;
            string user = comboBox1.Text;

            user = Authentication.login(email, password,user);
            if (user == "Admin")
            {
                AdminForm form = new AdminForm();
                form.Show();
                this.Hide();
            }
            else if (user == "Teacher")
            {
                TeacherForm form = new TeacherForm();
                form.Show();
                this.Hide();
            }
            else if(user == "Student")
            {
                StudentForm form = new StudentForm();
                form.Show();
                this.Hide();
            }
            else if(user == "notFound")
            {
                MessageBox.Show("Invalid Email or Password");
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}