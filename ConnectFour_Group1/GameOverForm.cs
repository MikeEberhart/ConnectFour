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
        private Sound Sound = new Sound();

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
        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            WelcomeForm wForm = new WelcomeForm();
            this.Hide();
            wForm.Show();
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void GameOverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
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
        }
        public int GetWinningPlayer()
        {
            return winningPlayer;
        }
        private void UpdatingPlayerWinData() // updating data with new player win
        {
            Sound.Applause();
            tempPWins++;
            tempNumOfGames++;
            tempDoublePWins = tempPWins;
            tempPPercent = tempDoublePWins / tempNumOfGames;
            tempDoubleCWins = tempCWins;
            tempCPercent = tempDoubleCWins / tempNumOfGames;
            FillInTextBoxes();
        }
        private void UpdatingCompWinData()// updating data with new computer win
        {
            Sound.CrowdGasp();
            tempCWins++;
            tempNumOfGames++;
            tempDoublePWins = tempPWins;
            tempPPercent = tempDoublePWins / tempNumOfGames;
            tempDoubleCWins = tempCWins;
            tempCPercent = tempDoubleCWins / tempNumOfGames;
            FillInTextBoxes();
        }
        private void UpdatingTieData()// updating data with new tie game
        {
            Sound.CrowdGasp();
            tempTotalTies++;
            tempNumOfGames++;
            tempDoublePWins = tempPWins;
            tempPPercent = tempDoublePWins / tempNumOfGames;
            tempDoubleCWins = tempCWins;
            tempCPercent = tempDoubleCWins / tempNumOfGames;
            FillInTextBoxes();
        }
        private void FillInTextBoxes() // function used to populate the textboxes with data from saved file
        {
            txt_TotalPlayerWins.Text = tempPWins.ToString();
            txt_TotalCompWins.Text = tempCWins.ToString();
            txt_TotalNumOfGames.Text = tempNumOfGames.ToString();
            txt_TotalTies.Text = tempTotalTies.ToString();
            txt_PlayerWinPercentage.Text = Math.Round(tempPPercent * 100, 2).ToString() + "%";
            txt_CompWinPercentage.Text = Math.Round(tempCPercent * 100, 2).ToString() + "%";
        }
        private void GetTextBoxData() // function used to pass textbox data to string array to be used writing to file
        {
            passingTextData[0] = txt_TotalPlayerWins.Text;
            passingTextData[1] = txt_PlayerWinPercentage.Text;
            passingTextData[2] = txt_TotalCompWins.Text;
            passingTextData[3] = txt_CompWinPercentage.Text;
            passingTextData[4] = txt_TotalTies.Text;
            passingTextData[5] = txt_TotalNumOfGames.Text;
            stats.WriteToFile(passingTextData);
        }
        public void WhoHasWon() // function used to set the visiblity on the labels depending on who won
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
