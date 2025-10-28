using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzLock1._0.View
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPage sForm = new StartPage();
            sForm.Show();
            this.Hide();
        }

        private void showPasswordChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
