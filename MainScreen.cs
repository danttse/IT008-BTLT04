using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace BTLT04;

public partial class MainScreen : Form
{
    private readonly Sprite player, fire, explosion;
    private readonly List<Sprite> monster = [];
    private readonly Timer timer;
    private const float MoveSpeed = 3;
    private bool keyUp;
    private bool keyDown;
    private readonly int[] lanes = [20, 140, 260]; //Hang quai spawn
    private readonly Random rnd = new Random();
    private int spawnCooldown;

    public MainScreen()
    {
        InitializeComponent();
        var maxMonsters = rnd.Next(3, 11);
        DoubleBuffered = true;

        // Khoi tao sprites
        // Chi duoc thay doi gia tri trong ngoac nhon (X, Y, SpeedX, SpeedY)
        // Di chuyen sprite bang cach thay doi SpeedX, SpeedY
        player = new Sprite(
            "Resources/Images/wizard.jpg",
            frameWidth: 192,
            frameHeight: 220,
            frameCount: 6,
            transparentColorFrom: Color.FromArgb(110, 110, 110),
            transparentColorTo: Color.FromArgb(170, 170, 170)
        )
        {
            // Initial position
            X = 100,
            Y = this.Height-220-38,
        };

        fire = new Sprite(
            "Resources/Images/fire.png",
            frameWidth: 64,
            frameHeight: 48,
            frameCount: 8,
            transparentColorFrom: Color.White,
            transparentColorTo: Color.White
        )
        {
            // Fixed speed, move right
            SpeedX = 2
        };

        explosion = new Sprite(
            "Resources/Images/explosion.png",
            frameWidth: 32,
            frameHeight: 32,
            frameCount: 12,
            transparentColorFrom: Color.FromArgb(0, 248, 0),
            transparentColorTo: Color.FromArgb(6, 248, 6)
        );


        // Sprite animation timer
        timer = new Timer();
        timer.Interval = 14; // ~60 FPS
        timer.Tick += (_, _) =>
        {
            player.Update();
            fire.Update();
            explosion.Update();
            spawnCooldown++;

            if (spawnCooldown >= rnd.Next(70, 600))
            {
                spawnCooldown = 0;

                if (monster.Count < maxMonsters)
                {
                    monster.Add(CreateMonster());
                }
            }
            for (var i = monster.Count - 1; i >= 0; i--)
            {
                var m = monster[i];
                m.Update();

                //Khi quai cham nguoi choi
                if (IsColliding(m, player))
                {
                    monster.RemoveAt(i);
                    continue;
                }
                //Khi quai cham tuong
                if (m.X + 170 < 0)
                {
                    m.X = ClientSize.Width + rnd.Next(0, 400);
                    m.Y = lanes[rnd.Next(lanes.Length)];

                    maxMonsters = rnd.Next(3, 11); //Tang do kho 
                }
            }

            Invalidate();
        };
        timer.Start();
        CreateBackGround();
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Up:
                keyUp = true;
                break;
            case Keys.Down:
                keyDown = true;
                break;
        }

        UpdatePlayerVelocity();
    }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Up:
                keyUp = false;
                break;
            case Keys.Down:
                keyDown = false;
                break;
        }

        UpdatePlayerVelocity();
    }

    private void UpdatePlayerVelocity()
    {
        player.SpeedY = (keyDown ? MoveSpeed : 0) - (keyUp ? MoveSpeed : 0);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Ve sprite o toa do (x, y)
        foreach (var m in monster)
            m.Draw(e.Graphics);
        player.Draw(e.Graphics);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        // Copy toan bo function qua form game la duoc   
        player.Dispose();
        fire.Dispose();
        explosion.Dispose();
        foreach (var m in monster)
            m.Dispose();
        base.OnFormClosed(e);
    }

    //PHAN BACKGROUND

    private readonly SoundPlayer soundMainScreen = new SoundPlayer("Resources/MainScreenSound.wav");
    private readonly PictureBox pictureBox2 = new PictureBox();
    private readonly Timer timeChangeGround = new Timer();
    private readonly Timer timeCount = new Timer();
    private int time;
    private int score;
    private const int SpeedGround = 80; //ms

    private void CreateBackGround()
    {
        soundMainScreen.PlayLooping();
        pictureBox2.Size = new Size(pictureBox1.Width, pictureBox1.Height);
        pictureBox2.BackgroundImage = pictureBox1.BackgroundImage;
        pictureBox1.Left = 0;
        pictureBox2.Top = pictureBox1.Top;
        pictureBox2.Left = pictureBox1.Right;
        Controls.Add(pictureBox2);
        timeChangeGround.Interval = SpeedGround;
        timeChangeGround.Tick += TimeChangeGround_Tick;
        timeChangeGround.Start();
        timeCount.Interval = 1000;
        timeCount.Tick += TimeCount_Tick;
        timeCount.Start();
        GameOver();
        //KHOA GAMEOVER() KHI CAN TEST NHAN VAT
    }

    private void TimeChangeGround_Tick(object? sender, EventArgs e)
    {
        pictureBox1.Left -= 5;
        pictureBox2.Left -= 5;
        if (pictureBox1.Right<=0)
        {
            pictureBox1.Left = this.Width;
        }
        if (pictureBox2.Right<=0)
        {
            pictureBox2.Left = this.Width;
        }
    }
    
    private void TimeCount_Tick(object? sender, EventArgs e)
    {
        ++time;
        TimeBox.Text = "TIME: " + time;
    }
    
    //void GameOver()
    //{
    //    string date = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
    //    Result results = new Result() { Time = date, PlayTime = time, Score = score };
    //    ((StartScreen)this.Owner).AddItemToList(results);
    //    GameOverScreen gameOverScreen = new GameOverScreen(results);
    //    gameOverScreen.Show();
    //    gameOverScreen.Owner = this.Owner;
    //    this.Close();
    //}
    
    private async Task GameOver()
    {
        if (Owner is not StartScreen sc)
        {
            Close();
            return;
        }
        
        await Task.Delay(10000);
        var date = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        var results = new Result() { Time = date, PlayTime = time, Score = score };
        sc.AddItemToList(results);
        var gameOverScreen = new GameOverScreen(results);
        gameOverScreen.Show();
        gameOverScreen.Owner = sc;
        Close();
    }
    
    private Sprite CreateMonster()
    {
        var m = new Sprite(
            "Resources/Images/monster.jpg",
            170, 140, 6,
            Color.FromArgb(70, 110, 150),
            Color.FromArgb(140, 180, 255)
        )
        {
            SpeedX = -rnd.Next(2, 7),
            X = ClientSize.Width + rnd.Next(0, 100),
            Y = lanes[rnd.Next(lanes.Length)] //Tang toc quai ngau nhien
        };

        return m;
    }
    
    private static bool IsColliding(Sprite a, Sprite b)
    {
        var dx = (a.X + a.frameWidth / 2.0) - (b.X + b.frameWidth / 2.0);
        var dy = (a.Y + a.frameHeight / 2.0) - (b.Y + b.frameHeight / 2.0);

        return Math.Abs(dx) < 50 && Math.Abs(dy) < 50;
    }
}