namespace Assessment_2
{
    partial class Student_Register
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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 128, 185);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(437, 513);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(162, 48);
            button1.TabIndex = 32;
            button1.Text = "Register new user";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(56, 87);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 365);
            panel1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 164);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 42);
            label1.TabIndex = 31;
            label1.Text = "Time";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Student", "Teacher" });
            comboBox2.Location = new Point(447, 102);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(425, 39);
            comboBox2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 42);
            label3.TabIndex = 29;
            label3.Text = "Day:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 42);
            label2.TabIndex = 28;
            label2.Text = "Subject:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 164);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 38);
            textBox2.TabIndex = 26;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Teacher" });
            comboBox1.Location = new Point(447, 36);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(425, 39);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(46, 26);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(509, 49);
            label8.TabIndex = 31;
            label8.Text = "Registration: new subject";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(762, 30);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(213, 48);
            button6.TabIndex = 30;
            button6.Text = "Back to menu";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Student_Register
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 588);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(button6);
            Margin = new Padding(4);
            Name = "Student_Register";
            Text = "Student_Register";
            Load += Student_Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label8;
        private Button button6;
        private Label label1;
    }
}