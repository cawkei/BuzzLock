using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BuzzLock
{
    public class CustomMessageBox : Form
    {
        private Label lblMessage;
        private Button btnOk;

        /// <summary>
        /// Creates a custom message box with honeycomb theme colors.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="title">Window title.</param>
        public CustomMessageBox(string message, string title = "BuzzLock")
        {
            // Form settings
            this.Text = title;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(255, 222, 89); // honeycomb background
            this.Size = new Size(280, 130);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            // Play alert sound
            SystemSounds.Exclamation.Play();

            // Message Label
            lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.ForeColor = Color.Black;
            lblMessage.Font = new Font("Bahnschrift Light Condensed", 10);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Padding = new Padding(10);

            // OK Button
            btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.BackColor = Color.FromArgb(255, 237, 164); // honeycomb accent
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Size = new Size(70, 28);
            btnOk.Location = new Point((this.ClientSize.Width - btnOk.Width) / 2, this.ClientSize.Height - 40);
            btnOk.Anchor = AnchorStyles.Bottom;
            btnOk.Click += (s, e) => this.Close();

            // Add controls
            this.Controls.Add(lblMessage);
            this.Controls.Add(btnOk);
        }

        /// <summary>
        /// Shows the custom message box modally.
        /// </summary>
        public static void Show(string message, string title = "BuzzLock")
        {
            using (var box = new CustomMessageBox(message, title))
            {
                box.ShowDialog();
            }
        }
    }
}
