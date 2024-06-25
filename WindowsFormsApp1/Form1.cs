using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminEmail = "thantzawhtet997@gmail.com";
            string adminPassword = "@Youn311221";

            string email = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields....", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (adminEmail.Equals(email) || adminPassword.Equals(password))
            {
                MessageBox.Show("Login Successful....", "Information!");
            }
            else 
            { 
                MessageBox.Show("Username and Password are not correct....", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
