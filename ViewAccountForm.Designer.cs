namespace BuzzLock
{
    partial class ViewAccountForm
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
            btnEdit = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lblAccount = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(130, 30);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(200, 27);
            txtAccount.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(130, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(363, 53);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(363, 82);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(363, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Close";
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblAccount
            // 
            lblAccount.Location = new Point(30, 30);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(100, 23);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Account:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 71);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // ViewAccountForm
            // 
            ClientSize = new Size(751, 415);
            Controls.Add(lblAccount);
            Controls.Add(txtAccount);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // --- Control Field Declarations ---
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}