﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public partial class SinglePlayerForm : Form
    {
        private WelcomeForm wForm;
        private GameBoard gameBoardHere = new GameBoard();
        private bool quitBtnClick = false;
        private Sound Sound = new Sound();
        private GameOverForm gameOverStats;

        public SinglePlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.SetLabel(lbl_TurnDisplay);
            wForm = wf;
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            ClearBoard();
            ShowFormButtons();
            Sound.ButtonClick();
            quitBtnClick = true;
            if (gameOverStats != null) gameOverStats.Hide();   
        }
        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            quitBtnClick = true;
            if (gameOverStats != null) gameOverStats.Hide();
            this.Hide();
            wForm.Show();

        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            quitBtnClick = true;
            Sound.ButtonClick();
            Environment.Exit(0);
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            this.Hide();
        }
        private void SinglePlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GameOverForm.ActiveForm != null && quitBtnClick == false) // used so closing the review board doesn't close everything
            {                                                             // but keeps causing the program to not close when GameOverForm closes
                e.Cancel = true;
                this.Hide();
            }
            Sound.Warning();
            Application.Exit();
        }
        private void PlacingPieces(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            gameBoardHere.Piece_Placement(sender, 1); // removed 'e' since it was unused
            if (gameBoardHere.WinChecker(gameBoardHere.GetGameBoard()))
            {
                GameOver();
            }
            else if (gameBoardHere.TieGameCheck())
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            Sound.Warning();
            gameOverStats = new GameOverForm(this);
            int turn = gameBoardHere.GetPlayerTurn();
            gameOverStats.SetWinningPlayer(turn);
            gameOverStats.WhoHasWon();
            gameOverStats.Show();
            this.Hide();
        }
        public void ClearBoard() //used in GameOver to clear the board for a new game
        {
            Sound.Warning();
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.ResetTurn(pnl_BoardPanel);
            foreach (Button piece in pnl_BoardPanel.Controls.OfType<Button>())
            {
                piece.BackgroundImage = null;
            }
        }
        public void HideFormButtons() //added this to hide the buttons when reviewing the board
        {
            btn_ColumnZero.Visible = false;
            btn_ColumnOne.Visible = false;
            btn_ColumnTwo.Visible = false;
            btn_ColumnThree.Visible = false;
            btn_ColumnFour.Visible = false;
            btn_ColumnFive.Visible = false;
            btn_ColumnSix.Visible = false;
            btn_MainMenu.Visible = false;
            btn_PlayAgain.Visible = false;
            btn_Back.Visible = true;
            btn_Quit.Location = new Point(346, 438); 
        }
        public void ShowFormButtons() //added to show the buttons again when playing again
        {
            btn_ColumnZero.Visible = true;
            btn_ColumnOne.Visible = true;
            btn_ColumnTwo.Visible = true;
            btn_ColumnThree.Visible = true;
            btn_ColumnFour.Visible = true;
            btn_ColumnFive.Visible = true;
            btn_ColumnSix.Visible = true;
            btn_MainMenu.Visible = true;
            btn_PlayAgain.Visible = true;
            btn_Back.Visible = false;
            btn_Quit.Location = new Point(452, 533);
        }
        private void ShowMove(object sender, EventArgs e) // MOUSE ENTER // not working
        {
            gameBoardHere.ShowPossibleMoves(sender);
        }
        private void HideMove(object sender, EventArgs e) // MOUSE LEAVE // not working
        {
            gameBoardHere.HidePossibleMove(sender);
        }
    }
}
