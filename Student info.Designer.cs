namespace Assessment_2
{
    partial class Student_info
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
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            button6 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(39, 122);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 376);
            panel1.TabIndex = 36;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(451, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 31);
            label4.TabIndex = 32;
            label4.Text = "label4";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(447, 42);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 42);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 30;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 42);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 41);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 42);
            label2.TabIndex = 28;
            label2.Text = "Full name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 108);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 38);
            textBox2.TabIndex = 26;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(762, 30);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(199, 56);
            button6.TabIndex = 35;
            button6.Text = "Back to menu";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(90, 35);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(350, 42);
            label8.TabIndex = 34;
            label8.Text = "Displaying user info:";
            // 
            // Student_info
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 669);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(label8);
            Margin = new Padding(4);
            Name = "Student_info";
            Text = "Student_info";
            Load += Student_info_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Button button6;
        private Label label8;
    }
}