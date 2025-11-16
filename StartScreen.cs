using System.Media;

namespace BTLT04
{
    public partial class StartScreen : Form
    {
        private readonly SoundPlayer player = new SoundPlayer("Resources/StartScreenSound.wav");
        private readonly List<Result> results = [];
        
        public StartScreen()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
            Activated += PlayMusic;
            buttonHistory.Click += ButtonHistory_Click;
        }

        private void ButtonHistory_Click(object? sender, EventArgs e)
        {
            var historyScreen = new HistoryScreen(results);
            historyScreen.Owner = this;
            historyScreen.Show();
            Hide();
        }
        
        public void AddItemToList(Result item)
        {
            results.Add(item);
        }
        
        private void PlayMusic(object? sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            var mainScreen = new MainScreen();
            mainScreen.Owner = this;
            mainScreen.Show();
            Hide();
        }

    }
}
