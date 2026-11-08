namespace AMS.Forms
{
    partial class StudentsRecordForm
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(294, 29);
            label6.Name = "label6";
            label6.Size = new Size(206, 35);
            label6.TabIndex = 38;
            label6.Text = "Students Record";
            // 
            // button2
            // 
            button2.Location = new Point(676, 390);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 37;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 390);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 36;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(453, 210);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 34;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(453, 134);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 33;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 213);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 32;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 137);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 31;
            label1.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(535, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 27);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(535, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 27);
            textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(767, 105);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(149, 390);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 40;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(346, 390);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 41;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(535, 390);
            button5.Name = "button5";
            button5.Size = new Size(107, 38);
            button5.TabIndex = 42;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // StudentsRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 448);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "StudentsRecordForm";
            Text = "StudentsRecordForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}