using BuzzLock1._0;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzLock
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            // Mask the password fields by default
            newPasstxt.UseSystemPasswordChar = true;
            confirmPasstxt.UseSystemPasswordChar = true;

            // Optional: style button
            resetBTN.FlatStyle = FlatStyle.Flat;
            resetBTN.FlatAppearance.BorderSize = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // not needed, can remove this if unused
        }

        private void showPW_chkbox_click(object sender, EventArgs e)
        {
            // Toggle show/hide password
            bool show = showPW_chkbox.Checked;
            newPasstxt.UseSystemPasswordChar = !show;
            confirmPasstxt.UseSystemPasswordChar = !show;
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            string newPassword = newPasstxt.Text.Trim();
            string confirmPassword = confirmPasstxt.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                CustomMessageBox.Show("Please fill in both fields.", "Warning");
                return;
            }

            // Password strength check
            if (!System.Text.RegularExpressions.Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
            {
                CustomMessageBox.Show("Password must be at least 8 characters long, contain an uppercase letter, a lowercase letter, and a digit.", "Weak Password");
                return;
            }

            // Check password match
            if (newPassword != confirmPassword)
            {
                CustomMessageBox.Show("Passwords do not match.", "Error");
                return;
            }

            // TODO: Add SQL code here to update user's password based on validated email
            // Example:
            // UPDATE Users SET Password = @HashedPassword WHERE Email = @Email;

            CustomMessageBox.Show("Password successfully reset!", "Success");

            // Return to login page
            StartPage loginForm = new StartPage();
            loginForm.Show();
            this.Hide();
        }
    }
}


