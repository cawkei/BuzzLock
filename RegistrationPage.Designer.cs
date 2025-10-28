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
            showPasswordChkBox = new CheckBox();
            usernameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            register_Username = new TextBox();
            register_Password = new TextBox();
            register_ConfirmPassword = new TextBox();
            label3 = new Label();
            close_Label = new Label();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.BackColor = Color.Transparent;
            loginLinkLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.LinkColor = Color.Black;
            loginLinkLabel.Location = new Point(335, 515);
            loginLinkLabel.Margin = new Padding(2, 0, 2, 0);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(66, 30); // Remote Size (larger)
            loginLinkLabel.TabIndex = 0;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Login";
            loginLinkLabel.LinkClicked += login_Click;
            // 
            // showPasswordChkBox
            // 
            showPasswordChkBox.AutoSize = true;
            showPasswordChkBox.BackColor = Color.Transparent;
            showPasswordChkBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            showPasswordChkBox.Location = new Point(218, 411); // Remote Location
            showPasswordChkBox.Margin = new Padding(2, 2, 2, 2); // Local Margin
            showPasswordChkBox.Name = "showPasswordChkBox";
            showPasswordChkBox.Size = new Size(172, 32); // Remote Size
            showPasswordChkBox.TabIndex = 1;
            showPasswordChkBox.Text = "Show Password";
            showPasswordChkBox.UseVisualStyleBackColor = false;
            showPasswordChkBox.CheckedChanged += showPasswordChkBox_CheckedChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Location = new Point(84, 138);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(84, 234);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(84, 327);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirm Password";
            // 
            // register_Username
            // 
            register_Username.BackColor = Color.Bisque; // Remote BackColor
            register_Username.BorderStyle = BorderStyle.None; // Remote BorderStyle
            register_Username.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            register_Username.ForeColor = Color.Black; // Remote ForeColor
            register_Username.Location = new Point(106, 177); // Remote Location
            register_Username.Margin = new Padding(2, 2, 2, 2); // Local Margin
            register_Username.Name = "register_Username";
            register_Username.Size = new Size(252, 27); // Remote Size
            register_Username.TabIndex = 5; // Used local TabIndex (since remote's was 2)
            register_Username.Visible = false; // Local Visibility
            register_Username.TextChanged += register_Username_TextChanged; // Local Event Handler
            // 
            // register_Password
            // 
            register_Password.BackColor = Color.Bisque; // Remote BackColor
            register_Password.BorderStyle = BorderStyle.None; // Remote BorderStyle
            register_Password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            register_Password.ForeColor = Color.Black; // Remote ForeColor
            register_Password.Location = new Point(106, 271); // Remote Location
            register_Password.Margin = new Padding(2, 2, 2, 2); // Local Margin
            register_Password.Name = "register_Password";
            register_Password.Size = new Size(252, 27); // Remote Size
            register_Password.TabIndex = 6; // Used local TabIndex (since remote's was 1)
            register_Password.Visible = false; // Local Visibility
            // 
            // register_ConfirmPassword
            // 
            register_ConfirmPassword.BackColor = Color.Bisque; // Remote BackColor
            register_ConfirmPassword.BorderStyle = BorderStyle.None; // Remote BorderStyle
            register_ConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            register_ConfirmPassword.ForeColor = Color.Black; // Remote ForeColor
            register_ConfirmPassword.Location = new Point(106, 364); // Remote Location
            register_ConfirmPassword.Margin = new Padding(2, 2, 2, 2); // Local Margin
            register_ConfirmPassword.Name = "register_ConfirmPassword";
            register_ConfirmPassword.Size = new Size(252, 27); // Remote Size
            register_ConfirmPassword.TabIndex = 7; // Used local TabIndex (since remote's was 0)
            register_ConfirmPassword.Visible = false; // Local Visibility
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            label3.Location = new Point(59, 534); // Remote Location
            label3.Margin = new Padding(2, 0, 2, 0); // Local Margin
            label3.Name = "label3";
            label3.Size = new Size(259, 30); // Remote Size
            label3.TabIndex = 8;
            label3.Text = "Already have an account?";
            // 
            // close_Label
            // 
            close_Label.AutoSize = true;
            close_Label.BackColor = Color.Transparent;
            close_Label.BorderStyle = BorderStyle.Fixed3D;
            close_Label.FlatStyle = FlatStyle.Popup;
            close_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_Label.Location = new Point(455, 9); // Remote Location
            close_Label.Margin = new Padding(2, 0, 2, 0); // Local Margin
            close_Label.Name = "close_Label";
            close_Label.Size = new Size(21, 22);
            close_Label.TabIndex = 9;
            close_Label.Text = "X";
            close_Label.Click += close_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            registerBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(133, 458);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(189, 36);
            registerBtn.TabIndex = 10;
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F); // Kept Local Dimension
            AutoScaleMode = AutoScaleMode.None; // Remote AutoScaleMode
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(486, 625); // Remote ClientSize
            Controls.Add(register_ConfirmPassword);
            Controls.Add(register_Password);
            Controls.Add(register_Username);
            Controls.Add(registerBtn);
            Controls.Add(close_Label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameLabel);
            Controls.Add(showPasswordChkBox);
            Controls.Add(loginLinkLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegistrationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += RegistrationPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel loginLinkLabel;
        private CheckBox showPasswordChkBox;
        private Label usernameLabel;
        private Label label1;
        private Label label2;
        private TextBox register_Username;
        private TextBox register_Password;
        private TextBox register_ConfirmPassword;
        private Label label3;
        private Label close_Label;
        private Button registerBtn;
    }
}