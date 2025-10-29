using System;
using System.Windows.Forms;

namespace BuzzLock
{
    public partial class EnterPinForm : CustomBorderForm
    {
        public string EnteredPassword { get; private set; }
        private bool passwordVisible = false; 
        private int attemptCount = 0;
        private const int MaxAttempts = 3;

        public EnterPinForm()
        {
            InitializeComponent();

            passwordTextBox.PasswordChar = '•';
            passwordTextBox.UseSystemPasswordChar = false;
 

            // Trigger submit on Enter key
            passwordTextBox.KeyDown += PasswordTextBox_KeyDown;

            // Assign button click for show/hide password
            showPassButton.Click += ShowPassButton_Click;
            this.Load += EnterPinForm_Load;
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnteredPassword = passwordTextBox.Text.Trim();

                if (string.IsNullOrEmpty(EnteredPassword))
                {
                    CustomMessageBox.Show("Please enter your password.", "Warning");
                    return;
                }

                attemptCount++;

                if (ViewAccountForm.ValidateUserPassword(EnteredPassword))
                {
                    this.DialogResult = DialogResult.OK; //Correct password
                    this.Close();
                }
                else if (attemptCount >= MaxAttempts)
                {
                    CustomMessageBox.Show("Maximum attempts reached. Returning to Vault.", "BuzzLock");
                    this.DialogResult = DialogResult.Cancel; //Max attempts reached
                    this.Close();
                }
                else
                {
                    CustomMessageBox.Show($"Incorrect password. Attempts remaining: {MaxAttempts - attemptCount}", "BuzzLock");
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                //user pressed Esc to cancel and return to Vault
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void ShowPassButton_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            passwordTextBox.PasswordChar = passwordVisible ? '\0' : '•';
        }

        private void EnterPinForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.Focus();
        }
    }
}
