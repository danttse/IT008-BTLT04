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
using System.Media;
using System.Security.Cryptography;

namespace BTLT04
{
    public partial class StartScreen : Form
    {
        SoundPlayer player;
        List <Result> results=new List<Result>();
        public StartScreen()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
            this.Activated += PlayMusic;
            buttonHistory.Click += ButtonHistory_Click;
        }

        private void ButtonHistory_Click(object? sender, EventArgs e)
        {
            HistoryScreen historyScreen = new HistoryScreen(results);
            historyScreen.Owner = this;
            historyScreen.Show();
            this.Hide();
        }
        public void AddItemToList(Result item)
        {
            results.Add(item);
        }
        private void PlayMusic(object? sender, EventArgs e)
        {
            player = new SoundPlayer("Resources/StartScreenSound.wav");
            player.PlayLooping();
        }

        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Owner= this;
            mainScreen.Show();
            this.Hide();
        }

    }
}
