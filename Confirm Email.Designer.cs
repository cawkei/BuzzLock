namespace BuzzLock
{
    partial class Confirm_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_Email));
            confirmEmailtxt = new TextBox();
            confirmBTN = new Button();
            SuspendLayout();
            // 
            // confirmEmailtxt
            // 
            confirmEmailtxt.BackColor = Color.Bisque;
            confirmEmailtxt.BorderStyle = BorderStyle.None;
            confirmEmailtxt.Location = new Point(57, 89);
            confirmEmailtxt.Margin = new Padding(2);
            confirmEmailtxt.Name = "confirmEmailtxt";
            confirmEmailtxt.Size = new Size(178, 16);
            confirmEmailtxt.TabIndex = 0;
            // 
            // confirmBTN
            // 
            confirmBTN.BackColor = Color.Transparent;
            confirmBTN.Cursor = Cursors.Hand;
            confirmBTN.FlatAppearance.BorderSize = 0;
            confirmBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            confirmBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            confirmBTN.FlatStyle = FlatStyle.Flat;
            confirmBTN.Location = new Point(92, 136);
            confirmBTN.Margin = new Padding(2);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(108, 20);
            confirmBTN.TabIndex = 1;
            confirmBTN.TabStop = false;
            confirmBTN.UseVisualStyleBackColor = false;
            confirmBTN.Click += confirmBTN_click;
            // 
            // Confirm_Email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(307, 249);
            Controls.Add(confirmBTN);
            Controls.Add(confirmEmailtxt);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Confirm_Email";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            Click += confirmBTN_click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox confirmEmailtxt;
        private Button confirmBTN;
    }
}