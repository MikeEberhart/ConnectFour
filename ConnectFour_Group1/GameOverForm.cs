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
        private SinglePlayerForm sForm;
        private StatsForm stats = new StatsForm();
        private string[] textData;
        private string[] passingTextData = new string[6];
        private int winningPlayer;
        private int tempPWins;
        private int tempCWins;
        private int tempNumOfGames;
        private int tempTotalTies;
        private double tempDoublePWins;
        private double tempDoubleCWins;
        private double tempPPercent;
        private double tempCPercent;

        public GameOverForm(WelcomeForm wf) // not needed might delete later
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
            PlayAgain();
            sForm.ShowFormButtons();
        }

        private void PlayAgain()
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
        public void SetWinningPlayer(int p)
        {
            winningPlayer = p;
            //Console.WriteLine(winningPlayer);
        }
        public int GetWinningPlayer()
        {
            return winningPlayer;
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
            //Console.WriteLine("player");
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
            //Console.WriteLine("comp");
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
            //Console.WriteLine("tie");
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
        private void GetTextBoxData()
        {
            passingTextData[0] = txt_TotalPlayerWins.Text;
            passingTextData[1] = txt_PlayerWinPercentage.Text;
            passingTextData[2] = txt_TotalCompWins.Text;
            passingTextData[3] = txt_CompWinPercentage.Text;
            passingTextData[4] = txt_TotalTies.Text;
            passingTextData[5] = txt_TotalNumOfGames.Text;
            stats.WriteToFile(passingTextData);
        }
        public void WhoHasWon()
        {
            int results = GetWinningPlayer();
            if (results == 0)
            {
                UpdatingPlayerWinData();
                lbl_TieGameDisplay.Visible = false;
                lbl_CompWonDisplay.Visible = false;
                lbl_PlayWonDisplay.Visible = true;
            }
            if (results == 1)
            {
                UpdatingCompWinData();
                lbl_TieGameDisplay.Visible = false;
                lbl_PlayWonDisplay.Visible = false;
                lbl_CompWonDisplay.Visible = true;
            }
            if(results == -1)
            {
                UpdatingTieData();
                lbl_CompWonDisplay.Visible = false;
                lbl_PlayWonDisplay.Visible = false;
                lbl_TieGameDisplay.Visible = true;

            }
            GetTextBoxData();
        }
    }
}
