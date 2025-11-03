namespace BuzzLock
{
    partial class SetupPin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupPin));
            setupPintxt = new TextBox();
            confirmBTN = new Button();
            SuspendLayout();
            // 
            // setupPintxt
            // 
            setupPintxt.BackColor = Color.FromArgb(250, 228, 181);
            setupPintxt.BorderStyle = BorderStyle.None;
            setupPintxt.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setupPintxt.Location = new Point(118, 131);
            setupPintxt.Margin = new Padding(2);
            setupPintxt.Name = "setupPintxt";
            setupPintxt.Size = new Size(155, 49);
            setupPintxt.TabIndex = 1;
            setupPintxt.TextAlign = HorizontalAlignment.Center;
            setupPintxt.TextChanged += setupPintxt_TextChanged;
            // 
            // confirmBTN
            // 
            confirmBTN.BackColor = Color.Transparent;
            confirmBTN.BackgroundImageLayout = ImageLayout.Stretch;
            confirmBTN.Cursor = Cursors.Hand;
            confirmBTN.FlatAppearance.BorderSize = 0;
            confirmBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            confirmBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            confirmBTN.FlatStyle = FlatStyle.Flat;
            confirmBTN.Location = new Point(118, 206);
            confirmBTN.Margin = new Padding(2);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(155, 42);
            confirmBTN.TabIndex = 15;
            confirmBTN.TabStop = false;
            confirmBTN.UseVisualStyleBackColor = false;
            confirmBTN.Click += confirmBTN_click;
            // 
            // SetupPin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(392, 353);
            Controls.Add(confirmBTN);
            Controls.Add(setupPintxt);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "SetupPin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuzzLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox setupPintxt;
        private Button confirmBTN;
    }
}