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
        private MessageBoxButtons buttonType;

        private CustomMessageBox(string message, string title = "BuzzLock", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            buttonType = buttons;

            // Basic window setup
            Text = title;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(255, 222, 89); // solid honey yellow
            Size = new Size(300, 150);
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            DoubleBuffered = true;

            //Sound
            SystemSounds.Exclamation.Play();

            //Message 
            lblMessage = new Label
            {
                Text = message,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift Light Condensed", 11),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(280, 60),
                Location = new Point(10, 15)
            };
            Controls.Add(lblMessage);

            //Buttons 
            if (buttons == MessageBoxButtons.OK)
            {
                btnOk = CreateButton("OK", DialogResult.OK);
                Controls.Add(btnOk);
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnYes = CreateButton("Yes", DialogResult.Yes);
                btnNo = CreateButton("No", DialogResult.No);
                Controls.Add(btnYes);
                Controls.Add(btnNo);
            }

            Load += CustomMessageBox_Load;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            if (buttonType == MessageBoxButtons.OK && btnOk != null)
            {
                btnOk.Location = new Point((ClientSize.Width - btnOk.Width) / 2, ClientSize.Height - 45);
            }
            else if (buttonType == MessageBoxButtons.YesNo && btnYes != null && btnNo != null)
            {
                int spacing = 15;
                btnYes.Location = new Point((ClientSize.Width / 2) - btnYes.Width - spacing, ClientSize.Height - 45);
                btnNo.Location = new Point((ClientSize.Width / 2) + spacing, ClientSize.Height - 45);
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
                DialogResult = result,
                Anchor = AnchorStyles.Bottom
            };
            btn.Click += (s, e) => Close();
            return btn;
        }

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
