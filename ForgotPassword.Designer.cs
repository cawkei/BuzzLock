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
            newPasstxt.Location = new Point(79, 149);
            newPasstxt.Margin = new Padding(2, 2, 2, 2);
            newPasstxt.Name = "newPasstxt";
            newPasstxt.Size = new Size(214, 20);
            newPasstxt.TabIndex = 0;
            // 
            // confirmPasstxt
            // 
            confirmPasstxt.BackColor = Color.Bisque;
            confirmPasstxt.BorderStyle = BorderStyle.None;
            confirmPasstxt.Location = new Point(79, 226);
            confirmPasstxt.Margin = new Padding(2, 2, 2, 2);
            confirmPasstxt.Name = "confirmPasstxt";
            confirmPasstxt.Size = new Size(214, 20);
            confirmPasstxt.TabIndex = 1;
            // 
            // resetBTN
            // 
            resetBTN.BackColor = Color.Transparent;
            resetBTN.FlatAppearance.BorderSize = 0;
            resetBTN.FlatStyle = FlatStyle.Flat;
            resetBTN.Location = new Point(96, 309);
            resetBTN.Margin = new Padding(2, 2, 2, 2);
            resetBTN.Name = "resetBTN";
            resetBTN.Size = new Size(159, 46);
            resetBTN.TabIndex = 2;
            resetBTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(67, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(79, 190);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Confirm Password";
            // 
            // showPW_chkbox
            // 
            showPW_chkbox.AutoSize = true;
            showPW_chkbox.BackColor = Color.Transparent;
            showPW_chkbox.Cursor = Cursors.Hand;
            showPW_chkbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPW_chkbox.Location = new Point(163, 268);
            showPW_chkbox.Margin = new Padding(2, 2, 2, 2);
            showPW_chkbox.Name = "showPW_chkbox";
            showPW_chkbox.Size = new Size(132, 24);
            showPW_chkbox.TabIndex = 13;
            showPW_chkbox.Text = "Show Password";
            showPW_chkbox.UseVisualStyleBackColor = false;
            showPW_chkbox.CheckedChanged += showPW_chkbox_click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(373, 479);
            Controls.Add(showPW_chkbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetBTN);
            Controls.Add(confirmPasstxt);
            Controls.Add(newPasstxt);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
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