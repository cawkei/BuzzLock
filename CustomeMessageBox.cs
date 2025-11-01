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
        private Button btnYes;
        private Button btnNo;

        private CustomMessageBox(string message, string title = "BuzzLock", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            // Form settings
            Text = title;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(255, 222, 89);
            Size = new Size(300, 150);
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;

            // Play alert sound
            SystemSounds.Exclamation.Play();

            // Message label
            lblMessage = new Label
            {
                Text = message,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift Light Condensed", 11),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            Controls.Add(lblMessage);

            // Create buttons
            if (buttons == MessageBoxButtons.OK)
            {
                btnOk = CreateButton("OK", DialogResult.OK);
                Controls.Add(btnOk);
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnYes = CreateButton("Yes", DialogResult.Yes);
                btnNo = CreateButton("No", DialogResult.No);

                btnYes.Location = new Point((ClientSize.Width / 2) - 85, ClientSize.Height - 45);
                btnNo.Location = new Point((ClientSize.Width / 2) + 15, ClientSize.Height - 45);

                Controls.Add(btnYes);
                Controls.Add(btnNo);
            }
        }

        private Button CreateButton(string text, DialogResult result)
        {
            Button btn = new Button
            {
                Text = text,
                BackColor = Color.FromArgb(255, 237, 164),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(70, 28),
                DialogResult = result
            };
            btn.Click += (s, e) => Close();
            btn.Anchor = AnchorStyles.Bottom;
            btn.Location = new Point((ClientSize.Width - btn.Width) / 2, ClientSize.Height - 45);
            return btn;
        }

        // Static methods for convenience
        public static DialogResult Show(string message, string title = "BuzzLock")
        {
            using (var box = new CustomMessageBox(message, title, MessageBoxButtons.OK))
                return box.ShowDialog();
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons buttons)
        {
            using (var box = new CustomMessageBox(message, title, buttons))
                return box.ShowDialog();
        }
    }
}
