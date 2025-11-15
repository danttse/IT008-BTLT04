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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
        pictureBox1 = new PictureBox();
        TimeBox = new Label();
        Score = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
        pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
        pictureBox1.Location = new Point(0, 415);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(822, 38);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // TimeBox
        // 
        TimeBox.BackColor = Color.FromArgb(255, 255, 128);
        TimeBox.Font = new Font("Sesame", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TimeBox.Location = new Point(584, 9);
        TimeBox.Name = "TimeBox";
        TimeBox.Size = new Size(200, 35);
        TimeBox.TabIndex = 1;
        TimeBox.Text = "Time:";
        TimeBox.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Score
        // 
        Score.BackColor = Color.FromArgb(255, 255, 128);
        Score.Font = new Font("Sesame", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Score.Location = new Point(584, 54);
        Score.Name = "Score";
        Score.Size = new Size(200, 35);
        Score.TabIndex = 2;
        Score.Text = "SCORE:";
        Score.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainScreen
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.MainScreenBackground__1_;
        ClientSize = new Size(800, 450);
        Controls.Add(Score);
        Controls.Add(TimeBox);
        Controls.Add(pictureBox1);
        Name = "MainScreen";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Label TimeBox;
    private Label Score;
}