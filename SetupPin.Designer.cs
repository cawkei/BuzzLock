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
            confirmBTN = new Button();
            setupPintxt = new TextBox();
            BtnShowHde = new Button();
            SuspendLayout();
            // 
            // confirmBTN
            // 
            confirmBTN.BackColor = Color.Transparent;
            confirmBTN.FlatAppearance.BorderSize = 0;
            confirmBTN.FlatStyle = FlatStyle.Flat;
            confirmBTN.Location = new Point(124, 199);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new Size(163, 42);
            confirmBTN.TabIndex = 0;
            confirmBTN.UseVisualStyleBackColor = false;
            confirmBTN.Click += confirmBTN_click;
            // 
            // setupPintxt
            // 
            setupPintxt.BackColor = Color.Bisque;
            setupPintxt.BorderStyle = BorderStyle.None;
            setupPintxt.Location = new Point(80, 134);
            setupPintxt.Name = "setupPintxt";
            setupPintxt.Size = new Size(207, 24);
            setupPintxt.TabIndex = 1;
            // 
            // BtnShowHde
            // 
            BtnShowHde.BackColor = Color.Transparent;
            BtnShowHde.BackgroundImageLayout = ImageLayout.Stretch;
            BtnShowHde.Cursor = Cursors.Hand;
            BtnShowHde.FlatAppearance.BorderSize = 0;
            BtnShowHde.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnShowHde.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnShowHde.FlatStyle = FlatStyle.Flat;
            BtnShowHde.Location = new Point(292, 134);
            BtnShowHde.Margin = new Padding(2);
            BtnShowHde.Name = "BtnShowHde";
            BtnShowHde.Size = new Size(44, 24);
            BtnShowHde.TabIndex = 16;
            BtnShowHde.TabStop = false;
            BtnShowHde.UseVisualStyleBackColor = false;
            BtnShowHde.Click += BtnShowHde_click;
            // 
            // SetupPin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(439, 415);
            Controls.Add(BtnShowHde);
            Controls.Add(setupPintxt);
            Controls.Add(confirmBTN);
            DoubleBuffered = true;
            Name = "SetupPin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuzzLock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmBTN;
        private TextBox setupPintxt;
        private Button BtnShowHde;
    }
}