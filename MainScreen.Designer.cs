namespace BTLT04;

partial class MainScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        TimeBox = new Label();
        ScoreBox = new Label();
        SuspendLayout();
        // 
        // TimeBox
        // 
        TimeBox.BackColor = Color.FromArgb(255, 255, 128);
        TimeBox.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TimeBox.Location = new Point(1050, 19);
        TimeBox.Name = "TimeBox";
        TimeBox.Size = new Size(200, 35);
        TimeBox.TabIndex = 1;
        TimeBox.Text = "TIME:";
        TimeBox.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ScoreBox
        // 
        ScoreBox.BackColor = Color.FromArgb(255, 255, 128);
        ScoreBox.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ScoreBox.Location = new Point(1050, 71);
        ScoreBox.Name = "ScoreBox";
        ScoreBox.Size = new Size(200, 35);
        ScoreBox.TabIndex = 2;
        ScoreBox.Text = "SCORE:";
        ScoreBox.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainScreen
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.BackgroundGame;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1262, 673);
        Controls.Add(ScoreBox);
        Controls.Add(TimeBox);
        Name = "MainScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion
    private Label TimeBox;
    private Label ScoreBox;
}