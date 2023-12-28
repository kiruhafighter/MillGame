namespace MillGame
{
    public partial class StartMenu : Form
    {
        private readonly string _username;

        public StartMenu(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(_username, false, ipAddressTextBox.Text);

            Visible = false;

            if (!newGame.IsDisposed) 
            {
                newGame.ShowDialog();
            }

            Visible = true;
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(_username, true);

            Visible = false;

            if (!newGame.IsDisposed)
            {
                newGame.ShowDialog();
            }

            Visible = true;
        }

        private void scoreboardButton_Click(object sender, EventArgs e)
        {
            var scoreboard = new Scoreboard();

            scoreboard.Show();
        }
    }
}