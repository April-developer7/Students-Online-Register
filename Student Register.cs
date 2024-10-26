using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class Student_Register : Form
    {
        public Student_Register()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Back to student menu

            Student_menu childForm1 = new Student_menu();
            childForm1.Show();
            this.Hide();
        }

        private void Student_Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
