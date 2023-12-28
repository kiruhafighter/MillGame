using MillGame.Constants;
using MillGame.DataAccess.Repositories;
using MillGame.Entities;
using System.ComponentModel;
using System.Net.Sockets;

namespace MillGame
{
    public partial class Game : Form
    {
        private Player CurrentPlayer;
        private Player Opponent;

        private Socket socket;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener? server = null;
        private TcpClient client;

        public Game(string username, bool isHost, string? ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                CurrentPlayer = new Player { Name = username, PlayerColor = Color.Blue, TurnsAmount = 3};
                Opponent = new Player { Name = username, PlayerColor = Color.Green, TurnsAmount = 3 };

                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();

                socket = server.AcceptSocket();
            }
            else
            {
                CurrentPlayer = new Player { Name = username, PlayerColor = Color.Green, TurnsAmount = 3 };
                Opponent = new Player { Name = username, PlayerColor = Color.Blue, TurnsAmount = 3 };

                try
                {
                    client = new TcpClient(ip, 5732);
                    socket = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private bool CheckState()
        {
            if (millField1.BackColor != Color.DimGray && millField1.BackColor == millField2.BackColor && millField2.BackColor == millField3.BackColor)
            {
                CheckWinner(millField1.BackColor);

                return true;
            }

            if (millField4.BackColor != Color.DimGray && millField4.BackColor == millField5.BackColor && millField5.BackColor == millField6.BackColor)
            {
                CheckWinner(millField4.BackColor);

                return true;
            }

            if (millField7.BackColor != Color.DimGray && millField7.BackColor == millField8.BackColor && millField8.BackColor == millField9.BackColor)
            {
                CheckWinner(millField7.BackColor);

                return true;
            }

            if (millField1.BackColor != Color.DimGray && millField1.BackColor == millField4.BackColor && millField4.BackColor == millField7.BackColor)
            {
                CheckWinner(millField1.BackColor);

                return true;
            }

            if (millField2.BackColor != Color.DimGray && millField2.BackColor == millField5.BackColor && millField5.BackColor == millField8.BackColor)
            {
                CheckWinner(millField2.BackColor);

                return true;
            }

            if (millField3.BackColor != Color.DimGray && millField3.BackColor == millField6.BackColor && millField6.BackColor == millField9.BackColor)
            {
                CheckWinner(millField3.BackColor);

                return true;
            }

            if (CurrentPlayer.TurnsAmount == 0 && Opponent.TurnsAmount == 0)
            {
                label1.Text = "It is draw!";

                MessageBox.Show("It is draw");

                var playerRepository = new PlayerRepository();

                playerRepository.UserDrawsRecordChange(CurrentPlayer.Name);

                return true;
            }

            return false;
        }

        private void FreezeBoard()
        {
            foreach (Button field in Controls.OfType<Button>())
            {
                field.Enabled = false;
            }
        }

        private void UnfreezeBoard()
        {
            foreach (Button field in Controls.OfType<Button>())
            {
                if (field.BackColor == Color.DimGray)
                {
                    field.Enabled = true;
                }
            }
        }

        private void CheckWinner(Color winnerColor)
        {
            var playerRepository = new PlayerRepository();

            if (winnerColor == CurrentPlayer.PlayerColor)
            {
                label1.Text = "You won!";
                MessageBox.Show($"Player {CurrentPlayer.Name} You won!");

                playerRepository.UserWinsRecordChange(CurrentPlayer.Name);
            }
            else
            {
                label1.Text = "You lost!";
                MessageBox.Show($"Player {CurrentPlayer.Name} You lost!");

                playerRepository.UserLosesRecordChange(CurrentPlayer.Name);
            }
        }

        private void ReceiveTurn()
        {
            var buffer = new byte[1];

            socket.Receive(buffer);

            switch (buffer[0])
            {
                case 1:
                    millField1.BackColor = Opponent.PlayerColor;
                    break;

                case 2:
                    millField2.BackColor = Opponent.PlayerColor;
                    break;

                case 3:
                    millField3.BackColor = Opponent.PlayerColor;
                    break;

                case 4:
                    millField4.BackColor = Opponent.PlayerColor;
                    break;

                case 5:
                    millField5.BackColor = Opponent.PlayerColor;
                    break;

                case 6:
                    millField6.BackColor = Opponent.PlayerColor;
                    break;

                case 7:
                    millField7.BackColor = Opponent.PlayerColor;
                    break;

                case 8:
                    millField8.BackColor = Opponent.PlayerColor;
                    break;

                case 9:
                    millField9.BackColor = Opponent.PlayerColor;
                    break;

                case StringConstants.GameCloseSignal:
                    if (server is not null)
                    {
                        server.Stop();
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("The other player has left the game.");
                        this.Close();
                    });
                    break;

            }

            Opponent.TurnsAmount -= 1;
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CheckState())
            {
                return;
            }

            FreezeBoard();

            label1.Text = "Opponent's Turn!";

            ReceiveTurn();

            label1.Text = "You Turn!";

            if (!CheckState()) 
            {
                UnfreezeBoard();
            }
        }

        private void millField1_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };

            socket.Send(num);

            millField1.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField2_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };

            socket.Send(num);

            millField2.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField3_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };

            socket.Send(num);

            millField3.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField4_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };

            socket.Send(num);

            millField4.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField5_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };

            socket.Send(num);

            millField5.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField6_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };

            socket.Send(num);

            millField6.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField7_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };

            socket.Send(num);

            millField7.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField8_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };

            socket.Send(num);

            millField8.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void millField9_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };

            socket.Send(num);

            millField9.BackColor = CurrentPlayer.PlayerColor;
            CurrentPlayer.TurnsAmount -= 1;

            MessageReceiver.RunWorkerAsync();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Send(new byte[] { StringConstants.GameCloseSignal });

            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();

            if (server is not null)
            {
                server.Stop();
            }
        }
    }
}
