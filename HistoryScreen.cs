namespace BTLT04
{
    public partial class HistoryScreen : Form
    {
        private List<Result> results = [];
        
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
            if (Owner == null) return;
            
            Owner.Show();
            Close();
        }
    }
}
