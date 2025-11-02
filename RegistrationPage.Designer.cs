namespace BuzzLock1._0.View
{
    partial class RegistrationPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage));
            loginLinkLabel = new LinkLabel();
            usernameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            register_Username = new TextBox();
            register_Password = new TextBox();
            register_ConfirmPassword = new TextBox();
            label3 = new Label();
            registerBtn = new Button();
            label4 = new Label();
            showPW_chkbox = new CheckBox();
            label5 = new Label();
            register_Email = new TextBox();
            SuspendLayout();
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.BackColor = Color.Transparent;
            loginLinkLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.Black;
            loginLinkLabel.Location = new Point(336, 534);
            loginLinkLabel.Margin = new Padding(2, 0, 2, 0);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(66, 30);
            loginLinkLabel.TabIndex = 0;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Login";
            loginLinkLabel.LinkClicked += login_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Location = new Point(79, 190);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(83, 271);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(83, 372);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
            // 
            // register_Username
            // 
            register_Username.AcceptsReturn = true;
            register_Username.AcceptsTab = true;
            register_Username.BackColor = Color.Bisque;
            register_Username.BorderStyle = BorderStyle.None;
            register_Username.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_Username.ForeColor = Color.Black;
            register_Username.Location = new Point(83, 228);
            register_Username.Margin = new Padding(2);
            register_Username.Name = "register_Username";
            register_Username.Size = new Size(270, 25);
            register_Username.TabIndex = 0;
            // 
            // register_Password
            // 
            register_Password.AcceptsReturn = true;
            register_Password.AcceptsTab = true;
            register_Password.BackColor = Color.Bisque;
            register_Password.BorderStyle = BorderStyle.None;
            register_Password.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_Password.ForeColor = Color.Black;
            register_Password.Location = new Point(83, 310);
            register_Password.Margin = new Padding(2);
            register_Password.Name = "register_Password";
            register_Password.Size = new Size(270, 25);
            register_Password.TabIndex = 1;
            register_Password.UseSystemPasswordChar = true;
            // 
            // register_ConfirmPassword
            // 
            register_ConfirmPassword.AcceptsReturn = true;
            register_ConfirmPassword.AcceptsTab = true;
            register_ConfirmPassword.BackColor = Color.Bisque;
            register_ConfirmPassword.BorderStyle = BorderStyle.None;
            register_ConfirmPassword.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_ConfirmPassword.ForeColor = Color.Black;
            register_ConfirmPassword.Location = new Point(87, 395);
            register_ConfirmPassword.Margin = new Padding(2);
            register_ConfirmPassword.Name = "register_ConfirmPassword";
            register_ConfirmPassword.Size = new Size(266, 25);
            register_ConfirmPassword.TabIndex = 2;
            register_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 534);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 30);
            label3.TabIndex = 8;
            label3.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            registerBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(133, 476);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(163, 39);
            registerBtn.TabIndex = 10;
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(87, 355);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 11;
            label4.Text = "Confirm Password";
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Cursor = Cursors.Hand;
            showPW_chkbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPW_chkbox.Location = new Point(181, 443);
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(172, 32);
            showPW_chkbox.TabIndex = 12;
            showPW_chkbox.Text = "Show Password";
            showPW_chkbox.UseVisualStyleBackColor = false;
            showPW_chkbox.CheckedChanged += showPW_chkbox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(83, 102);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // register_Email
            // 
            register_Email.AcceptsReturn = true;
            register_Email.AcceptsTab = true;
            register_Email.BackColor = Color.Bisque;
            register_Email.BorderStyle = BorderStyle.None;
            register_Email.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_Email.ForeColor = Color.Black;
            register_Email.Location = new Point(87, 145);
            register_Email.Margin = new Padding(2);
            register_Email.Name = "register_Email";
            register_Email.Size = new Size(270, 25);
            register_Email.TabIndex = 14;
            // 
            // RegistrationPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(466, 599);
            Controls.Add(register_Email);
            Controls.Add(label5);
            Controls.Add(showPW_chkbox);
            Controls.Add(label4);
            Controls.Add(register_ConfirmPassword);
            Controls.Add(register_Password);
            Controls.Add(register_Username);
            Controls.Add(registerBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameLabel);
            Controls.Add(loginLinkLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            Load += RegistrationPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel loginLinkLabel;
        private Label usernameLabel;
        private Label label1;
        private Label label2;
        private TextBox register_Username;
        private TextBox register_Password;
        private TextBox register_ConfirmPassword;
        private Label label3;
        private Button registerBtn;
        private Label label4;
        private CheckBox showPW_chkbox;
        private Label label5;
        private TextBox register_Email;
    }
}