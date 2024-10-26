using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;
using Newtonsoft.Json;


namespace Assessment_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Open up the json file to be read here
            textBox1.Focus();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // End application
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // Username login styling
            textBox1.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            textBox1.MaxLength = 30;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            // Password login styling
            textBox1.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox2.MaxLength = 30;
        }

        // Login class sorting

        public class USERLOGIN
        {
            public string UserId { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }


        // Anonymous method 
        // Creating the Anonymous method 
        public delegate void QLOGIN(string userName, string passWord);

        // Creating the Login checker method
        class LOGINCHECK
        {
            public void query(string userName, string passWord)
            {
                string json = File.ReadAllText("users.json");
                var usersDB = JsonConvert.DeserializeObject<List<USERLOGIN>>(json);

                // var loginUSER = usersDB.Where(l => username == userName && password == passWord);

            }
        }
        public USERLOGIN ValidateUser(string userId, string password)
        {
            try
            {
                // Read user data from the JSON file
                string json = File.ReadAllText("users.json");
                var usersDB = JsonConvert.DeserializeObject<List<USERLOGIN>>(json);

                // Validate user by UserId and Password using LINQ
                var matchedUser = usersDB.FirstOrDefault(user => user.UserId == userId && user.Password == password);

                // Return the matched user if found, otherwise return null
                return matchedUser;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The users.json file was not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; // Return null if any error occurs or user is not found
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                // Use input fields as strings
                string userName = textBox1.Text;
                string passWord = textBox2.Text;

                // Call ValidateUser method to check if the user exists
                USERLOGIN loggedInUser = ValidateUser(userName, passWord);

                if (loggedInUser != null)
                {
                    // Use switch statement to navigate based on user role
                    switch (loggedInUser.Role)
                    {
                        case "Admin":
                            Admin_menu adminForm = new Admin_menu();
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "Teacher":
                            Teacher_menu teacherForm = new Teacher_menu();
                            teacherForm.Show();
                            this.Hide();
                            break;
                        case "Student":
                            Student_menu studentForm = new Student_menu();
                            studentForm.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Unknown user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



      
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
