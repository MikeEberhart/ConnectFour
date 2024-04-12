using System;
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
        private GameOverForm loadedForm; //added this here since it was being used more than once

        public SinglePlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();

            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.SetLabel(lbl_TurnDisplay);
            wForm = wf;
            int num = 0;
            foreach (CellData cldta in gameBoardHere.GetGameBoard())
            {
                
                cldta.GetButton().Text = num.ToString(); // used to see the order of the buttons in the panel - delete later
                num++;
            }
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            ClearBoard();
            ShowFormButtons();
            if(loadedForm != null) loadedForm.Hide();
        }
        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            wForm.Show();
            this.Hide();
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PlacingPieces(object sender, EventArgs e)
        {
            gameBoardHere.Piece_Placement(sender, e);
            if (gameBoardHere.WinChecker(gameBoardHere.GetGameBoard()))
            {
                if (gameBoardHere.GetPlayerTurn() == 0)
                {
                    lbl_TurnDisplay.Text = "   Player 2 Wins";
                    MessageBox.Show("Player 2(computer) wins.");
                }
                if (gameBoardHere.GetPlayerTurn() == 1)
                {
                    lbl_TurnDisplay.Text = "   Player 1 Wins";
                    MessageBox.Show("Player 1 wins.");
                }
                gameOver();
            }    
        }
        private void SinglePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void gameOver()
        {
            //when the game is determined to be over can call this to send player to the game over form 
            loadedForm = new GameOverForm(this); //renamed this outside of the function to be used again
            loadedForm.Show();
            this.Hide();
            //also need to add a way to pass the game board so the review button can work

        }
        public void ClearBoard() //used in GameOver to clear the board for a new game
        {
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
        }

        private void button1_Click(object sender, EventArgs e) //used for testing gameOver
        {
            gameOver();
        }


        // used when hovering over column selection to show next possible move...very rough draft/work in progress
        //private void ShowPossibleMove(object sender, EventArgs e)
        //{
        //    Button selectedButton = (Button)sender;
        //    if(gameBoard.GetPlayerTurn() == 0)
        //    {
        //        if (selectedButton.Name == "btn_ColumnZero" && btn_ZeroZero.BackgroundImage == null)
        //        {
        //            btn_ZeroZero.BackgroundImage = Properties.Resources.RedPiece2;
        //        }
        //    }
        //}


    }
}
