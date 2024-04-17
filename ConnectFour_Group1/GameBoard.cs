using Connect4Testing.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public class GameBoard
    {
        private CellData[,] gameBoard = new CellData[6, 7];
        private int playerTurn = 0;
        private int tempPlayerTurn;
        private Label turnDisplay;
        private bool btnHasBeenClicked = false;
        public int GetPlayerTurn()
        {
            return tempPlayerTurn;
        }
        public void SetPlayerTurn(int p)
        {
            tempPlayerTurn = p;
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
                gameBoard[rows, columns] = new CellData(rows, columns, piece);
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
        public void DropPieces(int colindex, int form)
        {
            int rowindex = GetRow(colindex);

            if (rowindex != -1)
            {
                if (playerTurn == 0)
                {
                    turnDisplay.Text = "Player Two's Turn";
                    gameBoard[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.RedPiece2;
                    gameBoard[rowindex, colindex].GetButton().Tag = "0";
                    btnHasBeenClicked = false; // is this the best place? 
                    if (WinChecker(GetGameBoard())) WinMessage();
                    SetPlayerTurn(playerTurn); // used to set playerTurn before playerTurn++
                    playerTurn++;
                    if (!WinChecker(GetGameBoard()) && form != 2)
                    {
                        ComputerTurn();
                    }
                }
                else if (playerTurn == 1)
                {
                    turnDisplay.Text = "Player One's Turn";
                    gameBoard[rowindex, colindex].GetButton().BackgroundImage = Properties.Resources.YellowPiece2;
                    gameBoard[rowindex, colindex].GetButton().Tag = "1";
                    btnHasBeenClicked = false; // is this the best place?
                    if (WinChecker(GetGameBoard())) WinMessage();
                    SetPlayerTurn(playerTurn); // used to set playerTurn before playerTurn--
                    playerTurn--;
                }
            }
        }
        public void ComputerTurn()
        {
            CellData[,] evalBoard = new CellData[6, 7];
            //COPY ARRAY - DOES NOT AFFECT ORIGINAL, NEEDS TO BE DONE THIS WAY
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] != null)
                    {
                        evalBoard[i, j] = new CellData(gameBoard[i, j].GetRow(), gameBoard[i, j].GetColumn(), gameBoard[i,j].GetButton());
                    }
                }
            }
            if ((string)gameBoard[0, 3].GetButton().Tag == null)
            {
                DropPieces(3, 1);
            }
            else
            {
                DropPieces(EvaluateBoard(evalBoard), 1);
            }
        }
        public int EvaluateBoard(CellData[,] compboard)
        {
            CellData[,] playerboard = new CellData[6, 7];
            Random random = new Random();
            int generatedColumn = random.Next(0,gameBoard.GetLength(1));
            //make copy to evaluate
            for (int i = 0; i < compboard.GetLength(0); i++)
            {
                for (int j = 0; j < compboard.GetLength(1); j++)
                {
                    if (compboard[i, j] != null)
                    {;
                        playerboard[i, j] = new CellData(compboard[i, j].GetRow(),compboard[i, j].GetColumn(),compboard[i,j].GetButton());
                    }
                }
            }

            //check AI moves
            for (int colindex = 0; colindex < compboard.GetLength(1); colindex++)
            {
                int rowindex = GetRow(colindex);
                if (rowindex != -1)
                {
                    //AI
                    //"play" comp moves for selected column
                    compboard[rowindex, colindex].GetButton().Tag = "1";
                    //if this results in a win run this
                    if (WinChecker(compboard))
                    {
                        //PrintBoard(compboard);
                        Console.WriteLine($"comp winning move at {rowindex}, {colindex}.");
                        return colindex;
                    }
                    // if it doesn't run this
                    else
                    {
                        //PLAYER
                        //reset tag to initial state
                        compboard[rowindex, colindex].GetButton().Tag = null;
                        //play player moves
                        playerboard[rowindex,colindex].GetButton().Tag = "0";
                        // if it wins run this
                        if (WinChecker(playerboard))
                        {

                            Console.WriteLine($"player winning move at {rowindex}, {colindex}.");
                            return colindex;
                        }
                        //reset tag
                        playerboard[rowindex, colindex].GetButton().Tag = null;
                    }
                }
            }
            return generatedColumn;
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
        public void Piece_Placement(object sender, EventArgs e, int form)
        {
            btnHasBeenClicked = true; // is this the best spot for this i wonder? 
            Button clickedButton = (Button)sender;
            int colIndex = -1;
            if (clickedButton.Name == "btn_ColumnZero") colIndex = 0;
            else if (clickedButton.Name == "btn_ColumnOne") colIndex = 1;
            else if (clickedButton.Name == "btn_ColumnTwo") colIndex = 2;
            else if (clickedButton.Name == "btn_ColumnThree") colIndex = 3;
            else if (clickedButton.Name == "btn_ColumnFour") colIndex = 4;
            else if (clickedButton.Name == "btn_ColumnFive") colIndex = 5;
            else if (clickedButton.Name == "btn_ColumnSix") colIndex = 6;
            if(colIndex != -1 && !ColumnIsFull(colIndex))
            {
                DropPieces(colIndex, form);
            }
            else
            {
                MessageBox.Show("Column is full. Please select a new column");
            }
        }

        public bool WinChecker(CellData[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col].GetButton().Tag != null)
                    {
                        //DIAGONAL -> "/"
                        if (row + 3 < board.GetLength(0) && col + 3 < board.GetLength(1))
                        {
                            if (board[row, col].GetButton().Tag == board[row + 3, col + 3].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 2, col + 2].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 1, col + 1].GetButton().Tag)
                            {
                                Console.WriteLine("hgfjhgfcbbfvdbgchggf");
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
                                Console.WriteLine("mmmmmmmmmmm");
                                return true;

                            }
                        }

                        //COLUMN
                        if (row + 3 < board.GetLength(0))
                        {
                            if (board[row, col].GetButton().Tag == board[row + 3, col].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 2, col].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 1, col].GetButton().Tag)
                            {
                                Console.WriteLine("aaaaaaaaa");
                                return true;
                            }
                        }

                        //ROW
                        if (col + 3 < board.GetLength(1))
                        {
                            if (board[row, col].GetButton().Tag == board[row, col + 3].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row, col + 2].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row, col + 1].GetButton().Tag)
                            {
                                Console.WriteLine("eeeeeeeee");
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public void ShowPossibleMoves(object sender)// MOUSE ENTER // used to see which button is being entered // not working just yet
        {
            Button hoverOnButton = (Button)sender;
            if (hoverOnButton.Name == "btn_ColumnZero") TempImagePlacement(0);
            else if (hoverOnButton.Name == "btn_ColumnOne") TempImagePlacement(1);
            else if (hoverOnButton.Name == "btn_ColumnTwo") TempImagePlacement(2);
            else if (hoverOnButton.Name == "btn_ColumnThree") TempImagePlacement(3);
            else if (hoverOnButton.Name == "btn_ColumnFour") TempImagePlacement(4);
            else if (hoverOnButton.Name == "btn_ColumnFive") TempImagePlacement(5);
            else if (hoverOnButton.Name == "btn_ColumnSix") TempImagePlacement(6);
        }
        public void HidePossibleMove(object sender)// MOUSE LEAVE // used to see which button has be exited by the mouse // not working just yet
        {
            Button hoverOnButton = (Button)sender;
            if (hoverOnButton.Name == "btn_ColumnZero" && btnHasBeenClicked == false) TempImageRemoved(0);
            else if (hoverOnButton.Name == "btn_ColumnOne" && btnHasBeenClicked == false) TempImageRemoved(1);
            else if (hoverOnButton.Name == "btn_ColumnTwo" && btnHasBeenClicked == false) TempImageRemoved(2);
            else if (hoverOnButton.Name == "btn_ColumnThree" && btnHasBeenClicked == false) TempImageRemoved(3);
            else if (hoverOnButton.Name == "btn_ColumnFour" && btnHasBeenClicked == false) TempImageRemoved(4);
            else if (hoverOnButton.Name == "btn_ColumnFive" && btnHasBeenClicked == false) TempImageRemoved(5);
            else if (hoverOnButton.Name == "btn_ColumnSix" && btnHasBeenClicked == false) TempImageRemoved(6);
        }
        public void TempImageRemoved(int col) // used to remove the temp image // not working just yet
        {
            Button otherButton;
            for (int i = 0; i <= gameBoard.GetLength(0) - 1; i++)
            {
                otherButton = gameBoard[i, col].GetButton();
                if (btnHasBeenClicked == false)
                {
                    otherButton.BackgroundImage = null;
                    break;
                }
            }
        }
        public void TempImagePlacement(int col) // used to place the temp image // not working just yet
        {
            Button thisButton;
            for (int i = 0; i <= gameBoard.GetLength(0) - 1; i++)
            {
                thisButton = gameBoard[i, col].GetButton();
                if (thisButton.Image == null && btnHasBeenClicked == false && playerTurn == 0)
                {
                    thisButton.BackgroundImage = Resources.RedPiece2;
                    break;
                }
                else if (thisButton.Image == null && btnHasBeenClicked == false && playerTurn == 1)
                {
                    thisButton.BackgroundImage = Resources.YellowPiece2;
                    break;
                }
            }
        }
        private bool ColumnIsFull(int col)
        {
            Button currentButton;
            for (int row = 0; row <= gameBoard.GetLength(0) - 1; row++)
            {
                currentButton = gameBoard[row, col].GetButton();
                if (currentButton.BackgroundImage == null)
                {
                    return false;
                }
            }
            return true;
        }
        private void WinMessage()
        {
            if (GetPlayerTurn() == 0)
            {
                turnDisplay.Text = "   Player 2 Wins";
                MessageBox.Show("Player 2(computer) wins.");
            }
            else if (GetPlayerTurn() == 1)
            {
                turnDisplay.Text = "   Player 1 Wins";
                MessageBox.Show("Player 1 wins.");
            }
        }
    }
}
