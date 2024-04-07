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
    public static class GameBoard
    {
        //make 2d array with 6 rows and 7 columns
        public static Button[,] boardArray = new Button[6, 7];
        public static int playerTurn = 0;
        private static Label turnDisplay;
        public static void AddPieces(Panel pnl)
        {
            //clear out array to avoid repetition or breakage
            Array.Clear(boardArray, 0, boardArray.Length);
            int rows = 0;
            int columns = 0;
            foreach (Button piece in pnl.Controls.OfType<Button>())
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

        public static void SetLabel(Label lbl)
        {
            turnDisplay = lbl;
        }
        public static void DropPieces(int colindex)
        {
            int rowindex = GetRow(colindex);

            if (rowindex != -1)
            {
                if (playerTurn == 0)
                {
                    turnDisplay.Text = "Player Two's Turn";
                    boardArray[rowindex, colindex].BackgroundImage = Properties.Resources.YellowPiece2;
                    playerTurn++;
                }
                else
                {
                    turnDisplay.Text = "Player One's Turn";
                    boardArray[rowindex, colindex].BackgroundImage = Properties.Resources.RedPiece2;
                    playerTurn--;
                }
            }
        }

        public static int GetRow(int colindex)
        {
            Button currentButton;
            for (int row = 0; row <= GameBoard.boardArray.GetLength(0) - 1; row++)
            {
                currentButton = GameBoard.boardArray[row, colindex];
                if (currentButton.BackgroundImage == null)
                {
                    return row;
                }
            }
            return -1;
        }
        // could use something like this to change the background pics and just use the buttons as display while they aren't enabled
        public static void Piece_Placement(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int colIndex = -1;
            if (clickedButton.Name == "btn_ColumnZero") colIndex = 0;
            else if (clickedButton.Name == "btn_ColumnOne") colIndex = 1;
            else if (clickedButton.Name == "btn_ColumnTwo") colIndex = 2;
            else if (clickedButton.Name == "btn_ColumnThree") colIndex = 3;
            else if (clickedButton.Name == "btn_ColumnFour") colIndex = 4;
            else if (clickedButton.Name == "btn_ColumnFive") colIndex = 5;
            else if (clickedButton.Name == "btn_ColumnSix") colIndex = 6;

            if (colIndex != -1)
            {
                DropPieces(colIndex);
            }
        }
    }
}
