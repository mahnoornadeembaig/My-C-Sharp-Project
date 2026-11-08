namespace AMS.Forms.Teacher
{
    partial class TeacherForm
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
            label1 = new Label();
            button8 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 10;
            label1.Text = "Teacher Form";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(53, 88);
            button8.Name = "button8";
            button8.Size = new Size(146, 88);
            button8.TabIndex = 9;
            button8.Text = "View Profile";
            button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(220, 87);
            button5.Name = "button5";
            button5.Size = new Size(146, 88);
            button5.TabIndex = 11;
            button5.Text = "Mark Attendence";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 223);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button8);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button8;
        private Button button5;
    }
}