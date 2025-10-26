using System;
using System.Data;
using Microsoft.Data.Sqlite; // Using Microsoft.Data.Sqlite
using System.Windows.Forms;

namespace BuzzLock1._0.View
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();


            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(493, 627);
            this.MaximumSize = new Size(493, 627);
            this.MinimumSize = new Size(493, 627);
            this.StartPosition = FormStartPosition.CenterScreen; // centers the form

        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            register_Password.PasswordChar = '•';
            register_ConfirmPassword.PasswordChar = '•';
            register_Username.UseSystemPasswordChar = false;
            register_Username.PasswordChar = '\0';


        }

        // 🔹 Register button click
        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = register_Username.Text.Trim();
            string password = register_Password.Text.Trim();
            string confirmPassword = register_ConfirmPassword.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();

                    // Check if Users table exists; create if not
                    string createTable = @"
                        CREATE TABLE IF NOT EXISTS Users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL
                        );
                    ";
                    using (var cmd = new SqliteCommand(createTable, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Check if username already exists
                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
                    using (var checkCmd = new SqliteCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
#pragma warning disable CS8605 // Unboxing a possibly null value.
                        long count = (long)checkCmd.ExecuteScalar();
#pragma warning restore CS8605 // Unboxing a possibly null value.

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password);";
                    using (var insertCmd = new SqliteCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password); // Can encrypt later
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to login page
                    StartPage sForm = new StartPage();
                    sForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Redirect to login
        private void login_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPage sForm = new StartPage();
            sForm.Show();
            this.Hide();
        }

        // 🔹 Show/Hide password checkbox
        private void showPasswordChkBox_CheckedChanged(object sender, EventArgs e)
        {
            bool show = showPasswordChkBox.Checked;
            register_Password.PasswordChar = show ? '\0' : '•';
            register_ConfirmPassword.PasswordChar = show ? '\0' : '•';
        }

        // 🔹 Close the form
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
