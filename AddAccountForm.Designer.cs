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
            cmbAlgorithm = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnShowHide = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift Condensed", 16.2F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(258, 217);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(560, 39);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtAccount_TextChanged;
            // 
            // txtAccount
            // 
            txtAccount.BackColor = SystemColors.Info;
            txtAccount.BorderStyle = BorderStyle.None;
            txtAccount.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccount.Location = new Point(258, 156);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(560, 39);
            txtAccount.TabIndex = 3;
            txtAccount.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bahnschrift Condensed", 16.2F);
            txtPassword.Location = new Point(258, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(483, 39);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.BackColor = SystemColors.Info;
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.Font = new Font("Bahnschrift Condensed", 13.8F);
            cmbAlgorithm.ForeColor = SystemColors.ActiveBorder;
            cmbAlgorithm.Items.AddRange(new object[] { "Argon2", "Scrypt" });
            cmbAlgorithm.Location = new Point(258, 357);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(560, 42);
            cmbAlgorithm.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(507, 421);
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
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(685, 421);
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
            btnShowHide.FlatAppearance.BorderSize = 0;
            btnShowHide.FlatStyle = FlatStyle.Flat;
            btnShowHide.ForeColor = Color.Transparent;
            btnShowHide.Location = new Point(755, 290);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(63, 37);
            btnShowHide.TabIndex = 6;
            btnShowHide.UseVisualStyleBackColor = false;
            btnShowHide.Click += BtnShowHide_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(327, 424);
            button1.Name = "button1";
            button1.Size = new Size(160, 44);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnGenerator_Click;
            // 
            // AddAccountForm
            // 
            BackColor = Color.FromArgb(255, 237, 164);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 515);
            Controls.Add(button1);
            Controls.Add(txtUsername);
            Controls.Add(txtAccount);
            Controls.Add(txtPassword);
            Controls.Add(btnShowHide);
            Controls.Add(cmbAlgorithm);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuzzLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // --- Control Field Declarations ---
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowHide;
        private Button button1;
    }
}