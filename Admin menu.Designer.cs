namespace Assessment_2
{
    partial class Admin_menu
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
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(73, 42);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(360, 49);
            label8.TabIndex = 11;
            label8.Text = "Welcome admin:";
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
            button1.TabIndex = 15;
            button1.Text = "List all registered users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.TabIndex = 16;
            button2.Text = "Register new student / teacher";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(45, 128, 185);
            button4.FlatAppearance.BorderSize = 0;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(219, 316);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(252, 81);
            button4.TabIndex = 18;
            button4.Text = "Subject setup";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            button6.TabIndex = 20;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Admin_menu
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 588);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Admin_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_menu";
            Load += Admin_menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button6;
    }
}