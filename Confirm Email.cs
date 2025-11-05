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
    public partial class Confirm_Email : Form
    {
        public Confirm_Email()
        {
            InitializeComponent();

            this.AcceptButton = confirmBTN;
            this.FormClosed += Confirm_Email_FormClosed;
            confirmBTN.FlatStyle = FlatStyle.Flat;

            confirmBTN.FlatAppearance.BorderSize = 0;
            confirmBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            confirmBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            confirmBTN.FlatAppearance.CheckedBackColor = Color.Transparent;
            confirmBTN.BackColor = Color.Transparent;
            confirmBTN.UseVisualStyleBackColor = false;
            confirmBTN.TabStop = false;
            confirmBTN.FlatAppearance.BorderColor = this.BackColor;
            confirmBTN.UseVisualStyleBackColor = false;
        }

        private void confirmBTN_click(object sender, EventArgs e)
        {
            string email = confirmEmailtxt.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                CustomMessageBox.Show("Please enter your email address.", "Warning");
                return;
            }

            try
            {
                string hashedEmail = EmailHasher.HashEmail(email);

                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();

                    // 2️⃣ Look for hashed email in the database
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Email = @Email;";
                        cmd.Parameters.AddWithValue("@Email", hashedEmail);
                        long count = (long)cmd.ExecuteScalar();

                        if (count == 0)
                        {
                            CustomMessageBox.Show("No account found with that email address.", "Error");
                            return;
                        }
                    }

                    // if email exists, move to password reset page
                    ForgotPassword resetForm = new ForgotPassword(email);
                    resetForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }
        private void Confirm_Email_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartPage loginForm = new StartPage();
            loginForm.Show();
        }

    }
}
