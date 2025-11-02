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
            newPasstxt.Location = new Point(99, 186);
            newPasstxt.Name = "newPasstxt";
            newPasstxt.Size = new Size(267, 24);
            newPasstxt.TabIndex = 0;
            // 
            // confirmPasstxt
            // 
            confirmPasstxt.BackColor = Color.Bisque;
            confirmPasstxt.BorderStyle = BorderStyle.None;
            confirmPasstxt.Location = new Point(99, 283);
            confirmPasstxt.Name = "confirmPasstxt";
            confirmPasstxt.Size = new Size(267, 24);
            confirmPasstxt.TabIndex = 1;
            // 
            // resetBTN
            // 
            resetBTN.BackColor = Color.Transparent;
            resetBTN.FlatAppearance.BorderSize = 0;
            resetBTN.FlatStyle = FlatStyle.Flat;
            resetBTN.Location = new Point(120, 386);
            resetBTN.Name = "resetBTN";
            resetBTN.Size = new Size(199, 57);
            resetBTN.TabIndex = 2;
            resetBTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(84, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 4;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(99, 237);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 5;
            label2.Text = "Confirm Password";
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Cursor = Cursors.Hand;
            showPW_chkbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPW_chkbox.Location = new Point(204, 335);
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(162, 29);
            showPW_chkbox.TabIndex = 13;
            showPW_chkbox.Text = "Show Password";
            showPW_chkbox.UseVisualStyleBackColor = false;
            showPW_chkbox.CheckedChanged += showPW_chkbox_click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(466, 599);
            Controls.Add(showPW_chkbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetBTN);
            Controls.Add(confirmPasstxt);
            Controls.Add(newPasstxt);
            DoubleBuffered = true;
            Name = "ForgotPassword";
            Text = "BuzzLock";
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