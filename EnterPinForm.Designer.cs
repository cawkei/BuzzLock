namespace BuzzLock
{
    partial class EnterPinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPinForm));
            passwordTextBox = new TextBox();
            showPassButton = new Button();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(27, 109);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(187, 27);
            passwordTextBox.TabIndex = 0;
            // 
            // showPassButton
            // 
            showPassButton.BackColor = Color.Transparent;
            showPassButton.BackgroundImageLayout = ImageLayout.Stretch;
            showPassButton.Cursor = Cursors.Hand;
            showPassButton.FlatAppearance.BorderSize = 0;
            showPassButton.FlatStyle = FlatStyle.Flat;
            showPassButton.Location = new Point(209, 104);
            showPassButton.Name = "showPassButton";
            showPassButton.Size = new Size(69, 39);
            showPassButton.TabIndex = 1;
            showPassButton.TabStop = false;
            showPassButton.UseVisualStyleBackColor = false;
            showPassButton.Click += ShowPassButton_Click;
            // 
            // EnterPinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(301, 198);
            Controls.Add(showPassButton);
            Controls.Add(passwordTextBox);
            Name = "EnterPinForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += EnterPinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Button showPassButton;
    }
}