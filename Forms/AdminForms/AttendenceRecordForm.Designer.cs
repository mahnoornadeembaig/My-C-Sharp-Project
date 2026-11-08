namespace AMS.Forms
{
    partial class AttendenceRecordForm
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
            label6 = new Label();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(290, 19);
            label6.Name = "label6";
            label6.Size = new Size(239, 35);
            label6.TabIndex = 60;
            label6.Text = "Attendence Record";
            // 
            // button4
            // 
            button4.Location = new Point(12, 488);
            button4.Name = "button4";
            button4.Size = new Size(229, 38);
            button4.TabIndex = 65;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(768, 174);
            dataGridView1.TabIndex = 63;
            // 
            // button2
            // 
            button2.Location = new Point(594, 488);
            button2.Name = "button2";
            button2.Size = new Size(186, 38);
            button2.TabIndex = 62;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 28);
            comboBox1.TabIndex = 72;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(73, 95);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 73;
            label7.Text = "Select Date";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 170);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 96;
            label1.Text = "Course ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 95;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 170);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 94;
            label5.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 237);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 93;
            label4.Text = "Student Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 27);
            textBox3.TabIndex = 92;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 237);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 90;
            label2.Text = "Select Course";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(290, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(168, 28);
            comboBox2.TabIndex = 89;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "P", "A" });
            comboBox3.Location = new Point(511, 260);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(179, 28);
            comboBox3.TabIndex = 99;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 237);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 98;
            label3.Text = "Select Status";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(511, 192);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(179, 28);
            comboBox4.TabIndex = 97;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(511, 169);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 100;
            label8.Text = "Teacher Name";
            // 
            // button1
            // 
            button1.Location = new Point(318, 488);
            button1.Name = "button1";
            button1.Size = new Size(191, 38);
            button1.TabIndex = 101;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AttendenceRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 550);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label6);
            Name = "AttendenceRecordForm";
            Text = "AttendenceRecordForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox4;
        private Label label8;
        private Button button1;
    }
}