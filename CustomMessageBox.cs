using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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

            // Form settings
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

            // Sound effect
            SystemSounds.Exclamation.Play();

            // Message label
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

            // Buttons
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
                int totalWidth = btnYes.Width + btnNo.Width + spacing;
                int startX = (ClientSize.Width - totalWidth) / 2;
                int y = ClientSize.Height - 35;

                btnYes.Location = new Point(startX, y);
                btnNo.Location = new Point(startX + btnYes.Width + spacing, y);
            }
        }

        private Button CreateButton(string text, DialogResult result)
        {
            Button btn = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(100, 35),
                DialogResult = result,
                Anchor = AnchorStyles.None,
                BackColor = Color.FromArgb(255, 237, 164),
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift SemiBold", 10F),
                Cursor = Cursors.Hand
            };

            btn.Paint += (s, e) =>
            {
                Button b = (Button)s;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (SolidBrush brush = new SolidBrush(b.BackColor))
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 10;
                    Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    e.Graphics.FillPath(brush, path);
                }

                Rectangle textRect = b.ClientRectangle;
                textRect.Y += 3; // move text 1 pixel down
                TextRenderer.DrawText(e.Graphics, b.Text, b.Font, textRect, b.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            //hover effect
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(255, 245, 190);
                btn.Invalidate();
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(255, 237, 164);
                btn.Invalidate();
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
