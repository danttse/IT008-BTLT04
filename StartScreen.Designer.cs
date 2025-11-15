namespace BTLT04
{
    partial class StartScreen
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
            buttonStart = new Button();
            buttonHistory = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(255, 255, 128);
            buttonStart.Font = new Font("Sesame", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(281, 209);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(250, 60);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.FromArgb(255, 255, 128);
            buttonHistory.Font = new Font("Sesame", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHistory.Location = new Point(281, 295);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(250, 60);
            buttonHistory.TabIndex = 1;
            buttonHistory.Text = "HISTORY";
            buttonHistory.UseVisualStyleBackColor = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.StartScreenBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHistory);
            Controls.Add(buttonStart);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartScreen";
            Text = "StartScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private Button buttonHistory;
    }
}