using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BuzzLock
{
    public class CustomBorderForm : Form
    {
        public Color BorderColor { get; set; } = Color.Goldenrod;
        public int BorderThickness { get; set; } = 2;

        public CustomBorderForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            AutoScaleMode = AutoScaleMode.None;

            // Redraw border on load and resize
            this.Load += (s, e) => Invalidate();
            this.Resize += (s, e) => Invalidate();

            this.MouseDown += CustomBorderForm_MouseDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw border fully inside the form
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset; // ensures border fits inside
                Rectangle borderRect = new Rectangle(
                    0,
                    0,
                    ClientSize.Width - 1,
                    ClientSize.Height - 1
                );
                e.Graphics.DrawRectangle(pen, borderRect);
            }
        }

        // Dragging the borderless form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void CustomBorderForm_MouseDown(object sender, MouseEventArgs e)
        {
            Control clickedControl = this.GetChildAtPoint(e.Location);

            if (clickedControl == null && e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
