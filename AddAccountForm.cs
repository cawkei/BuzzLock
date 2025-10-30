using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace BuzzLock
{
    public partial class AddAccountForm : CustomBorderForm
    {
        private bool isPasswordVisible = false;

        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (cmbAlgorithm.SelectedItem == null)
            {
                CustomMessageBox.Show("Please select a hashing algorithm.", "BuzzLock");
                return;
            }

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("All fields are required.", "BuzzLock");
                return;
            }

            string algorithm = cmbAlgorithm.SelectedItem.ToString();
            string hashedPassword = algorithm == "Argon2" ? PasswordHasher.HashWithArgon2(password)
                                                          : PasswordHasher.HashWithScrypt(password);
            string encryptedPassword = EncryptionHelper.EncryptString(password);

            // Retry parameters
            int retryCount = 5;
            int delay = 300; // milliseconds
            bool success = false;

            while (!success && retryCount > 0)
            {
                try
                {
                    using (var conn = Database.GetConnection())
                    {
                        conn.Open();

                        // Set busy timeout
                        using (var pragmaCmd = conn.CreateCommand())
                        {
                            pragmaCmd.CommandText = "PRAGMA busy_timeout = 5000;";
                            pragmaCmd.ExecuteNonQuery();
                        }

                        // Insert new vault account
                        string insert = @"INSERT INTO Vault 
                                  (Account, Username, Password, EncryptedPassword, Algorithm, UserId)
                                  VALUES (@a, @u, @p, @ep, @alg, @UserId);";

                        using (var cmd = new SqliteCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@a", account);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@p", hashedPassword);
                            cmd.Parameters.AddWithValue("@ep", encryptedPassword);
                            cmd.Parameters.AddWithValue("@alg", algorithm);
                            cmd.Parameters.AddWithValue("@UserId", Session.CurrentUserId);

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
                    CustomMessageBox.Show("Error saving account: " + ex.Message, "BuzzLock");
                    return;
                }
            }

            if (success)
            {
                CustomMessageBox.Show($"Account saved successfully with {algorithm} hashing!", "BuzzLock");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Database is busy. Please try again.", "BuzzLock");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerator_Click(object sender, EventArgs e)
        {
            GeneratorForm1 generator = new GeneratorForm1();
            generator.ShowDialog();
        }
    }
}