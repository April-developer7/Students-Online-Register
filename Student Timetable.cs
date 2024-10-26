using Newtonsoft.Json;
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
    public partial class Student_Timetable : Form
    {
        public Student_Timetable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Back to student menu

            Student_menu childForm1 = new Student_menu();
            childForm1.Show();
            this.Hide();
        }

        private void Student_Timetable_Load(object sender, EventArgs e)
        {
            // Bind json data here to display 
            string json = File.ReadAllText(@"timetable.json");

            // Load data into data table
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
