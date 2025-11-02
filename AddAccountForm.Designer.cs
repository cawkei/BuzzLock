namespace BuzzLock
{
    // The 'partial' keyword links this file to AddAccountForm.cs
    partial class AddAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountForm));
            txtUsername = new TextBox();
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            btnGenerate = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            BtnShowHde = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift Condensed", 16.2F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(251, 241);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(551, 39);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtAccount_TextChanged;
            // 
            // txtAccount
            // 
            txtAccount.BackColor = SystemColors.Info;
            txtAccount.BorderStyle = BorderStyle.None;
            txtAccount.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccount.Location = new Point(251, 168);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(551, 39);
            txtAccount.TabIndex = 3;
            txtAccount.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bahnschrift Condensed", 16.2F);
            txtPassword.Location = new Point(251, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(461, 39);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Location = new Point(305, 387);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(160, 42);
            btnGenerate.TabIndex = 12;
            btnGenerate.TabStop = false;
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(482, 387);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 42);
            btnSave.TabIndex = 13;
            btnSave.TabStop = false;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(657, 387);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 42);
            btnCancel.TabIndex = 14;
            btnCancel.TabStop = false;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // BtnShowHde
            // 
            BtnShowHde.BackColor = Color.Transparent;
            BtnShowHde.BackgroundImageLayout = ImageLayout.Stretch;
            BtnShowHde.Cursor = Cursors.Hand;
            BtnShowHde.FlatAppearance.BorderSize = 0;
            BtnShowHde.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnShowHde.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnShowHde.FlatStyle = FlatStyle.Flat;
            BtnShowHde.Location = new Point(717, 290);
            BtnShowHde.Margin = new Padding(2);
            BtnShowHde.Name = "BtnShowHde";
            BtnShowHde.Size = new Size(85, 73);
            BtnShowHde.TabIndex = 15;
            BtnShowHde.TabStop = false;
            BtnShowHde.UseVisualStyleBackColor = false;
            BtnShowHde.Click += BtnShowHide_Click;
            // 
            // AddAccountForm
            // 
            BackColor = Color.FromArgb(255, 237, 164);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 492);
            Controls.Add(BtnShowHde);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnGenerate);
            Controls.Add(txtUsername);
            Controls.Add(txtAccount);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // --- Control Field Declarations ---
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private Button btnGenerate;
        private Button btnSave;
        private Button btnCancel;
        private Button BtnShowHde;
    }
}