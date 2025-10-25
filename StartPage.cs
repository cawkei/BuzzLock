using BuzzLock1._0.View;

namespace BuzzLock1._0
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color panelGreen = Color.FromArgb(180, 235, 170);
            usernametxt.BorderStyle = BorderStyle.None;
            usernametxt.BackColor = panelGreen;
            usernametxt.ForeColor = Color.White;

            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.BackColor = panelGreen;
            passwordtxt.ForeColor = Color.White;


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

        }
    }
}
