using System.Text;

namespace BuzzLock
{
    public partial class GeneratorForm1 : CustomBorderForm
    {
        private TextBox txtPassword;
        private Button btnGenerate;
        private CheckBox chkSpecial;
        private CheckBox chkNumbers;
        private CheckBox chkLowercase;
        private CheckBox chkUppercase;
        private NumericUpDown numericUpDownLength;
        private Button btnCopy;

        public GeneratorForm1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm1));
            txtPassword = new TextBox();
            btnCopy = new Button();
            btnGenerate = new Button();
            chkSpecial = new CheckBox();
            chkNumbers = new CheckBox();
            chkLowercase = new CheckBox();
            chkUppercase = new CheckBox();
            numericUpDownLength = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(126, 217, 87);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bahnschrift SemiBold Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(101, 199);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(530, 47);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Transparent;
            btnCopy.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.ForeColor = Color.Transparent;
            btnCopy.Location = new Point(726, 193);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(56, 59);
            btnCopy.TabIndex = 7;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += BtnCopy_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.BackgroundImageLayout = ImageLayout.None;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = Color.Transparent;
            btnGenerate.Location = new Point(651, 199);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(40, 47);
            btnGenerate.TabIndex = 6;
            btnGenerate.UseMnemonic = false;
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // chkSpecial
            // 
            chkSpecial.BackColor = Color.Transparent;
            chkSpecial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkSpecial.Location = new Point(488, 272);
            chkSpecial.Name = "chkSpecial";
            chkSpecial.Size = new Size(108, 31);
            chkSpecial.TabIndex = 5;
            chkSpecial.Text = "!@#$%&*";
            chkSpecial.UseVisualStyleBackColor = false;
            chkSpecial.CheckedChanged += chkSpecial_CheckedChanged;
            // 
            // chkNumbers
            // 
            chkNumbers.BackColor = Color.Transparent;
            chkNumbers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNumbers.Location = new Point(356, 272);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(108, 31);
            chkNumbers.TabIndex = 4;
            chkNumbers.Text = "0 - 9";
            chkNumbers.UseVisualStyleBackColor = false;
            chkNumbers.CheckedChanged += chkNumbers_CheckedChanged;
            // 
            // chkLowercase
            // 
            chkLowercase.BackColor = Color.Transparent;
            chkLowercase.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkLowercase.Location = new Point(101, 271);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(108, 32);
            chkLowercase.TabIndex = 3;
            chkLowercase.Text = "a - z";
            chkLowercase.UseVisualStyleBackColor = false;
            chkLowercase.CheckedChanged += chkLowercase_CheckedChanged;
            // 
            // chkUppercase
            // 
            chkUppercase.BackColor = Color.Transparent;
            chkUppercase.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            chkUppercase.Location = new Point(215, 271);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(108, 27);
            chkUppercase.TabIndex = 2;
            chkUppercase.Text = "A - Z";
            chkUppercase.UseVisualStyleBackColor = false;
            chkUppercase.CheckedChanged += chkUppercase_CheckedChanged;
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.BackColor = Color.White;
            numericUpDownLength.BorderStyle = BorderStyle.None;
            numericUpDownLength.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            numericUpDownLength.Location = new Point(641, 272);
            numericUpDownLength.Maximum = new decimal(new int[] { 130, 0, 0, 0 });
            numericUpDownLength.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(108, 31);
            numericUpDownLength.TabIndex = 1;
            numericUpDownLength.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;
            // 
            // GeneratorForm1
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 492);
            Controls.Add(btnGenerate);
            Controls.Add(numericUpDownLength);
            Controls.Add(chkUppercase);
            Controls.Add(chkLowercase);
            Controls.Add(chkNumbers);
            Controls.Add(chkSpecial);
            Controls.Add(btnCopy);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GeneratorForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //Generation button
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int length = (int)numericUpDownLength.Value;
                bool useUpper = chkUppercase.Checked;
                bool useLower = chkLowercase.Checked;
                bool useNumbers = chkNumbers.Checked;
                bool useSpecial = chkSpecial.Checked;

                string password = GeneratePassword(length, useUpper, useLower, useNumbers, useSpecial);
                txtPassword.Text = password;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error: " + ex.Message, "BuzzLock");
            }
        }

        //Copy button
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                CustomMessageBox.Show("Password copied to clipboard.", "BuzzLock");
            }
            else
            {
                CustomMessageBox.Show("No password to copy. Generate one first.", "BuzzLock");
            }
        }


        // Password generation logic
        private string GeneratePassword(int length, bool useUpper, bool useLower, bool useNumbers, bool useSpecial)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string special = "!@#$%^&*()-_=+[]{}|;:,.<>?";

            StringBuilder pool = new StringBuilder();
            if (useUpper) pool.Append(upper);
            if (useLower) pool.Append(lower);
            if (useNumbers) pool.Append(numbers);
            if (useSpecial) pool.Append(special);

            if (pool.Length == 0)
                throw new InvalidOperationException("Select at least one character set.");

            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                char[] pw = new char[length];
                byte[] buffer = new byte[4];

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer); //fills the 4-byte array with random values. ex: [123, 94, 210, 56]
                    uint num = BitConverter.ToUInt32(buffer, 0); //converts 4 bytes into a single 32-bit unsigned integer
                    long idx = num % pool.Length; //make <num> stays within the range of the pool
                    pw[i] = pool[(int)idx]; //<idx> represents a possible character to include in password
                }

                return new string(pw);
            }
        }

        private void chkLowercase_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownLength_ValueChanged(object sender, EventArgs e)
        {

        }


        private void chkUppercase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNumbers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
