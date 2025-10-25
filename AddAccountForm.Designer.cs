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
            txtAccount = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbAlgorithm = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnShowHide = new Button();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.BackColor = SystemColors.Info;
            txtAccount.BorderStyle = BorderStyle.None;
            txtAccount.Font = new Font("Bahnschrift Condensed", 13.8F);
            txtAccount.ForeColor = Color.Black;
            txtAccount.Location = new Point(237, 200);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(518, 28);
            txtAccount.TabIndex = 1;
            txtAccount.TextChanged += txtAccount_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(237, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(518, 28);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bahnschrift Condensed", 13.8F);
            txtPassword.Location = new Point(237, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(441, 28);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.BackColor = SystemColors.Info;
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.Font = new Font("Bahnschrift Condensed", 13.8F);
            cmbAlgorithm.Items.AddRange(new object[] { "Argon2", "Scrypt" });
            cmbAlgorithm.Location = new Point(237, 325);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(518, 36);
            cmbAlgorithm.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(443, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 46);
            btnSave.TabIndex = 9;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(618, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 46);
            btnCancel.TabIndex = 10;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnShowHide
            // 
            btnShowHide.BackColor = Color.Transparent;
            btnShowHide.BackgroundImageLayout = ImageLayout.Center;
            btnShowHide.FlatStyle = FlatStyle.Flat;
            btnShowHide.ForeColor = Color.Transparent;
            btnShowHide.Location = new Point(684, 263);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(63, 37);
            btnShowHide.TabIndex = 6;
            btnShowHide.UseVisualStyleBackColor = false;
            btnShowHide.Click += BtnShowHide_Click;
            // 
            // AddAccountForm
            // 
            BackColor = Color.FromArgb(255, 237, 164);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(835, 469);
            Controls.Add(txtAccount);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnShowHide);
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
    }
}