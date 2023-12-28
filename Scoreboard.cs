using MillGame.DataAccess.Repositories;
using MillGame.Entities;

namespace MillGame
{
    public partial class Scoreboard : Form
    {

        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            var playerRepository = new PlayerRepository();

            var ratings = playerRepository.GetScoreboard();

            var scoreboard = ratings!.Select((r, index) =>
            new PlayerScoreDto
            {
                Number = index + 1,
                Username = r.Name,
                Wins = r.Wins,
                Losses = r.Losses,
                Draws = r.Draws
            }).ToList();

            scoreGridView.DataSource = new BindingSource(scoreboard, null);

            scoreGridView.ReadOnly = true;
            scoreGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
