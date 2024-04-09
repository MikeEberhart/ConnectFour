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
        //made this static since the size of the array shouldn't be changed
        //used to pass the boardArray to the GameBoard Class
        //and used to call the public function from the GameBoard Class to be used in this form
        private static GameBoard gameBoardHere = new GameBoard();
        private CellData[,] cellDataArray = gameBoardHere.GetGameBoard();
        public SinglePlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.SetLabel(lbl_TurnDisplay);
            wForm = wf;
            int num = 0;
            foreach (CellData cldta in cellDataArray)
            {
                num++;
                cldta.GetButton().Text = num.ToString(); // used to see the order of the buttons in the panel - delete later
            }
        }
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.ResetTurn();
            foreach (Button piece in pnl_BoardPanel.Controls.OfType<Button>())
            {
                piece.BackgroundImage = null;
            }
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
        }
        // uses the public function in WelcomeForm to exit the program when the red 'X' is playerTurn
        private void SinglePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
        }
        private void gameOver()
        {
            //when the game is determined to be over can call this to send player to the game over form 
            GameOverForm formLoaded = new GameOverForm(wForm);
            formLoaded.Show();
            this.Hide();
            //also need to add a way to pass the game board so the review button can work 

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
