using System.Text;

namespace BuzzLock
{
    public partial class GeneratorForm1 : CustomBorderForm
    {
        private TextBox txtPassword;
        private CheckBox chkSpecial;
        private CheckBox chkNumbers;
        private CheckBox chkLowercase;
        private CheckBox chkUppercase;
        private Button BtnCopy;
        private Button BtnGenerate;
        private NumericUpDown numericUpDownLength;

        public GeneratorForm1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm1));
            txtPassword = new TextBox();
            chkSpecial = new CheckBox();
            chkNumbers = new CheckBox();
            chkLowercase = new CheckBox();
            chkUppercase = new CheckBox();
            numericUpDownLength = new NumericUpDown();
            BtnCopy = new Button();
            BtnGenerate = new Button();
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
            // chkSpecial
            // 
            chkSpecial.BackColor = Color.Transparent;
            chkSpecial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkSpecial.Location = new Point(502, 277);
            chkSpecial.Name = "chkSpecial";
            chkSpecial.Size = new Size(108, 32);
            chkSpecial.TabIndex = 5;
            chkSpecial.Text = "!@#$%&*";
            chkSpecial.UseVisualStyleBackColor = false;
            chkSpecial.CheckedChanged += chkSpecial_CheckedChanged;
            // 
            // chkNumbers
            // 
            chkNumbers.BackColor = Color.Transparent;
            chkNumbers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNumbers.Location = new Point(376, 277);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(108, 32);
            chkNumbers.TabIndex = 4;
            chkNumbers.Text = "0 - 9";
            chkNumbers.UseVisualStyleBackColor = false;
            chkNumbers.CheckedChanged += chkNumbers_CheckedChanged;
            // 
            // chkLowercase
            // 
            chkLowercase.BackColor = Color.Transparent;
            chkLowercase.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkLowercase.Location = new Point(125, 277);
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
            chkUppercase.Location = new Point(251, 277);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(108, 32);
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
            numericUpDownLength.Location = new Point(660, 280);
            numericUpDownLength.Maximum = new decimal(new int[] { 130, 0, 0, 0 });
            numericUpDownLength.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(108, 26);
            numericUpDownLength.TabIndex = 1;
            numericUpDownLength.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;
            // 
            // BtnCopy
            // 
            BtnCopy.BackColor = Color.Transparent;
            BtnCopy.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCopy.Cursor = Cursors.Hand;
            BtnCopy.FlatAppearance.BorderSize = 0;
            BtnCopy.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnCopy.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnCopy.FlatStyle = FlatStyle.Flat;
            BtnCopy.Location = new Point(719, 183);
            BtnCopy.Margin = new Padding(2);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(69, 75);
            BtnCopy.TabIndex = 16;
            BtnCopy.TabStop = false;
            BtnCopy.UseVisualStyleBackColor = false;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // BtnGenerate
            // 
            BtnGenerate.BackColor = Color.Transparent;
            BtnGenerate.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGenerate.Cursor = Cursors.Hand;
            BtnGenerate.FlatAppearance.BorderSize = 0;
            BtnGenerate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnGenerate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnGenerate.FlatStyle = FlatStyle.Flat;
            BtnGenerate.Location = new Point(647, 199);
            BtnGenerate.Margin = new Padding(2);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(52, 47);
            BtnGenerate.TabIndex = 17;
            BtnGenerate.TabStop = false;
            BtnGenerate.UseVisualStyleBackColor = false;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // GeneratorForm1
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderColor = Color.White;
            ClientSize = new Size(884, 492);
            Controls.Add(BtnGenerate);
            Controls.Add(BtnCopy);
            Controls.Add(numericUpDownLength);
            Controls.Add(chkUppercase);
            Controls.Add(chkLowercase);
            Controls.Add(chkNumbers);
            Controls.Add(chkSpecial);
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
