using Timer = System.Windows.Forms.Timer;

namespace BTLT04;

public partial class MainScreen : Form
{
    private readonly Sprite player, fire, explosion, monster;
    private readonly Timer timer;
    
    public MainScreen()
    {
        InitializeComponent();

        DoubleBuffered = true;
        
        player = new Sprite(
            "Resources/Images/wizard.jpg",
            frameWidth: 192,
            frameHeight: 220,
            frameCount: 6,
            transparentColorFrom: Color.FromArgb(110, 110, 110),
            transparentColorTo: Color.FromArgb(170, 170, 170)
        );
        
        fire = new Sprite(
            "Resources/Images/fire.png",
            frameWidth: 64,
            frameHeight: 48,
            frameCount: 8,
            transparentColorFrom: Color.White, 
            transparentColorTo: Color.White
        );
        
        explosion = new Sprite(
            "Resources/Images/explosion.png",
            frameWidth: 32,
            frameHeight: 32,
            frameCount: 12,
            transparentColorFrom: Color.FromArgb(0, 248, 0), 
            transparentColorTo: Color.FromArgb(6, 248, 6)
        );
        
        monster = new Sprite(
            "Resources/Images/monster.jpg",
            frameWidth: 170,
            frameHeight: 145,
            frameCount: 6,
            transparentColorFrom: Color.FromArgb(70, 110, 150), 
            transparentColorTo: Color.FromArgb(140, 180, 255)
        );
        
        timer = new Timer();
        timer.Interval = 16; // ~60 FPS
        timer.Tick += (s, e) =>
        {
            player.Update();
            Invalidate();
        };
        timer.Start();
    }
    
    protected override void OnPaint(PaintEventArgs e)
    {
        player.Draw(e.Graphics, 100, 200);
    }
    
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        player.Dispose();
        fire.Dispose();
        explosion.Dispose();
        monster.Dispose();
        base.OnFormClosed(e);
    }
}