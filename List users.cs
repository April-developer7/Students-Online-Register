using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static Assessment_2.Login;

namespace Assessment_2
{
    public partial class List_users : Form
    {
        public List_users()
        {
            InitializeComponent();
        }

        private void List_users_Load(object sender, EventArgs e)
        {
            // Bind json data here to display 
            string json = File.ReadAllText(@"users.json");
            // Load data into data table
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Go beck to the admin menu
            Admin_menu childForm1 = new Admin_menu();
            childForm1.Show();
            this.Hide();
        }

        public class USERLOGIN
        {
            // JSON class converter

            public string username { get; set; }
            public string password { get; set; }
            public string role { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search for user from user input from the JSON file

            if (textBox1.Text != string.Empty)
            {

                string userName = textBox1.Text;

                string json = File.ReadAllText("users.json");
                var usersDB = JsonConvert.DeserializeObject<List<USERLOGIN>>(json);

                var loginUSER = from login in usersDB
                                where login.username == userName
                                select login;

            }
            else
            {
                // Error handling 
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
