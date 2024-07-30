namespace TaTeTi
{
    public enum Turn
    {
        X,
        O
    }

    public partial class MainWindow : Form
    {
        
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

        private readonly Dictionary<Turn, string> players = new Dictionary<Turn, string>();
        private readonly Random rand = new();
        private Turn currentTurn;

        public MainWindow(string player1Name, string player2Name)
        {
            InitializeComponent();
            Player1Name = player1Name;
            Player2Name = player2Name;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            
            AssignSymbols();
            player1NameLabel.Text = Player1Name;
            player2NameLabel.Text = Player2Name;
            player1IconLabel.Text = players.FirstOrDefault(name => name.Value == Player1Name).Key.ToString();
            player2IconLabel.Text = players.FirstOrDefault(name => name.Value == Player2Name).Key.ToString();
            playerTurnLabel.Text = GetCurrentPlayerName();            
        }

        private void AssignSymbols()
        {
            if(rand.Next(2) == 0)
            {
                players[Turn.X] = Player1Name;
                players[Turn.O] = Player2Name;
            } else
            {
                players[Turn.O] = Player1Name;
                players[Turn.X] = Player2Name;                
            }
            currentTurn = Turn.X;
        }

        public string GetCurrentPlayerName()
        {
            return players[currentTurn];
        }
        public string GetWinnerName(Turn winner)
        {
            return players[winner];
        }

        private void ChangeTurn()
        {
            currentTurn = (currentTurn == Turn.X) ? Turn.O : Turn.X;
        }        

        private void Button_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;

            if (string.IsNullOrEmpty(buttonClicked.Text))
            {
                buttonClicked.Text = currentTurn.ToString();
                ChangeTurn();
                Turn? winner = CheckWinner();
                if (winner.HasValue)
                {
                    MessageBox.Show($"{GetWinnerName(winner.Value)} ganó!");
                    GameOver();
                }
                playerTurnLabel.Text = GetCurrentPlayerName();
            }
        }
        private Turn? CheckWinner()
        {
            string[,] board = new string[3, 3];

            board[0, 0] = LeftUpperButton.Text;
            board[0, 1] = LeftCenterButton.Text;
            board[0, 2] = LeftBottomButton.Text;
            board[1, 0] = CenterUpperButton.Text;
            board[1, 1] = CenterCenterButton.Text;
            board[1, 2] = CenterBottomButton.Text;
            board[2, 0] = RightUpperButton.Text;
            board[2, 1] = RightCenterButton.Text;
            board[2, 2] = RightBottomButton.Text;

            //Columnas
            for(int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(board[i, 0]) && board[i,0] == board[i,1] && board[i,1] == board[i,2])
                {
                    return (Turn)Enum.Parse(typeof(Turn), board[i,0]);
                }
            }

            //Filas
            for (int j = 0; j < 3; j++)
            {
                if (!string.IsNullOrEmpty(board[0,j]) && board[0,j] == board[1,j] && board[1, j] == board[2, j])
                {
                    return (Turn)Enum.Parse(typeof(Turn), board[0, j]);
                }
            }

            //Diagonal
            if (!string.IsNullOrEmpty(board[1, 1]))
            {
                if ((board[0,0] == board[1,1] && board[1,1] == board[2,2]) ||
                    (board[0,2] == board[1,1] && board[1,1] == board[2, 0]))
                {
                    return (Turn)Enum.Parse(typeof(Turn), board[1, 1]);
                }
            }

            bool isComplete = true;
            foreach (Button button in Grid.Controls)
            {
                if (string.IsNullOrEmpty(button.Text))
                {
                    isComplete = false;
                    break;
                }
            }
            if (isComplete)
            {
                MessageBox.Show("Empate!");
                GameOver();
            }
            return null;
        }
        private void GameOver()
        {
            foreach (Button button in Grid.Controls)
            {
                button.Enabled = false;
            }
        }
    }
}
