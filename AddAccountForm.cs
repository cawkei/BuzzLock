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

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please fill in all fields before saving.", "BuzzLock");
                return;
            }

            if (Session.CurrentUserId == 0)
            {
                CustomMessageBox.Show("Error: User not logged in.", "BuzzLock");
                return;
            }

            string encryptedPassword = EncryptionHelper.EncryptString(password);

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

                        using (var pragmaCmd = conn.CreateCommand())
                        {
                            pragmaCmd.CommandText = "PRAGMA busy_timeout = 5000;";
                            pragmaCmd.ExecuteNonQuery();
                        }

                        string insert = @"INSERT INTO Vault 
                                  (Account, Username, EncryptedPassword, UserId)
                                  VALUES (@a, @u, @ep, @UserId);";

                        using (var cmd = new SqliteCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@a", account);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@ep", encryptedPassword);
                            cmd.Parameters.AddWithValue("@UserId", Session.CurrentUserId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    success = true;
                }
                catch (SqliteException ex) when (ex.SqliteErrorCode == 5)
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
                CustomMessageBox.Show("Account saved successfully!", "BuzzLock");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Failed to save account after multiple attempts.", "BuzzLock");
            }
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

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GeneratorForm1 generator = new GeneratorForm1();
            generator.ShowDialog();
        }
    }
}
