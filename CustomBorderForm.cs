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
            AutoScaleMode = AutoScaleMode.None; // prevents DPI scaling issues
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawRectangle(pen,
                    BorderThickness / 2,
                    BorderThickness / 2,
                    ClientSize.Width - BorderThickness,
                    ClientSize.Height - BorderThickness);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void CustomBorderForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    }
}
