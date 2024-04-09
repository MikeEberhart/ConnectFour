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
        private static Button[,] boardArray = new Button[6, 7];
        //used to pass the boardArray to the GameBoard Class
        //and used to call the public function from the GameBoard Class to be used in this form
        private GameBoard gameBoard = new GameBoard(boardArray);

        public SinglePlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            gameBoard.AddPieces(pnl_BoardPanel);
            gameBoard.SetLabel(lbl_TurnDisplay);
            wForm = wf;
            int num = 0;
            foreach (Button btn in boardArray)
            {
                num++;
                btn.Text = num.ToString(); // used to see the order of the buttons in the panel - delete later
            }
        }
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            gameBoard.AddPieces(pnl_BoardPanel);
            gameBoard.ResetTurn();
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
            gameBoard.Piece_Placement(sender, e);
        }
        // uses the public function in WelcomeForm to exit the program when the red 'X' is playerTurn
        private void SinglePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
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
