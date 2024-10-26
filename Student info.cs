using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class Student_info : Form
    {
        public Student_info()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Return back to menu

            Student_menu childForm1 = new Student_menu();
            childForm1.Show();
            this.Hide();
        }

        private void Student_info_Load(object sender, EventArgs e)
        {
            // Display student info

            string jsonFile = File.ReadAllText(@"student.json");
            var json = JsonConvert.DeserializeObject<StudentInfo>(jsonFile);
            // get some logic here for the current user login
            label1.Text = json.studentInfo[0].name;
            label4.Text = json.studentInfo[0].email;
            label5.Text = json.studentInfo[0].dateOfBirth;
            label6.Text = json.studentInfo[0].gender;
            label7.Text = json.studentInfo[0].address;
            label9.Text = json.studentInfo[0].phoneNumber;
        }
        public class details
        {
            // Class for JSON file database 

            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string dateOfBirth { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string phoneNumber { get; set; }
            public int enrollmentYear { get; set; }
            public string major { get; set; }

        }
        public class StudentInfo
        {
            // List for each of the student values

            public List<details> studentInfo { get; set; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
