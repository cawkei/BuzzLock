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
            close_Label = new Label();
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
            register_BTN.Location = new Point(139, 554);
            register_BTN.Margin = new Padding(2, 2, 2, 2);
            register_BTN.Name = "register_BTN";
            register_BTN.Size = new Size(167, 36);
            register_BTN.TabIndex = 0;
            register_BTN.UseMnemonic = false;
            register_BTN.UseVisualStyleBackColor = false;
            register_BTN.Click += register_BTN_Click;
            // 
            // login_BTN
            // 
            login_BTN.BackColor = Color.Transparent;
            login_BTN.Cursor = Cursors.Hand;
            login_BTN.FlatAppearance.BorderSize = 0;
            login_BTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            login_BTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            login_BTN.FlatStyle = FlatStyle.Flat;
            login_BTN.Location = new Point(715, 527);
            login_BTN.Margin = new Padding(2, 2, 2, 2);
            login_BTN.Name = "login_BTN";
            login_BTN.Size = new Size(169, 42);
            login_BTN.TabIndex = 1;
            login_BTN.UseVisualStyleBackColor = false;
            login_BTN.Click += login_BTN_Click;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.Honeydew;
            usernametxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            usernametxt.ForeColor = SystemColors.WindowText; // Remote ForeColor
            usernametxt.Location = new Point(643, 231); // Remote Location
            usernametxt.Margin = new Padding(2, 2, 2, 2); // Local Margin
            usernametxt.Name = "usernametxt";
            usernametxt.PlaceholderText = "Username";
            usernametxt.Size = new Size(296, 34); // Remote Size (larger)
            usernametxt.TabIndex = 2;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.Honeydew;
            passwordtxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            passwordtxt.Location = new Point(643, 370); // Remote Location
            passwordtxt.Margin = new Padding(2, 2, 2, 2); // Local Margin
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PlaceholderText = "Password";
            passwordtxt.Size = new Size(296, 34); // Remote Size (larger)
            passwordtxt.TabIndex = 3;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Cursor = Cursors.Hand; // Remote Cursor
            showPW_chkbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0); // Remote Font
            showPW_chkbox.Location = new Point(828, 449); // Remote Location
            showPW_chkbox.Margin = new Padding(2, 2, 2, 2); // Local Margin
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(172, 32); // Remote Size
            showPW_chkbox.TabIndex = 4;
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
            forgotPasswordLinkLabel.Location = new Point(625, 453); // Remote Location
            forgotPasswordLinkLabel.Margin = new Padding(2, 0, 2, 0); // Local Margin
            forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            forgotPasswordLinkLabel.Size = new Size(167, 28); // Remote Size
            forgotPasswordLinkLabel.TabIndex = 7;
            forgotPasswordLinkLabel.TabStop = true;
            forgotPasswordLinkLabel.Text = "Forgot Password?";
            forgotPasswordLinkLabel.LinkClicked += forgotPasswordLinkLabel_LinkClicked;
            // 
            // close_Label
            // 
            close_Label.AutoSize = true;
            close_Label.BackColor = Color.Transparent;
            close_Label.BorderStyle = BorderStyle.Fixed3D;
            close_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_Label.Location = new Point(1138, 22);
            close_Label.Margin = new Padding(2, 0, 2, 0);
            close_Label.Name = "close_Label";
            close_Label.Size = new Size(18, 28);
            close_Label.TabIndex = 8;
            close_Label.Text = "X";
            close_Label.UseCompatibleTextRendering = true;
            close_Label.Click += close_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F); // Kept Local Dimension
            AutoScaleMode = AutoScaleMode.None; // Remote AutoScaleMode
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1176, 654); // Remote ClientSize (slightly smaller)
            Controls.Add(close_Label);
            Controls.Add(forgotPasswordLinkLabel);
            Controls.Add(showPW_chkbox);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(login_BTN);
            Controls.Add(register_BTN);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            Click += StartPage_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        private void StartPage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button register_BTN;
        private Button login_BTN;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private CheckBox showPW_chkbox;
        private LinkLabel forgotPasswordLinkLabel;
        private Label close_Label;
    }
}