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
    public partial class Admin_menu : Form
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void Admin_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lst users page
            List_users childForm1 = new List_users();
            childForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // List registered users
            RegisterUser childForm2 = new RegisterUser();
            childForm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Show subject setup form
            Subject_Setup childForm3 = new Subject_Setup();
            childForm3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Back to login screen
            Login childForm5 = new Login();
            childForm5.Show();
            this.Hide();
        }

    }
}
