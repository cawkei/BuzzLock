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
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db;Cache=Shared;Mode=ReadWriteCreate"))
                {
                    conn.Open();

                    // Check if email exists
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Email = @Email;";
                        cmd.Parameters.AddWithValue("@Email", email);
                        long count = (long)cmd.ExecuteScalar();

                        if (count == 0)
                        {
                            CustomMessageBox.Show("No account found with that email address.", "Error");
                            return;
                        }
                    }

                    // If email exists, move to password reset page
                    ForgotPassword resetForm = new ForgotPassword();
                    resetForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }
    }
}
