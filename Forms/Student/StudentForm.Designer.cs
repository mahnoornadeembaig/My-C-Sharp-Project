namespace AMS.StudentForms
{
    partial class StudentForm
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
            button8 = new Button();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(241, 130);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(144, 127);
            button8.TabIndex = 13;
            button8.Text = "View Profile";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(403, 130);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(144, 127);
            button7.TabIndex = 12;
            button7.Text = "Attendence Record";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 14;
            label1.Text = "Student Form";
            label1.Click += label1_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Button button7;
        private Label label1;
    }
}