namespace AMS.Forms
{
    partial class AdminForm
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(181, 131);
            button3.Name = "button3";
            button3.Size = new Size(155, 88);
            button3.TabIndex = 2;
            button3.Text = "Student Registration";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(181, 225);
            button4.Name = "button4";
            button4.Size = new Size(155, 88);
            button4.TabIndex = 3;
            button4.Text = "Students Record";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(342, 131);
            button5.Name = "button5";
            button5.Size = new Size(155, 88);
            button5.TabIndex = 4;
            button5.Text = "Teacher Registration";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(342, 225);
            button6.Name = "button6";
            button6.Size = new Size(155, 88);
            button6.TabIndex = 5;
            button6.Text = "Teachers Record";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(181, 319);
            button7.Name = "button7";
            button7.Size = new Size(316, 88);
            button7.TabIndex = 6;
            button7.Text = "Attendence Record";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(181, 82);
            button8.Name = "button8";
            button8.Size = new Size(316, 43);
            button8.TabIndex = 7;
            button8.Text = "View Profile";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 25);
            label1.Name = "label1";
            label1.Size = new Size(161, 35);
            label1.TabIndex = 8;
            label1.Text = "Admin Form";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 445);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Margin = new Padding(2);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
    }
}