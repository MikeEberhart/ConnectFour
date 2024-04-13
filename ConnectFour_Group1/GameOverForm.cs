using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public partial class GameOverForm : Form
    {
        private WelcomeForm wForm; // not used probably delete later
        private SinglePlayerForm sForm; //could be used to pass the previous game board
        private StatsForm stats = new StatsForm();
        private string[] textData;
        private int winningPlayer;
        private int tempPWins;
        private int tempCWins;
        private int tempNumOfGames;
        private int tempTotalTies;
        private double tempDoublePWins;
        private double tempDoubleCWins;
        private double tempPPercent;
        private double tempCPercent;

        public GameOverForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            wForm = wf;
        }
        public GameOverForm(SinglePlayerForm sf) 
        {
            InitializeComponent();
            CenterToScreen();
            textData = stats.PassData();
            tempPWins = int.Parse(textData[0]);
            tempCWins = int.Parse(textData[2]);
            tempTotalTies = int.Parse(textData[4]);
            tempNumOfGames = int.Parse(textData[5]);
            WhoHasWon();
            sForm = sf;
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            playAgain();
            sForm.ShowFormButtons();
        }

        private void playAgain()
        {
            sForm.ClearBoard();
            sForm.Show();
            this.Hide();
        }

        private void btn_Review_Click(object sender, EventArgs e)
        {
            sForm.Show();
            sForm.HideFormButtons();
        }
        public void GetWinningPlayer(int p)
        {
            winningPlayer = p;
            Console.WriteLine(winningPlayer);
        }
        private void UpdatingPlayerWinData()
        {
            tempPWins++;
            tempNumOfGames++;
            tempDoublePWins = tempPWins;
            tempPPercent = tempDoublePWins / tempNumOfGames;
            tempDoubleCWins = tempCWins;
            tempCPercent = tempDoubleCWins / tempNumOfGames;
            FillInTextBoxes();
            Console.WriteLine("player");
        }
        private void UpdatingCompWinData()
        {
            tempCWins++;
            tempNumOfGames++;
            tempDoublePWins = tempPWins;
            tempPPercent = tempDoublePWins / tempNumOfGames;
            tempDoubleCWins = tempCWins;
            tempCPercent = tempDoubleCWins / tempNumOfGames;
            FillInTextBoxes();
            Console.WriteLine("comp");
        }
        private void UpdatingTieData()
        {
            tempTotalTies++;
            tempNumOfGames++;
            tempDoublePWins = tempPWins;
            tempPPercent = tempDoublePWins / tempNumOfGames;
            tempDoubleCWins = tempCWins;
            tempCPercent = tempDoubleCWins / tempNumOfGames;
            FillInTextBoxes();
            Console.WriteLine("tie");
        }
        private void FillInTextBoxes()
        {
            txt_TotalPlayerWins.Text = tempPWins.ToString();
            txt_TotalCompWins.Text = tempCWins.ToString();
            txt_TotalNumOfGames.Text = tempNumOfGames.ToString();
            txt_TotalTies.Text = tempTotalTies.ToString();
            txt_PlayerWinPercentage.Text = Math.Round(tempPPercent * 100, 2).ToString() + "%";
            txt_CompWinPercentage.Text = Math.Round(tempCPercent * 100, 2).ToString() + "%";
        }
        private void WhoHasWon() // this isn't working. player 1 always wins even with winningPlayer == 1
        {
            if (winningPlayer == 0)
            {
                UpdatingPlayerWinData();
                lbl_WinnerDisplay.Text = "Congratulations\nPlayer 1 you've won!!";
            }
            if (winningPlayer == 1)
            {
                UpdatingCompWinData();
                lbl_WinnerDisplay.Text = "The Computer has outsmarted you\nThe AI has won!!";
            }
            //if(tie game)
            //{
            //    UpdatingTieData();
            //    lbl_WinnerDisplay.Text = "The game has ended in a tie!!";
            //}
        }
    }
}
