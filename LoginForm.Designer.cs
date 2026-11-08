namespace AMS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(238, 360);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 0;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(186, 174);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(146, 27);
            textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(186, 248);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(146, 27);
            textBox8.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 151);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Email";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 225);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            comboBox1.Location = new Point(186, 316);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 293);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 6;
            label7.Text = "User";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 461);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private Label label7;
    }
}