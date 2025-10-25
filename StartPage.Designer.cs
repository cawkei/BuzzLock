
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
            label1 = new Label();
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
            register_BTN.Location = new Point(118, 549);
            register_BTN.Name = "register_BTN";
            register_BTN.Size = new Size(209, 45);
            register_BTN.TabIndex = 0;
            register_BTN.UseMnemonic = false;
            register_BTN.UseVisualStyleBackColor = false;
            register_BTN.Click += register_BTN_Click;
            // 
            // login_BTN
            // 
            login_BTN.BackColor = Color.Transparent;
            login_BTN.FlatAppearance.BorderSize = 0;
            login_BTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            login_BTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            login_BTN.FlatStyle = FlatStyle.Flat;
            login_BTN.Location = new Point(695, 520);
            login_BTN.Name = "login_BTN";
            login_BTN.Size = new Size(211, 53);
            login_BTN.TabIndex = 1;
            login_BTN.UseVisualStyleBackColor = false;
            login_BTN.Click += login_BTN_Click;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.Honeydew;
            usernametxt.Location = new Point(643, 234);
            usernametxt.Name = "usernametxt";
            usernametxt.PlaceholderText = "Username";
            usernametxt.Size = new Size(296, 31);
            usernametxt.TabIndex = 2;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.Honeydew;
            passwordtxt.Location = new Point(643, 367);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PlaceholderText = "Password";
            passwordtxt.Size = new Size(296, 31);
            passwordtxt.TabIndex = 3;
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Location = new Point(634, 452);
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(162, 29);
            showPW_chkbox.TabIndex = 4;
            showPW_chkbox.Text = "Show Password";
            showPW_chkbox.UseVisualStyleBackColor = false;
            showPW_chkbox.CheckedChanged += show_Password;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(634, 308);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // forgotPasswordLinkLabel
            // 
            forgotPasswordLinkLabel.AutoSize = true;
            forgotPasswordLinkLabel.BackColor = Color.Transparent;
            forgotPasswordLinkLabel.LinkColor = Color.Black;
            forgotPasswordLinkLabel.Location = new Point(842, 452);
            forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            forgotPasswordLinkLabel.Size = new Size(154, 25);
            forgotPasswordLinkLabel.TabIndex = 7;
            forgotPasswordLinkLabel.TabStop = true;
            forgotPasswordLinkLabel.Text = "Forgot Password?";
            // 
            // close_Label
            // 
            close_Label.AutoSize = true;
            close_Label.BackColor = Color.Transparent;
            close_Label.BorderStyle = BorderStyle.Fixed3D;
            close_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_Label.Location = new Point(1148, 9);
            close_Label.Name = "close_Label";
            close_Label.Size = new Size(21, 33);
            close_Label.TabIndex = 8;
            close_Label.Text = "X";
            close_Label.UseCompatibleTextRendering = true;
            close_Label.Click += close_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1183, 672);
            Controls.Add(close_Label);
            Controls.Add(forgotPasswordLinkLabel);
            Controls.Add(label1);
            Controls.Add(showPW_chkbox);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(login_BTN);
            Controls.Add(register_BTN);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
        private LinkLabel forgotPasswordLinkLabel;
        private Label close_Label;
    }
}
