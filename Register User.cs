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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Form saving function

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                // Write to json file, user infomation

                string Scombo = comboBox1.SelectedValue.ToString();
           
                string Lname = "DefaultFirstName";
                string Fname = "DefaultLastName"; ;
                

                File.WriteAllText(@"users.json", Scombo + "," + Fname + "," + Lname);
                

                MessageBox.Show("New user registered!.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // Once finished return to admin menu

                Admin_menu childForm1 = new Admin_menu();
                childForm1.Show();
                this.Hide();

            }
            else
            {
                // Error handling

                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_menu childForm1 = new Admin_menu();
            childForm1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
