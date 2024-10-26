namespace Assessment_2
{
    partial class List_users
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
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 128, 185);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(562, 98);
            button1.Name = "button1";
            button1.Size = new Size(139, 33);
            button1.TabIndex = 39;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 31);
            textBox1.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(27, 96);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 37;
            label1.Text = "Enter ID or name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(647, 303);
            dataGridView1.TabIndex = 36;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 128, 185);
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(547, 35);
            button6.Name = "button6";
            button6.Size = new Size(142, 45);
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
            label8.Location = new Point(67, 39);
            label8.Name = "label8";
            label8.Size = new Size(334, 32);
            label8.TabIndex = 34;
            label8.Text = "Listing all registered users:";
            // 
            // List_users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 474);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(label8);
            Name = "List_users";
            Text = "List_users";
            Load += List_users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button6;
        private Label label8;
    }
}