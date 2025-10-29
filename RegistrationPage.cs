using BuzzLock;
using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuzzLock1._0.View
{
    public partial class RegistrationPage : CustomBorderForm
    {
        public RegistrationPage()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.BorderColor = this.BackColor;
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.TabStop = false;


            // Enter key triggers register button
            this.AcceptButton = registerBtn;

            // Tab order
            register_Username.TabIndex = 0;
            register_Password.TabIndex = 1;
            register_ConfirmPassword.TabIndex = 2;
            registerBtn.TabIndex = 3;
            loginLinkLabel.TabIndex = 4;
            showPW_chkbox.TabIndex = 5;

            // Password masking
            register_Password.UseSystemPasswordChar = true;
            register_ConfirmPassword.UseSystemPasswordChar = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = register_Username.Text.Trim();
            string password = register_Password.Text.Trim();
            string confirmPassword = register_ConfirmPassword.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                CustomMessageBox.Show("Please fill in all fields.", "Warning");
                return;
            }

            if (password != confirmPassword)
            {
                CustomMessageBox.Show("Passwords do not match.", "Error");
                return;
            }

            // Retry parameters
            int retryCount = 5;
            int delay = 300; // milliseconds
            bool success = false;

            while (!success && retryCount > 0)
            {
                try
                {
                    using (var conn = new SqliteConnection("Data Source=BuzzLock.db;Cache=Shared;Mode=ReadWriteCreate"))
                    {
                        conn.Open();

                        // Busy timeout to wait if database is locked
                        using (var pragmaCmd = conn.CreateCommand())
                        {
                            pragmaCmd.CommandText = "PRAGMA busy_timeout = 5000;";
                            pragmaCmd.ExecuteNonQuery();
                        }

                        // Create Users table if it doesn't exist
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL
                        );";
                            cmd.ExecuteNonQuery();
                        }

                        // Check if username already exists
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
                            cmd.Parameters.AddWithValue("@Username", username);
                            long count = (long)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                CustomMessageBox.Show("Username already exists.", "Error");
                                return;
                            }
                        }

                        // Insert new user with hashed password
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password);";
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", PasswordHasher.HashWithArgon2(password));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    success = true;
                }
                catch (SqliteException ex) when (ex.SqliteErrorCode == 5) // SQLITE_BUSY
                {
                    retryCount--;
                    System.Threading.Thread.Sleep(delay); // wait before retry
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Error: " + ex.Message, "Database Error");
                    return;
                }
            }

            if (success)
            {
                CustomMessageBox.Show("Registration successful!", "Success");
                StartPage sForm = new StartPage();
                sForm.Show();
                this.Hide();
            }
            else
            {
                CustomMessageBox.Show("Database is busy. Please try again.", "Error");
            }
        }


        private void login_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPage loginForm = new StartPage();
            loginForm.Show();
            this.Hide();
        }

        private void showPW_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool show = showPW_chkbox.Checked;
            register_Password.UseSystemPasswordChar = !show;
            register_ConfirmPassword.UseSystemPasswordChar = !show;
        }
    }
}
