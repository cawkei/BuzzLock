using BuzzLock1._0;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace BuzzLock
{
    public partial class ForgotPassword : Form
    {
        private string verifiedEmail; // store the confirmed email from Confirm_Email

        public ForgotPassword(string email)
        {
            InitializeComponent();
            verifiedEmail = email;
            this.FormClosed += ForgotPassword_FormClosed ;

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            newPasstxt.UseSystemPasswordChar = true;
            confirmPasstxt.UseSystemPasswordChar = true;

            resetBTN.FlatStyle = FlatStyle.Flat;
            resetBTN.FlatAppearance.BorderSize = 0;
            resetBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resetBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resetBTN.FlatAppearance.CheckedBackColor = Color.Transparent;
            resetBTN.BackColor = Color.Transparent;
            resetBTN.UseVisualStyleBackColor = false;
            resetBTN.TabStop = false;
            resetBTN.FlatAppearance.BorderColor = this.BackColor;

            resetBTN.BringToFront();

            this.AcceptButton = resetBTN;
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

            try
            {
                string hashedEmail = EmailHasher.HashEmail(verifiedEmail);
                string hashedPassword = PasswordHasher.HashWithArgon2(newPassword);

                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Users SET Password = @Password WHERE Email = @Email;";
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", hashedEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            CustomMessageBox.Show("Password successfully reset!", "Success");
                            StartPage loginForm = new StartPage();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            CustomMessageBox.Show("No matching account found to update.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }

        // show/hide password
        private void showPW_chkbox_click(object sender, EventArgs e)
        {
            bool show = showPW_chkbox.Checked;
            newPasstxt.UseSystemPasswordChar = !show;
            confirmPasstxt.UseSystemPasswordChar = !show;
        }

        // When user closes this form, go back to login page
        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartPage loginForm = new StartPage();
            loginForm.Show();
        }
    }
}
