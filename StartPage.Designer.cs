namespace BuzzLock1._0
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            register_BTN = new Button();
            login_BTN = new Button();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            showPW_chkbox = new CheckBox();
            forgotPasswordLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // register_BTN
            // 
            register_BTN.BackColor = Color.Transparent;
            register_BTN.BackgroundImageLayout = ImageLayout.Center;
            register_BTN.Cursor = Cursors.Hand;
            register_BTN.FlatAppearance.BorderSize = 0;
            register_BTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            register_BTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            register_BTN.FlatStyle = FlatStyle.Flat;
            register_BTN.ForeColor = Color.Transparent;
            register_BTN.Location = new Point(74, 298);
            register_BTN.Margin = new Padding(2);
            register_BTN.Name = "register_BTN";
            register_BTN.Size = new Size(119, 27);
            register_BTN.TabIndex = 0;
            register_BTN.TabStop = false;
            register_BTN.UseMnemonic = false;
            register_BTN.UseVisualStyleBackColor = false;
            register_BTN.Click += register_BTN_Click;
            // 
            // login_BTN
            // 
            login_BTN.BackColor = Color.Transparent;
            login_BTN.BackgroundImageLayout = ImageLayout.Stretch;
            login_BTN.Cursor = Cursors.Hand;
            login_BTN.FlatAppearance.BorderSize = 0;
            login_BTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            login_BTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            login_BTN.FlatStyle = FlatStyle.Flat;
            login_BTN.Location = new Point(420, 273);
            login_BTN.Margin = new Padding(2);
            login_BTN.Name = "login_BTN";
            login_BTN.Size = new Size(138, 39);
            login_BTN.TabIndex = 5;
            login_BTN.TabStop = false;
            login_BTN.UseVisualStyleBackColor = false;
            login_BTN.Click += login_BTN_Click;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.Honeydew;
            usernametxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.ForeColor = SystemColors.WindowText;
            usernametxt.Location = new Point(382, 126);
            usernametxt.Margin = new Padding(2);
            usernametxt.Name = "usernametxt";
            usernametxt.PlaceholderText = "Email or Username";
            usernametxt.Size = new Size(176, 25);
            usernametxt.TabIndex = 0;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.Honeydew;
            passwordtxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.Location = new Point(382, 191);
            passwordtxt.Margin = new Padding(2);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PlaceholderText = "Password";
            passwordtxt.Size = new Size(176, 25);
            passwordtxt.TabIndex = 1;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Cursor = Cursors.Hand;
            showPW_chkbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPW_chkbox.Location = new Point(498, 246);
            showPW_chkbox.Margin = new Padding(2);
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(123, 23);
            showPW_chkbox.TabIndex = 3;
            showPW_chkbox.Text = "Show Password";
            showPW_chkbox.UseVisualStyleBackColor = false;
            showPW_chkbox.CheckedChanged += show_Password;
            // 
            // forgotPasswordLinkLabel
            // 
            forgotPasswordLinkLabel.AutoSize = true;
            forgotPasswordLinkLabel.BackColor = Color.Transparent;
            forgotPasswordLinkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPasswordLinkLabel.LinkColor = Color.Black;
            forgotPasswordLinkLabel.Location = new Point(371, 246);
            forgotPasswordLinkLabel.Margin = new Padding(2, 0, 2, 0);
            forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            forgotPasswordLinkLabel.Size = new Size(118, 19);
            forgotPasswordLinkLabel.TabIndex = 2;
            forgotPasswordLinkLabel.TabStop = true;
            forgotPasswordLinkLabel.Text = "Forgot Password?";
            forgotPasswordLinkLabel.LinkClicked += forgotPasswordLinkLabel_LinkClicked;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(678, 382);
            Controls.Add(forgotPasswordLinkLabel);
            Controls.Add(showPW_chkbox);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(login_BTN);
            Controls.Add(register_BTN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartPage";
            Padding = new Padding(2, 2, 2, 2);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            Load += Form1_Load;
            Click += StartPage_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        private void StartPage_Click(object sender, EventArgs e)
        {
          
        }

        #endregion

        private Button register_BTN;
        private Button login_BTN;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private CheckBox showPW_chkbox;
        private LinkLabel forgotPasswordLinkLabel;
    }
}