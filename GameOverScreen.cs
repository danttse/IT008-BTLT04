using System.Media;

namespace BTLT04
{
    public partial class GameOverScreen : Form
    {
        public GameOverScreen(Result result)
        {
            TimePlayBox.Text += result.PlayTime.ToString();
            ScoreBox.Text += result.Score.ToString();
        }

        public GameOverScreen()
        {
            InitializeComponent();
            PlayGameOverMusic();
            RestartButton.Click += RestartButton_Click;
            BackStartScreenButton.Click += BackStartScreenButton_Click;
        }

        private void BackStartScreenButton_Click(object? sender, EventArgs e)
        {
            if (Owner == null) return;
            Owner.Show();
            Close();
        }

        private void RestartButton_Click(object? sender, EventArgs e)
        {
            var mainScreen = new MainScreen();
            mainScreen.Show();
            mainScreen.Owner = Owner;
            Close();
        }

        private static async Task PlayGameOverMusic()
        {
            var musicGameOver = new SoundPlayer("Resources/SoundOfFail.wav");
            musicGameOver.Play();
            await Task.Delay(3000);
            musicGameOver = new SoundPlayer("Resources/MainScreenSound.wav");
            musicGameOver.PlayLooping();
        }
    }
}
