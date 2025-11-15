using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT04
{
    public partial class HistoryScreen : Form
    {
        List <Result> results=new List <Result> ();
        public HistoryScreen(List<Result> results) : this()
        {
            this.results = results;
            HistoryTable.DataSource = results;
        }
        public HistoryScreen()
        {
            InitializeComponent();
            BackStartScreenButton.Click += BackStartScreenButton_Click;
        }

        private void BackStartScreenButton_Click(object? sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
