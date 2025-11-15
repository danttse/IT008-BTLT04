using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT04
{
    public partial class GameOverScreen : Form
    {
        public GameOverScreen(Result result):this()
        {
            TimePlayBox.Text += result.PlayTime.ToString();
            ScoreBox.Text += result.Score.ToString();
        }

        public GameOverScreen()
        {
            InitializeComponent();
            MucsicGameOver();
            RestartButton.Click += RestartButton_Click;
            BackStartScreenButton.Click += BackStartScreenButton_Click;
        }

        private void BackStartScreenButton_Click(object? sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void RestartButton_Click(object? sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            mainScreen.Owner = this.Owner;
            this.Close();
        }

        async Task MucsicGameOver()
        {
            SoundPlayer MusicGameOver=new SoundPlayer("Resources/SoundOfFail.wav");
            MusicGameOver.Play();
            await Task.Delay(3000);
            MusicGameOver=new SoundPlayer("Resources/MainScreenSound.wav");
            MusicGameOver.PlayLooping();
        }
        
    }
}
