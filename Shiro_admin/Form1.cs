using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Admin_Rolly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login__Click(object sender, EventArgs e)
        {
            if (Password_.Text == "super admin" && ID_.Text == "super admin")
            {

                Main_Dashboard Admin = new Main_Dashboard();
                this.Hide();
                Admin.Show();
            }
            else if (Password_.Text == "admin" && ID_.Text == "admin")
            {
                Main_Dashboard Admin = new Main_Dashboard();
                this.Hide();
                Admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
