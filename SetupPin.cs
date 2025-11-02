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

    public partial class SetupPin : Form
    {
        private readonly string _username; // Pass this from registration
        private bool pinVisible = false;
        public SetupPin(string username)
        {
            InitializeComponent();
            _username = username;

            setupPintxt.UseSystemPasswordChar = true;
            this.AcceptButton = confirmBTN; // Press Enter to confirm
        }

        private void confirmBTN_click(object sender, EventArgs e)
        {
            string pin = setupPintxt.Text.Trim();

            if (string.IsNullOrEmpty(pin))
            {
                CustomMessageBox.Show("Please enter a PIN.", "Error");
                return;
            }

            //PIN  validation: numeric, 4–6 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(pin, @"^\d{4,6}$"))
            {
                CustomMessageBox.Show("PIN must be 4 to 6 digits.", "Invalid PIN");
                return;
            }

            try
            {
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS VaultPins (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Username TEXT NOT NULL UNIQUE,
                                Pin TEXT NOT NULL
                            );";
                        cmd.ExecuteNonQuery();
                    }

                    //insert or update hashed PIN
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            INSERT INTO VaultPins (Username, Pin)
                            VALUES (@Username, @Pin)
                            ON CONFLICT(Username) DO UPDATE SET Pin = @Pin;";

                        cmd.Parameters.AddWithValue("@Username", _username);
                        cmd.Parameters.AddWithValue("@Pin", PasswordHasher.HashWithArgon2(pin));
                        cmd.ExecuteNonQuery();
                    }
                }

                CustomMessageBox.Show("PIN set successfully!", "Success");

                //redirect to StartPage
                StartPage startForm = new StartPage();
                startForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error saving PIN: " + ex.Message, "Database Error");
            }
        }

        private void BtnShowHde_click(object sender, EventArgs e)
        {
            pinVisible = !pinVisible; // Toggle visibility
            setupPintxt.PasswordChar = pinVisible ? '\0' : '•';
            BtnShowHde.Text = pinVisible ? "Hide" : "Show"; 
        }
    }
}


