using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace BuzzLock
{
    public partial class ViewAccountForm : Form
    {
        private int accountId;
        private bool isEditing = false;

        public ViewAccountForm(int id)
        {
            InitializeComponent();
            accountId = id;
            StartPosition = FormStartPosition.CenterParent;

            LoadAccountData();
            SetEditMode(false);
        }

        /// <summary>
        /// Opens ViewAccountForm after verifying user's PIN.
        /// </summary>
        public static void OpenWithPinVerification(int accountId, Form parent)
        {
            int attempts = 0;
            bool verified = false;

            while (attempts < 3 && !verified)
            {
                using (var pinForm = new EnterPinForm(Session.CurrentUsername)) // pass username
                {
                    var result = pinForm.ShowDialog(parent); // modal over parent

                    if (result != DialogResult.OK)
                        return; // user cancelled or closed form

                    if (ValidateUserPin(pinForm.EnteredPassword))
                    {
                        verified = true;
                        break;
                    }
                    else
                    {
                        attempts++;
                        if (attempts < 3)
                            CustomMessageBox.Show($"Incorrect PIN. Attempts remaining: {3 - attempts}", "BuzzLock");
                    }
                }
            }

            if (verified)
            {
                using (var viewForm = new ViewAccountForm(accountId))
                {
                    viewForm.ShowDialog(parent);
                }
            }
            else
            {
                CustomMessageBox.Show("Maximum attempts reached. Access denied.", "BuzzLock");
            }
        }

        /// <summary>
        /// Validates entered PIN against stored hash.
        /// </summary>
        public static bool ValidateUserPin(string inputPin)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Pin FROM Users WHERE Id = @userId";
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                        string storedHash = cmd.ExecuteScalar() as string;
                        if (string.IsNullOrEmpty(storedHash))
                            return false;

                        return PasswordHasher.Verify(inputPin, storedHash);
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void LoadAccountData()
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

                    string query = "SELECT Account, Username, EncryptedPassword FROM Vault WHERE Id = @id AND UserId = @userId";
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", accountId);
                        cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtAccount.Text = reader.GetString(0);
                                txtUsername.Text = reader.GetString(1);

                                string encryptedPassword = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                txtPassword.Text = !string.IsNullOrEmpty(encryptedPassword)
                                    ? EncryptionHelper.DecryptString(encryptedPassword)
                                    : "(Unavailable)";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error loading account: " + ex.Message, "BuzzLock");
            }
        }

        private void SetEditMode(bool enable)
        {
            isEditing = enable;
            txtAccount.ReadOnly = !enable;
            txtUsername.ReadOnly = !enable;
            txtPassword.ReadOnly = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("All fields are required.", "BuzzLock");
                return;
            }

            string encryptedPassword = EncryptionHelper.EncryptString(password);

            int retryCount = 5;
            int delay = 300;
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

                        string update = @"UPDATE Vault 
                                          SET Account = @a, Username = @u, EncryptedPassword = @ep 
                                          WHERE Id = @id AND UserId = @userId";

                        using (var cmd = new SqliteCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@a", account);
                            cmd.Parameters.AddWithValue("@u", username);
                            cmd.Parameters.AddWithValue("@ep", encryptedPassword);
                            cmd.Parameters.AddWithValue("@id", accountId);
                            cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
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
                    CustomMessageBox.Show("Error updating account: " + ex.Message, "BuzzLock");
                    return;
                }
            }

            if (success)
            {
                CustomMessageBox.Show("Account updated successfully!", "BuzzLock");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Database is busy. Please try again.", "BuzzLock");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void close_BTN_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
            }
            else
            {
                CustomMessageBox.Show("No password to copy. Generate one first.", "BuzzLock");
            }
        }
    }
}
