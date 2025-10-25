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
            txtAccount = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbAlgorithm = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnShowHide = new Button();
            lblAccount = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblAlgorithm = new Label();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(160, 55);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(200, 27);
            txtAccount.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 95);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(165, 27);
            txtPassword.TabIndex = 5;
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.Items.AddRange(new object[] { "Argon2", "Scrypt" });
            cmbAlgorithm.Location = new Point(160, 175);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(200, 28);
            cmbAlgorithm.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Location = new Point(160, 235);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.Location = new Point(280, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnShowHide
            // 
            btnShowHide.BackColor = Color.Transparent;
            btnShowHide.BackgroundImageLayout = ImageLayout.Center;
            btnShowHide.Location = new Point(330, 131);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(30, 34);
            btnShowHide.TabIndex = 6;
            btnShowHide.Text = "👁";
            btnShowHide.UseVisualStyleBackColor = false;
            btnShowHide.Click += BtnShowHide_Click;
            // 
            // lblAccount
            // 
            lblAccount.Location = new Point(60, 55);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(100, 23);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(60, 95);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(60, 135);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.Location = new Point(60, 175);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new Size(100, 23);
            lblAlgorithm.TabIndex = 7;
            lblAlgorithm.Text = "Hash Algorithm:";
            // 
            // AddAccountForm
            // 
            BackColor = Color.FromArgb(255, 237, 164);
            ClientSize = new Size(427, 310);
            Controls.Add(lblAccount);
            Controls.Add(txtAccount);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnShowHide);
            Controls.Add(lblAlgorithm);
            Controls.Add(cmbAlgorithm);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // --- Control Field Declarations ---
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAlgorithm;
    }
}