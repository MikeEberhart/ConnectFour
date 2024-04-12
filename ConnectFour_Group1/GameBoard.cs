using Connect4Testing.Properties;
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
        public void SetLabel(Label lbl)
        {
            turnDisplay = lbl;
        }
        public void AddPieces(Panel pnl)
        {
            //clear out array to avoid repetition or breakage
            Array.Clear(gameBoard, 0, gameBoard.Length);
            int rows = 0;
            int columns = 0;
            foreach (Button piece in pnl.Controls.OfType<Button>())
            {
                gameBoard[rows, columns] = new CellData(rows, columns, piece) ;
                columns++;
                if (columns == 7)
                {
                    columns = 0;
                    rows++;
                }
            }
        }
        public void ResetTurn(Panel pnl)
        {
            playerTurn = 0;
            turnDisplay.Text = "Player One's Turn";
            foreach (Button btn in pnl.Controls.OfType<Button>()) // used to reset the Tag properties
            {
                btn.Tag = null;
            }
        }

        public void DropPieces(int colindex)
        {
            int rowindex = GetRow(colindex);

            if (rowindex != -1)
            {
                if (playerTurn == 0)
                {
                    turnDisplay.Text = "Player Two's Turn";
                    gameBoard[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.RedPiece2;
                    gameBoard[rowindex, colindex].GetButton().Tag = "0";
                    Console.WriteLine(playerTurn);
                    playerTurn++;
                }
                else
                {
                    turnDisplay.Text = "Player One's Turn";
                    gameBoard[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.YellowPiece2;
                    gameBoard[rowindex, colindex].GetButton().Tag = "1";
                    Console.WriteLine(playerTurn);
                    playerTurn--;
                }
            }
        }
        
        public bool EvaluateBoard(int colindex, CellData[,] compboard)
        {
            int rowindex = GetRow(colindex);
            CellData[,] playerboard = new CellData[6,7];
            //make copy to evaluate
            for (int i = 0; i < compboard.GetLength(0); i++)
            {
                for (int j = 0; j < compboard.GetLength(1); j++)
                {
                    if (compboard[i, j] != null)
                    {
                        playerboard[i, j] = new CellData(compboard[i, j].GetRow(),
                            compboard[i, j].GetColumn(),
                            compboard[i, j].GetButton());
                    }
                }
            }

            if (rowindex != -1)
            {
                compboard[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.YellowPiece2;
                compboard[rowindex, colindex].GetButton().Tag = "1";
                if (WinChecker(compboard))
                {
                    return true;
                }
                else
                {
                    playerboard[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.RedPiece2;
                    playerboard[rowindex, colindex].GetButton().Tag = "0";
                    if (WinChecker(playerboard))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetRow(int colindex)
        {
            Button currentButton;
            for (int row = 0; row <= gameBoard.GetLength(0) - 1; row++)
            {
                currentButton = gameBoard[row, colindex].GetButton();
                if (currentButton.BackgroundImage == null)
                {
                    return row;
                }
            }
            return -1;
        }
        // could use something like this to change the background pics and just use the buttons as display while they aren't enabled
        public void Piece_Placement(object sender, EventArgs e)
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
                Console.WriteLine(playerTurn); 
            }
        }

        public bool WinChecker(CellData[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col].GetButton().BackgroundImage != null)
                    {
                        //DIAGONAL -> "/"
                        if (row + 3 < board.GetLength(0) && col + 3 < board.GetLength(1))
                        {
                            if (board[row, col].GetButton().Tag == board[row + 3, col + 3].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 2, col + 2].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 1, col + 1].GetButton().Tag)
                            {
                                return true;

                            }
                        }

                        //DIAGONAL -> "\"
                        if (row + 3 < board.GetLength(0) && col - 3 >= 0)
                        {
                            if (board[row, col].GetButton().Tag == board[row + 3, col - 3].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 2, col - 2].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 1, col - 1].GetButton().Tag)
                            {
                                return true;

                            }
                        }

                        //ROW
                        if (row + 3 < board.GetLength(0))
                        {
                            if (board[row, col].GetButton().Tag == board[row + 3, col].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 2, col].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 1, col].GetButton().Tag)
                            {
                                return true;
                            }
                        }

                        //COLUMN
                        if (col + 3 < board.GetLength(1))
                        {
                            if (board[row, col].GetButton().Tag == board[row, col + 3].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row, col + 2].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row, col + 1].GetButton().Tag)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public void ComputerTurn()
        {

            if ((string)gameBoard[0, 3].GetButton().Tag == null)
            {
                DropPieces(3);
            }
            else
            {
            }
        }
    }
}
