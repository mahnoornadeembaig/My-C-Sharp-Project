namespace AMS.Forms.Teacher
{
    partial class MarkAttendence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox2 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button6 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            button7 = new Button();
            dataGridView3 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(335, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 28);
            comboBox1.TabIndex = 0;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 180);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Course";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 189);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellLeave += dataGridView1_CellLeave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 36);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Select Date";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(538, 461);
            button5.Name = "button5";
            button5.Size = new Size(107, 38);
            button5.TabIndex = 71;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(349, 461);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 70;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(152, 461);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 69;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(680, 461);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 68;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 461);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 67;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 27);
            textBox3.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 36);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 74;
            label3.Text = "Teacher Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 180);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 75;
            label4.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 103);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 76;
            label5.Text = "Student ID";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(433, 61);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 28);
            comboBox2.TabIndex = 78;
            comboBox2.DropDown += comboBox2_DropDown;
            // 
            // button6
            // 
            button6.Location = new Point(554, 204);
            button6.Name = "button6";
            button6.Size = new Size(168, 29);
            button6.TabIndex = 79;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(509, 534);
            button8.Name = "button8";
            button8.Size = new Size(201, 29);
            button8.TabIndex = 86;
            button8.Text = "Courses";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(433, 569);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(354, 188);
            dataGridView2.TabIndex = 85;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button7
            // 
            button7.Location = new Point(90, 534);
            button7.Name = "button7";
            button7.Size = new Size(211, 29);
            button7.TabIndex = 84;
            button7.Text = "Students";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(11, 569);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(354, 188);
            dataGridView3.TabIndex = 83;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 103);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 88;
            label7.Text = "Course ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(335, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(554, 103);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 82;
            label6.Text = "Select Status";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "P", "A" });
            comboBox3.Location = new Point(554, 126);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(168, 28);
            comboBox3.TabIndex = 89;
            // 
            // MarkAttendence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 790);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(dataGridView2);
            Controls.Add(button7);
            Controls.Add(dataGridView3);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "MarkAttendence";
            Text = "MarkAttendence";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private Button button6;
        private Button button8;
        private DataGridView dataGridView2;
        private Button button7;
        private DataGridView dataGridView3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private ComboBox comboBox3;
    }
}