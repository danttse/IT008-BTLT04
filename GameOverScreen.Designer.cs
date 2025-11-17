namespace BTLT04
{
    partial class GameOverScreen
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
            RestartButton = new Button();
            BackStartScreenButton = new Button();
            TimePlayBox = new Label();
            ScoreBox = new Label();
            SuspendLayout();
            // 
            // RestartButton
            // 
            RestartButton.BackColor = Color.FromArgb(255, 255, 128);
            RestartButton.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RestartButton.Location = new Point(169, 270);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(200, 70);
            RestartButton.TabIndex = 0;
            RestartButton.Text = "Restart";
            RestartButton.UseVisualStyleBackColor = false;
            // 
            // BackStartScreenButton
            // 
            BackStartScreenButton.BackColor = Color.FromArgb(255, 255, 128);
            BackStartScreenButton.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackStartScreenButton.Location = new Point(435, 270);
            BackStartScreenButton.Name = "BackStartScreenButton";
            BackStartScreenButton.Size = new Size(200, 70);
            BackStartScreenButton.TabIndex = 1;
            BackStartScreenButton.Text = "Start Screen";
            BackStartScreenButton.UseVisualStyleBackColor = false;
            // 
            // TimePlayBox
            // 
            TimePlayBox.BackColor = Color.Transparent;
            TimePlayBox.Font = new Font("Algerian", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimePlayBox.ForeColor = Color.FromArgb(255, 192, 128);
            TimePlayBox.Location = new Point(169, 363);
            TimePlayBox.Name = "TimePlayBox";
            TimePlayBox.Size = new Size(200, 30);
            TimePlayBox.TabIndex = 2;
            TimePlayBox.Text = "TimePlay:";
            TimePlayBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ScoreBox
            // 
            ScoreBox.BackColor = Color.Transparent;
            ScoreBox.Font = new Font("Algerian", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreBox.ForeColor = Color.FromArgb(255, 192, 128);
            ScoreBox.Location = new Point(436, 360);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.Size = new Size(200, 30);
            ScoreBox.TabIndex = 3;
            ScoreBox.Text = "SCORE:";
            ScoreBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GameOverScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameOver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ScoreBox);
            Controls.Add(TimePlayBox);
            Controls.Add(BackStartScreenButton);
            Controls.Add(RestartButton);
            Name = "GameOverScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOverScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button RestartButton;
        private Button BackStartScreenButton;
        private Label TimePlayBox;
        private Label ScoreBox;
    }
}