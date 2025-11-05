using BuzzLock;
using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            this.FormClosed += RegistrationPage_FormClosed;

        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.BorderColor = this.BackColor;
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.TabStop = false;

            this.AcceptButton = registerBtn; // Enter key triggers register button

            // Tab order
            register_Email.TabIndex = 0;
            register_Username.TabIndex = 1;
            register_Password.TabIndex = 2;
            register_ConfirmPassword.TabIndex = 3;
            registerBtn.TabIndex = 4;
            loginLinkLabel.TabIndex = 5;
            showPW_chkbox.TabIndex = 6;

            // Password masking
            register_Password.UseSystemPasswordChar = true;
            register_ConfirmPassword.UseSystemPasswordChar = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string email = register_Email.Text.Trim();
            string username = register_Username.Text.Trim();
            string password = register_Password.Text.Trim();
            string confirmPassword = register_ConfirmPassword.Text.Trim();

            //basic validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                CustomMessageBox.Show("Please fill in all fields.", "Warning");
                return;
            }

            //email format validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                CustomMessageBox.Show("Please enter a valid email address.", "Invalid Email");
                return;
            }

            //password match check
            if (password != confirmPassword)
            {
                CustomMessageBox.Show("Passwords do not match.", "Error");
                return;
            }

            //password strength validation
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
            {
                CustomMessageBox.Show("Password must be at least 8 characters long, contain an uppercase letter, a lowercase letter, and a digit.", "Weak Password");
                return;
            }

            //hash email deterministically (SHA256)
            string hashedEmail = EmailHasher.HashEmail(email);

            //retry parameters
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
                                    Email TEXT NOT NULL UNIQUE,
                                    Username TEXT NOT NULL UNIQUE,
                                    Password TEXT NOT NULL
                                );";
                            cmd.ExecuteNonQuery();
                        }

                        // Check if email or username already exists
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email;";
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Email", hashedEmail);
                            long count = (long)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                CustomMessageBox.Show("Email or Username already exists.", "Error");
                                return;
                            }
                        }

                        // Insert new user
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Users (Email, Username, Password) VALUES (@Email, @Username, @Password);";
                            cmd.Parameters.AddWithValue("@Email", hashedEmail);
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
                    System.Threading.Thread.Sleep(delay);
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

                //open SetupPin form for the newly registered user
                SetupPin pinForm = new SetupPin(username); // <-- pass username here
                pinForm.ShowDialog();
                this.Close();
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
        private void RegistrationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartPage loginForm = new StartPage();
            loginForm.Show();
        }
    }
}
