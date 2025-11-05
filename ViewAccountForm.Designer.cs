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
            btnCopy = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            button1 = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.BackColor = Color.FromArgb(255, 222, 89);
            txtAccount.BorderStyle = BorderStyle.None;
            txtAccount.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccount.Location = new Point(71, 157);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(745, 43);
            txtAccount.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 222, 89);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(243, 252);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(509, 29);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 222, 89);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(243, 319);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(509, 29);
            txtPassword.TabIndex = 5;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Transparent;
            btnCopy.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCopy.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Location = new Point(747, 309);
            btnCopy.Margin = new Padding(2);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(69, 60);
            btnCopy.TabIndex = 17;
            btnCopy.TabStop = false;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += BtnCopy_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(292, 393);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(153, 37);
            btnEdit.TabIndex = 18;
            btnEdit.TabStop = false;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
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
            btnSave.Location = new Point(477, 393);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 37);
            btnSave.TabIndex = 19;
            btnSave.TabStop = false;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(366, 228);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(152, 37);
            button1.TabIndex = 20;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
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
            btnCancel.Location = new Point(664, 393);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 37);
            btnCancel.TabIndex = 21;
            btnCancel.TabStop = false;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // ViewAccountForm
            // 
            BackColor = Color.FromArgb(255, 237, 164);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 492);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnCopy);
            Controls.Add(txtAccount);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ViewAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // --- Control Field Declarations ---
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button1;
    }
}
