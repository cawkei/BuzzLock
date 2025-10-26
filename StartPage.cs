using BuzzLock1._0.View;
using Microsoft.Data.Sqlite;

namespace BuzzLock1._0
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(1176, 654);
            this.MaximumSize = new Size(1176, 654);
            this.MinimumSize = new Size(1176, 654);
            this.StartPosition = FormStartPosition.CenterScreen; // center when opened

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


            usernametxt.TabStop = false;
            passwordtxt.TabStop = false;

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
            string username = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db"))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password;";
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // optionally hash later

                        long count = (long)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 🔹 Open your next form here (e.g., Dashboard)
                            // DashboardPage dash = new DashboardPage();
                            // dash.Show();
                            // this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void close_Click(object sender, EventArgs e)
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

        }
    }
}
