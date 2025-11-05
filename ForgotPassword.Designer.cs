namespace BuzzLock
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            newPasstxt = new TextBox();
            confirmPasstxt = new TextBox();
            resetBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            showPW_chkbox = new CheckBox();
            SuspendLayout();
            // 
            // newPasstxt
            // 
            newPasstxt.BackColor = Color.Bisque;
            newPasstxt.BorderStyle = BorderStyle.None;
            newPasstxt.Location = new Point(69, 112);
            newPasstxt.Margin = new Padding(2);
            newPasstxt.Name = "newPasstxt";
            newPasstxt.Size = new Size(187, 16);
            newPasstxt.TabIndex = 0;
            // 
            // confirmPasstxt
            // 
            confirmPasstxt.BackColor = Color.Bisque;
            confirmPasstxt.BorderStyle = BorderStyle.None;
            confirmPasstxt.Location = new Point(69, 170);
            confirmPasstxt.Margin = new Padding(2);
            confirmPasstxt.Name = "confirmPasstxt";
            confirmPasstxt.Size = new Size(187, 16);
            confirmPasstxt.TabIndex = 1;
            // 
            // resetBTN
            // 
            resetBTN.BackColor = Color.Transparent;
            resetBTN.Cursor = Cursors.Hand;
            resetBTN.FlatAppearance.BorderSize = 0;
            resetBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resetBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resetBTN.FlatStyle = FlatStyle.Flat;
            resetBTN.Location = new Point(84, 232);
            resetBTN.Margin = new Padding(2);
            resetBTN.Name = "resetBTN";
            resetBTN.Size = new Size(139, 34);
            resetBTN.TabIndex = 2;
            resetBTN.TabStop = false;
            resetBTN.UseVisualStyleBackColor = false;
            resetBTN.Click += resetBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(59, 82);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(69, 142);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Confirm Password";
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Cursor = Cursors.Hand;
            showPW_chkbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPW_chkbox.Location = new Point(143, 201);
            showPW_chkbox.Margin = new Padding(2);
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(108, 19);
            showPW_chkbox.TabIndex = 13;
            showPW_chkbox.Text = "Show Password";
            showPW_chkbox.UseVisualStyleBackColor = false;
            showPW_chkbox.CheckedChanged += showPW_chkbox_click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(326, 359);
            Controls.Add(showPW_chkbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetBTN);
            Controls.Add(confirmPasstxt);
            Controls.Add(newPasstxt);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newPasstxt;
        private TextBox confirmPasstxt;
        private Button resetBTN;
        private Label label1;
        private Label label2;
        private CheckBox showPW_chkbox;
    }
}