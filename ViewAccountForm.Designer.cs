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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAccountForm));
            txtAccount = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnEdit = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.BackColor = Color.FromArgb(255, 222, 89);
            txtAccount.BorderStyle = BorderStyle.None;
            txtAccount.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccount.Location = new Point(74, 146);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(455, 64);
            txtAccount.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 222, 89);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(252, 241);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(509, 44);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 222, 89);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(252, 305);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(509, 44);
            txtPassword.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(284, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(129, 30);
            btnEdit.TabIndex = 6;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(460, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 30);
            btnSave.TabIndex = 7;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(642, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 37);
            btnCancel.TabIndex = 8;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // ViewAccountForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 470);
            Controls.Add(txtAccount);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ViewAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuzzLock";
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
    }
}