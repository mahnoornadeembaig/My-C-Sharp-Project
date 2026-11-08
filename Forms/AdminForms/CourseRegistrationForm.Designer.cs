namespace AMS.Forms.Admin
{
    partial class CourseRegistrationForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label6 = new Label();
            button7 = new Button();
            dataGridView2 = new DataGridView();
            button8 = new Button();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(625, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(625, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 27);
            textBox4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 100);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 164);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 164);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 7;
            label3.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(625, 100);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Course ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 130);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 9;
            label5.Text = "Course Registration ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 27);
            textBox5.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 579);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(424, 188);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(357, 254);
            button1.Name = "button1";
            button1.Size = new Size(446, 35);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 544);
            button2.Name = "button2";
            button2.Size = new Size(246, 29);
            button2.TabIndex = 12;
            button2.Text = "Read (Available Students)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 489);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(385, 489);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(604, 489);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 15;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(791, 489);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 16;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(295, 21);
            label6.Name = "label6";
            label6.Size = new Size(313, 35);
            label6.TabIndex = 39;
            label6.Text = "Course Registration Form";
            // 
            // button7
            // 
            button7.Location = new Point(185, 489);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 40;
            button7.Text = "Read";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(457, 579);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(428, 188);
            dataGridView2.TabIndex = 41;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button8
            // 
            button8.Location = new Point(557, 544);
            button8.Name = "button8";
            button8.Size = new Size(246, 29);
            button8.TabIndex = 42;
            button8.Text = "Read (Available Courses)";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 295);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(873, 188);
            dataGridView3.TabIndex = 43;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // CourseRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 814);
            Controls.Add(dataGridView3);
            Controls.Add(button8);
            Controls.Add(dataGridView2);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CourseRegistrationForm";
            Text = "CourseRegistrationForm";
            Load += CourseRegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label6;
        private Button button7;
        private DataGridView dataGridView2;
        private Button button8;
        private DataGridView dataGridView3;
    }
}