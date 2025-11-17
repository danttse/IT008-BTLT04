using System.Data;
using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace BTLT04;

public partial class MainScreen : Form
{
    private readonly Sprite player;
    private readonly List<List<Sprite>> monsters = [[], [], []]; // 3 lanes
    private readonly List<Sprite> fires = [], explosions = [];
    private readonly Timer timer;
    private const float MoveSpeed = 10;
    private bool keyUp;
    private bool keyDown;
    private readonly int[] lanes = [20, 140, 260]; //Hang quai spawn
    private readonly Random rnd = new Random();
    private int spawnCooldown;
    private int DemHoiChieu = 50;
    private const int ThoiGianHoiChieu = 50;

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
            Y = lanes[1], //spawn lane giua
        };

        // Sprite animation timer
        timer = new Timer();
        timer.Interval = 14; // ~60 FPS
        timer.Tick += (_, _) =>
        {
            UpdatePlayerVelocity();

            spawnCooldown++;
            if (spawnCooldown >= rnd.Next(70, 600))
            {
                spawnCooldown = 0;

                if (monsters.Count < maxMonsters)
                {
                    var lane = rnd.Next(0, lanes.Length);
                    monsters[lane].Add(CreateMonster());
                }
            }

            for (var i = 0; i < lanes.Length; i++)
            {
                foreach(var monster in monsters[i].ToList())
                {
                    monster.Update();

                    if (IsColliding(monster, player))
                    {
                        //monsters[i].Remove(monster);
                        //monster.Dispose();
                        GameOver();
                        continue;
                    }

                    if (monster.X + monster.FrameWidth < 0)
                    {
                        //monsters[i].Remove(monster);
                        //monster.Dispose();
                        //maxMonsters = rnd.Next(3, 11); //Tang do kho
                        GameOver();
                    }
                }
            }
            
            foreach (var fire in fires.ToList())
            {
                fire.Update();
                for (var i = 0; i < lanes.Length; i++)
                    foreach (var monster in monsters[i].ToList()
                                 .Where(monster => IsColliding(fire, monster)))
                    {
                        explosions.Add(CreateExplosion(monster.X + 70, monster.Y + 85));
                        fires.Remove(fire);
                        score += 5;//Cong diem;
                        UpDateScore();
                        fire.Dispose();
                        monsters[i].Remove(monster);
                        monster.Dispose();
                        goto NextFire; // stop checking this bullet
                    }

                if (fire.X + fire.FrameWidth > ClientSize.Width)
                {
                    fires.Remove(fire);
                    fire.Dispose();
                }

                NextFire:;
            }
            
            foreach (var explosion in explosions.ToList())
            {
                explosion.Update();
                if (explosion.IsFinished)
                {
                    explosions.Remove(explosion);
                    explosion.Dispose();
                }
            }
            DemHoiChieu++;
            Invalidate();
        };
        timer.Start();

        KeyDown += MainScreen_KeyDown;
        KeyUp += MainScreen_KeyUp;

        CreateBackGround();
    }

    private void MainScreen_KeyDown(object? sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Up:
                keyUp = true;
                break;
            case Keys.Down:
                keyDown = true;
                break;
            case Keys.A:
                if (DemHoiChieu >= ThoiGianHoiChieu)
                {
                    fires.Add(CreateFire(player.X + player.FrameWidth / 2f, player.Y + player.FrameHeight / 2f - 24));
                    DemHoiChieu = 0;
                }
                break;
            default:
                return;
        }
    }

    private void MainScreen_KeyUp(object? sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Up:
                keyUp = false;
                break;
            case Keys.Down:
                keyDown = false;
                break;
            default:
                return;
        }
    }

    private void UpdatePlayerVelocity()
    {
        player.SpeedY = (keyDown ? MoveSpeed : 0) - (keyUp ? MoveSpeed : 0);
        if (player.SpeedY != 0)
        {
            player.Update();
            player.Y = Math.Max(0, Math.Min(player.Y, ClientSize.Height - player.FrameHeight));
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        player.Draw(e.Graphics);
        for (var i = 0; i < lanes.Length; i++)
            foreach (var monster in monsters[i])
                monster.Draw(e.Graphics);
        foreach (var fire in fires)
            fire.Draw(e.Graphics);
        foreach (var explosion in explosions)
            explosion.Draw(e.Graphics);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        player.Dispose();
        for (var i = 0; i < lanes.Length; i++)
            foreach (var monster in monsters[i])
                monster.Dispose();
        foreach (var fire in fires)
            fire.Dispose();
        foreach (var explosion in explosions)
            explosion.Dispose();
        base.OnFormClosed(e);
    }

    //PHAN BACKGROUND

    private readonly SoundPlayer soundMainScreen = new SoundPlayer("Resources/MainScreenSound.wav");
    private readonly PictureBox pictureBox2 = new PictureBox();
    private readonly Timer timeChangeGround = new Timer();
    private readonly Timer timeCount = new Timer();
    private int time;
    private int score;

    private void CreateBackGround()
    {
        soundMainScreen.PlayLooping();
        timeCount.Interval = 1000;
        timeCount.Tick += TimeCount_Tick;
        timeCount.Start();
        UpDateScore();
    }
    void UpDateScore()
    {
        ScoreBox.Text="SCORE: "+score.ToString();
    }

    private void TimeCount_Tick(object? sender, EventArgs e)
    {
        ++time;
        TimeBox.Text = "TIME: " + time;
    }

    void GameOver()
    {
        string date = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        Result results = new Result() { Time = date, PlayTime = time, Score = score };
        var sc = Owner as StartScreen;
        if (sc != null) sc.AddItemToList(results);
        GameOverScreen gameOverScreen = new GameOverScreen(results);
        gameOverScreen.Owner = sc;
        gameOverScreen.Show();
        timer.Stop();
        timeCount.Stop();
        this.Close();
    }
    private Sprite CreateMonster()
    {
        return new Sprite(
            "Resources/Images/monster.jpg",
            frameWidth: 170,
            frameHeight: 140,
            frameCount: 6,
            transparentColorFrom: Color.FromArgb(70, 110, 150),
            transparentColorTo: Color.FromArgb(140, 180, 255)
        )
        {
            SpeedX = -rnd.Next(2, 7),
            X = ClientSize.Width + rnd.Next(0, 100),
            Y = lanes[rnd.Next(lanes.Length)] //Tang toc quai ngau nhien
        };
    }

    private static Sprite CreateFire(float x, float y)
    {
        // x: player.X
        // y: player.Y
        return new Sprite(
            "Resources/Images/fire.png",
            frameWidth: 64,
            frameHeight: 48,
            frameCount: 8,
            transparentColorFrom: Color.White,
            transparentColorTo: Color.White
        )
        {
            X = x,
            Y = y,
            SpeedX = 10
        };
    }

    private static Sprite CreateExplosion(float x, float y)
    {
        // x: monster.X
        // y: monster.Y
        return new Sprite(
                "Resources/Images/explosion.png",
                frameWidth: 32,
                frameHeight: 32,
                frameCount: 12,
                loop: false,
                transparentColorFrom: Color.FromArgb(0, 248, 0),
                transparentColorTo: Color.FromArgb(6, 248, 6)
            )
            { X = x, Y = y };
    }

    private static bool IsColliding(Sprite a, Sprite b)
    {
        return a.Bounds.IntersectsWith(b.Bounds);
    }
}