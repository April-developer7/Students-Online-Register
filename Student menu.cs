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
    public partial class Student_menu : Form
    {
        public Student_menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Back to login page

            Login childForm1 = new Login();
            childForm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Student info page
           Student_info childForm2 = new Student_info();
            childForm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Student timetable

            Student_Timetable childForm3 = new Student_Timetable();
            childForm3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Student registering in subjects
            Student_Register childForm4 = new Student_Register();
            childForm4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Student subject showing

            Student_Subjects childForm5 = new Student_Subjects();
            childForm5.Show();
            this.Hide();
        }
    }
}
