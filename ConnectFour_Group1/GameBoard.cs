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
    public class GameBoard
    {
        private CellData[,] gameBoard = new CellData[6,7];
        private int playerTurn = 0;
        private Label turnDisplay;
        public int GetPlayerTurn()
        {
            return playerTurn;
        }
        public CellData[,] GetGameBoard()
        {
            return gameBoard;
        }
        public void AddPieces(Panel pnl, CellData[,] board)
        {
            //clear out array to avoid repetition or breakage
            Array.Clear(board, 0, board.Length);
            int rows = 0;
            int columns = 0;
            foreach (Button piece in pnl.Controls.OfType<Button>())
            {
                board[rows, columns] = new CellData(rows, columns, piece) ;
                columns++;
                if (columns == 7)
                {
                    columns = 0;
                    rows++;
                }
            }
        }
        public void ResetTurn()
        {
            playerTurn = 0;
            turnDisplay.Text = "Player One's Turn";
        }

        public void SetLabel(Label lbl)
        {
            turnDisplay = lbl;
        }
        public void DropPieces(int colindex, CellData[,] board)
        {
            int rowindex = GetRow(colindex, board);

            if (rowindex != -1)
            {
                if (playerTurn == 0)
                {
                    turnDisplay.Text = "Player Two's Turn";
                    board[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.YellowPiece2;
                    playerTurn++;
                }
                else
                {
                    turnDisplay.Text = "Player One's Turn";
                    board[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.RedPiece2;
                    playerTurn--;
                }
            }
        }

        public int GetRow(int colindex, CellData[,] board)
        {
            Button currentButton;
            for (int row = 0; row <= board.GetLength(0) - 1; row++)
            {
                currentButton = board[row, colindex].GetButton();
                if (currentButton.BackgroundImage == null)
                {
                    return row;
                }
            }
            return -1;
        }
        // could use something like this to change the background pics and just use the buttons as display while they aren't enabled
        public void Piece_Placement(object sender, EventArgs e, CellData[,] board)
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
                DropPieces(colIndex, board);
            }
        }

        public bool WinChecker()
        {
            return false;
        }
    }
}
