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
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(201, 220, 113);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("ROG Fonts", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(181, 86);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(229, 48);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // EnterPinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderColor = Color.Transparent;
            ClientSize = new Size(585, 186);
            Controls.Add(passwordTextBox);
            ForeColor = SystemColors.ControlDark;
            Name = "EnterPinForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += EnterPinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
    }
}