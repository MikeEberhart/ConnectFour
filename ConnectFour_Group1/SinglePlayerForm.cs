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
        int playerTurn = 0;
        private WelcomeForm wForm;

        public SinglePlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            AddPieces();
            wForm = wf;
            int num = 0;
            foreach (Button btn in boardArray)
            {
                num++;
                btn.Text = num.ToString(); // used to see the order of the buttons in the panel - delete later
                Console.WriteLine(btn.Name);

            }
        }
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {

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

        //make 2d array with 6 rows and 7 columns
        public Button[,] boardArray = new Button[6, 7];

        private void AddPieces()
        {
            //clear out array to avoid repetition or breakage
            Array.Clear(boardArray, 0, boardArray.Length);
            int rows = 0;
            int columns = 0;
            foreach (Button piece in pnl_BoardPanel.Controls.OfType<Button>())
            {
                boardArray[rows, columns] = piece;
                columns++;
                if (columns == 7)
                {
                    columns = 0;
                    rows++;
                }
            }
        }
        private void DropPieces(int colindex)
        {
            int rowindex = GetRow(colindex);

            if (rowindex != -1)
            {
                if (playerTurn == 0)
                {
                    lbl_TurnDisplay.Text = "Player Two's Turn";
                    boardArray[rowindex, colindex].BackgroundImage = Properties.Resources.YellowPiece2;
                    playerTurn++;
                }
                else
                {
                    lbl_TurnDisplay.Text = "Player One's Turn";
                    boardArray[rowindex, colindex].BackgroundImage = Properties.Resources.RedPiece2;
                    playerTurn--;
                }
            }
        }
        
        private int GetRow(int colindex)
        {
            Button currentButton;
            for (int row = 0; row <= boardArray.GetLength(0) - 1; row++) 
            { 
                currentButton = boardArray[row, colindex];
                if (currentButton.BackgroundImage == null)
                {
                    return row;
                }
            }
            return -1;
        }
        // could use something like this to change the background pics and just use the buttons as display while they aren't enabled
        private void Piece_Placement(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int colIndex = -1;
            if (clickedButton == btn_ColumnZero) colIndex = 0;
            else if (clickedButton == btn_ColumnOne) colIndex = 1;
            else if (clickedButton == btn_ColumnTwo) colIndex = 2;
            else if (clickedButton == btn_ColumnThree) colIndex = 3;
            else if (clickedButton == btn_ColumnFour) colIndex = 4;
            else if (clickedButton == btn_ColumnFive) colIndex = 5;
            else if (clickedButton == btn_ColumnSix) colIndex = 6;

            if (colIndex != -1)
            {
                DropPieces(colIndex);
            }
        }
        // uses the public function in WelcomeForm to exit the program when the red 'X' is playerTurn
        private void SinglePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
        }

        // used when hovering over column selection to show next possible move...work in progress

    }
}
