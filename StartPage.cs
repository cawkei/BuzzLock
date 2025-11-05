using BuzzLock;
using BuzzLock1._0.View;
using Microsoft.Data.Sqlite;

namespace BuzzLock1._0
{
    public partial class StartPage : CustomBorderForm
    {
        public StartPage()
        {

            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.StartPosition = FormStartPosition.CenterScreen; 
            InitializeComponent();

            this.AcceptButton = login_BTN;
            login_BTN.FlatStyle = FlatStyle.Flat;
            login_BTN.FlatAppearance.BorderSize = 0;
            login_BTN.FlatAppearance.BorderColor = this.BackColor;
            login_BTN.UseVisualStyleBackColor = false;
            login_BTN.FlatAppearance.BorderColor = this.BackColor;
            login_BTN.UseVisualStyleBackColor = false;
            login_BTN.TabStop = false;

            usernametxt.TabIndex = 0;
            passwordtxt.TabIndex = 1;
            login_BTN.TabIndex = 2;
            register_BTN.TabIndex = 3;
            forgotPasswordLinkLabel.TabIndex = 4;
            showPW_chkbox.TabIndex = 5; // if you want

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '•';

            Color panelGreen = Color.FromArgb(180, 235, 170);
            usernametxt.BorderStyle = BorderStyle.None;
            usernametxt.BackColor = panelGreen;
            usernametxt.ForeColor = Color.Black;

            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.BackColor = panelGreen;
            passwordtxt.ForeColor = Color.Black;

        }
        private void RoundedPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            p.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, 20, 20, 180, 90);
                path.AddArc(p.Width - 20, 0, 20, 20, 270, 90);
                path.AddArc(p.Width - 20, p.Height - 20, 20, 20, 0, 90);
                path.AddArc(0, p.Height - 20, 20, 20, 90, 90);
                path.CloseAllFigures();
                p.Region = new Region(path);
            }
        }

        private void register_BTN_Click(object sender, EventArgs e)
        {
            RegistrationPage sForm = new RegistrationPage();
            sForm.Show();
            this.Hide();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            string userInput = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            if (string.IsNullOrEmpty(userInput) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please enter both username/email and password.", "Warning");
                return;
            }

            try
            {
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();

                    // Check if input looks like an email
                    bool isEmail = userInput.Contains("@");

                    string query;
                    if (isEmail)
                    {
                        query = "SELECT Id, Username, Password FROM Users WHERE Email = @HashedEmail";
                    }
                    else
                    {
                        query = "SELECT Id, Username, Password FROM Users WHERE Username = @Username";
                    }

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        if (isEmail)
                        {
                            string hashedEmail = EmailHasher.HashEmail(userInput);
                            cmd.Parameters.AddWithValue("@HashedEmail", hashedEmail);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Username", userInput);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader.GetString(2);

                                if (PasswordHasher.Verify(password, storedHashedPassword))
                                {
                                    Session.CurrentUserId = reader.GetInt32(0);
                                    Session.CurrentUsername = reader.GetString(1);

                                    VaultForm vaultForm = new VaultForm();
                                    vaultForm.FormClosed += (s, args) => this.Close();
                                    vaultForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    CustomMessageBox.Show("Invalid password.", "Error");
                                }
                            }
                            else
                            {
                                CustomMessageBox.Show("Username or email not found.", "Error");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error: " + ex.Message, "Database Error");
            }
        }




        private void StartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_Password(object sender, EventArgs e)
        {
            if (showPW_chkbox.Checked)
            {
                // Show the actual password
                passwordtxt.PasswordChar = '\0'; // removes masking
            }
            else
            {
                // Hide it again
                passwordtxt.PasswordChar = '•'; // or '*'
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Confirm_Email sForm = new Confirm_Email();
            sForm.Show();
            this.Hide();
        }
    }
}
