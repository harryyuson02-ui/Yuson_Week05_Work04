using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuson_Week06_Week05
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Check if Username or Password textboxes are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out both Username and Password fields.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate Username
            if (username != "Shawn")
            {
                MessageBox.Show("Invalid Username!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // 3. Validate Password
            if (password != "Shawn123")
            {
                MessageBox.Show("Invalid Password!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // 4. Show Login Successful message box
            MessageBox.Show("Login Successful!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // 5. Open FormInventory and hide the Login form
            FormInventory inventoryForm = new FormInventory();
            inventoryForm.FormClosed += (s, args) => this.Close();
            inventoryForm.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Code for sign up form if needed
        }

        private void Login_Load(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
    }
}