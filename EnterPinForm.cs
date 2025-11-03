using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace BuzzLock
{
    public partial class EnterPinForm : CustomBorderForm
    {
        // Public property to access the entered PIN
        public string EnteredPassword { get; private set; }

        private readonly string _username; // Current logged-in username
        private bool pinVisible = false;
        private int attemptCount = 0;
        private const int MaxAttempts = 3;
        public int BorderRadius { get; set; } = 20;

        public EnterPinForm(string username)
        {
            InitializeComponent();
            _username = username;

            passwordTextBox.UseSystemPasswordChar = false;
            passwordTextBox.PasswordChar = '*';

            // Trigger submit on Enter key
            passwordTextBox.KeyDown += PasswordTextBox_KeyDown;

            this.Load += EnterPinForm_Load;
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnteredPassword = passwordTextBox.Text.Trim();

                if (string.IsNullOrEmpty(EnteredPassword))
                {
                    CustomMessageBox.Show("Please enter your PIN.", "Warning");
                    return;
                }

                attemptCount++;

                if (ValidateUserPin(EnteredPassword))
                {
                    this.DialogResult = DialogResult.OK; //correct PIN
                    this.Close();
                }
                else if (attemptCount >= MaxAttempts)
                {
                    CustomMessageBox.Show("Maximum attempts reached. Returning to Vault.", "BuzzLock");
                    this.DialogResult = DialogResult.Cancel; //max attempts reached
                    this.Close();
                }
                else
                {
                    CustomMessageBox.Show($"Incorrect PIN. Attempts remaining: {MaxAttempts - attemptCount}", "BuzzLock");
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void EnterPinForm_Load(object sender, EventArgs e)
        {
            SetRoundedCorners();
            passwordTextBox.Focus();
        }

        private void SetRoundedCorners()
        {
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath path = new GraphicsPath();
            int diameter = BorderRadius * 2;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // Validates the entered PIN against the database using PasswordHasher

        private bool ValidateUserPin(string enteredPin)
        {
            try
            {
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Pin FROM VaultPins WHERE Username = @Username;";
                        cmd.Parameters.AddWithValue("@Username", _username);

                        object result = cmd.ExecuteScalar();
                        if (result == null)
                            return false;

                        string storedHash = result.ToString();
                        return PasswordHasher.Verify(enteredPin, storedHash);
                    }
                }
            }
            catch
            {
                //if DB fails, treat as invalid PIN
                return false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
