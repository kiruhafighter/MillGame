using MillGame.DataAccess.Repositories;

namespace MillGame
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                MessageBox.Show("Username field is empty.");
                return;
            }

            var playerRepository = new PlayerRepository();

            var playerExists = playerRepository.UserExists(loginTextBox.Text);

            if (!playerExists)
            {
                bool created = false;

                while (!created)
                {
                    created = playerRepository.CreateUser(loginTextBox.Text);
                }
            }

            ShowStartMenu();
        }

        private void ShowStartMenu()
        {
            StartMenu startMenu = new StartMenu(loginTextBox.Text);
            startMenu.FormClosed += new FormClosedEventHandler(StartMenu_FormClosed);
            startMenu.Show();
            Hide();
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
