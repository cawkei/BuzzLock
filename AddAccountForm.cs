using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace BuzzLock
{
    public partial class AddAccountForm : Form
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
            string algorithm = cmbAlgorithm.SelectedItem.ToString();
            string hashedPassword = "";

            string encryptedPassword = EncryptionHelper.EncryptString(password);

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required.", "BuzzLock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash according to chosen algorithm
            if (algorithm == "Argon2")
                hashedPassword = PasswordHasher.HashWithArgon2(password);
            else
                hashedPassword = PasswordHasher.HashWithScrypt(password);

            // Save to database
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string insert = "INSERT INTO Vault (Account, Username, Password, EncryptedPassword, Algorithm) VALUES (@a, @u, @p, @ep, @alg)";
                    using (var cmd = new SqliteCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", account);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@ep", encryptedPassword);
                        cmd.Parameters.AddWithValue("@alg", algorithm);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Account saved successfully with {algorithm} hashing!", "BuzzLock",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving account: " + ex.Message, "BuzzLock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}