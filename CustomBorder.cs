using System.Drawing.Drawing2D;

public class CustomBorderForm : Form
{
    public CustomBorderForm()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.Padding = new Padding(4); // Add padding so content doesn’t overlap border
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int borderThickness = 4;
        int cornerRadius = 15;
        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

        using (GraphicsPath path = new GraphicsPath())
        {
            int diameter = cornerRadius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseAllFigures();

            // Honey amber gradient border
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 180, 0), // bright honey orange
                Color.FromArgb(230, 130, 0), // deeper amber
                LinearGradientMode.ForwardDiagonal))
            using (Pen pen = new Pen(brush, borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Optional glow outline
            using (Pen glowPen = new Pen(Color.FromArgb(40, 255, 200, 0), 8))
            {
                e.Graphics.DrawPath(glowPen, path);
            }
        }
    }
}
