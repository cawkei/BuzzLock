using Microsoft.Data.Sqlite;
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace BuzzLock
{
    public partial class ViewAccountForm : Form
    {
        private int accountId;

        private bool isEditing = false;

        public ViewAccountForm(int id)
        {
            accountId = id;
            InitializeComponent();
            LoadAccountData();
            SetEditMode(false);
        }

        private void LoadAccountData()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Account, Username, EncryptedPassword FROM Vault WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", accountId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtAccount.Text = reader.GetString(0);
                            txtUsername.Text = reader.GetString(1);

                            string encryptedPassword = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            if (!string.IsNullOrEmpty(encryptedPassword))
                                txtPassword.Text = EncryptionHelper.DecryptString(encryptedPassword);
                            else
                                txtPassword.Text = "(Unavailable)";
                        }
                    }
                }
            }
        }

        private void SetEditMode(bool enable)
        {
            isEditing = enable;
            txtAccount.ReadOnly = !enable;
            txtUsername.ReadOnly = !enable;
            txtPassword.ReadOnly = !enable;
            btnSave.Enabled = enable;
            btnEdit.Enabled = !enable;
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
                MessageBox.Show("All fields are required.", "BuzzLock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = PasswordHasher.HashWithArgon2(password);
            string encryptedPassword = EncryptionHelper.EncryptString(password);

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string update = "UPDATE Vault SET Account=@a, Username=@u, Password=@p, EncryptedPassword=@ep WHERE Id=@id";
                    using (var cmd = new SqliteCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", account);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@ep", encryptedPassword);
                        cmd.Parameters.AddWithValue("@id", accountId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account updated successfully!", "BuzzLock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message, "BuzzLock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}