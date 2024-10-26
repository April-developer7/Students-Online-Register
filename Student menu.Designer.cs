namespace Assessment_2
{
    partial class Student_menu
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
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(45, 128, 185);
            button7.FlatAppearance.BorderSize = 0;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(535, 315);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(252, 81);
            button7.TabIndex = 27;
            button7.Text = "Send Request\r\n";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(815, 42);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(162, 48);
            button6.TabIndex = 26;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(45, 128, 185);
            button4.FlatAppearance.BorderSize = 0;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(202, 315);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(252, 81);
            button4.TabIndex = 25;
            button4.Text = "Register for subject";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 128, 185);
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(535, 171);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(252, 81);
            button2.TabIndex = 24;
            button2.Text = "View timetable";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 128, 185);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(202, 171);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(252, 81);
            button1.TabIndex = 23;
            button1.Text = "Personal Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(73, 42);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(261, 49);
            label8.TabIndex = 22;
            label8.Text = "MyUniversity";
            // 
            // Student_menu
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 588);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Student_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label8;
    }
}