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
        public void Piece_Placement(object sender, int form) // main function used to start the process of placing game pieces
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
            if (colIndex != -1 && !ColumnIsFull(colIndex))
            {
                DropPieces(colIndex, form);
            }
            else
            {
                MessageBox.Show("Column is full. Please select a new column");
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
                    gameBoard[rowindex, colindex].GetButton().BackgroundImage = Resources.RedPiece2;
                    gameBoard[rowindex, colindex].GetButton().Tag = "0";
                    AnimationStart(rowindex, colindex);
                    if (WinChecker(GetGameBoard())) WinMessage();
                    if (TieGameCheck()) SetPlayerTurn(-1); // if tie game playerTurn = -1
                    if (TieGameCheck()) WinMessage();
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
                    gameBoard[rowindex, colindex].GetButton().BackgroundImage = Resources.YellowPiece2;
                    gameBoard[rowindex, colindex].GetButton().Tag = "1";
                    AnimationStart(rowindex, colindex);
                    if (WinChecker(GetGameBoard())) WinMessage();
                    if (TieGameCheck()) SetPlayerTurn(-1); // if tie game playerTurn = -1
                    if (TieGameCheck()) WinMessage();
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
            Random random = new Random();
            int generatedColumn = random.Next(0,gameBoard.GetLength(1));
            //re-roll random number if column is full
                                                  //while (compboard[5, generatedColumn].GetButton().Tag != null)
            while (ColumnIsFull(generatedColumn)) // same functionality as above, just easier to read
            {
                int skip = generatedColumn;
                while (generatedColumn == skip)
                {
                    generatedColumn = random.Next(0, gameBoard.GetLength(1));
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
                        compboard[rowindex, colindex].GetButton().Tag = null;
                        return colindex;
                    }
                    // if it doesn't run this
                    else
                    {
                        //PLAYER
                        //reset tag to initial state
                        compboard[rowindex, colindex].GetButton().Tag = null;
                        //play player moves
                        compboard[rowindex, colindex].GetButton().Tag = "0";
                        // if it wins run this
                        if (WinChecker(compboard))
                        {
                            compboard[rowindex, colindex].GetButton().Tag = null;
                            return colindex;
                        }
                        //reset tag
                        compboard[rowindex, colindex].GetButton().Tag = null;
                    }
                }
            }
            return generatedColumn;
        }
        public bool WinChecker(CellData[,] board) // Checking for the win
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

                        //COLUMN
                        if (row + 3 < board.GetLength(0))
                        {
                            if (board[row, col].GetButton().Tag == board[row + 3, col].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 2, col].GetButton().Tag
                                && board[row, col].GetButton().Tag == board[row + 1, col].GetButton().Tag)
                            {
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
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool TieGameCheck()// checking if the game is a tie game or not 
        {
            for (int col = 0; col < gameBoard.GetLength(1); col++)
            {
                if (ColumnIsFull(col) != true)
                {
                    return false;
                }
            }
            return true;
        }
        public int GetRow(int colindex)// used to return the next open row in said column
        {
            Button currentButton;
            for (int row = 0; row <= gameBoard.GetLength(0) - 1; row++)
            {
                currentButton = gameBoard[row, colindex].GetButton();
                if (currentButton.Tag == null)
                {
                    return row;
                }
            }
            return -1;
        }
        private bool ColumnIsFull(int col)// used to check if the column is full - if column is full - return true;
        {
            Button currentButton = gameBoard[5, col].GetButton();
            if (currentButton.Tag != null) return true;
            else return false;
        }
        public void ShowPossibleMoves(object sender)// MOUSE ENTER // used to see which button is being entered // not working just yet
        {
            Button enterButton = (Button)sender;
            if (enterButton.Name == "btn_ColumnZero") TempImagePlacement(0);
            else if (enterButton.Name == "btn_ColumnOne") TempImagePlacement(1);
            else if (enterButton.Name == "btn_ColumnTwo") TempImagePlacement(2);
            else if (enterButton.Name == "btn_ColumnThree") TempImagePlacement(3);
            else if (enterButton.Name == "btn_ColumnFour") TempImagePlacement(4);
            else if (enterButton.Name == "btn_ColumnFive") TempImagePlacement(5);
            else if (enterButton.Name == "btn_ColumnSix") TempImagePlacement(6);
        }
        public void HidePossibleMove(object sender)// MOUSE LEAVE // used to see which button has be exited by the mouse // not working just yet
        {
            Button leaveButton = (Button)sender;
            if (leaveButton.Name == "btn_ColumnZero") TempImageRemoved(0);
            else if (leaveButton.Name == "btn_ColumnOne") TempImageRemoved(1);
            else if (leaveButton.Name == "btn_ColumnTwo") TempImageRemoved(2);
            else if (leaveButton.Name == "btn_ColumnThree") TempImageRemoved(3);
            else if (leaveButton.Name == "btn_ColumnFour") TempImageRemoved(4);
            else if (leaveButton.Name == "btn_ColumnFive") TempImageRemoved(5);
            else if (leaveButton.Name == "btn_ColumnSix") TempImageRemoved(6);
        }
        public void TempImagePlacement(int col) // used to place the temp image
        {
            if (!ColumnIsFull(col))
            {
                int row = GetRow(col);
                Button thisButton = gameBoard[row, col].GetButton();
                if (thisButton.Tag == null && thisButton.BackgroundImage == null && playerTurn == 0)
                {
                    thisButton.BackgroundImage = Resources.RedPiece2;
                }
                else if (thisButton.Tag == null && thisButton.BackgroundImage == null && playerTurn == 1)
                {
                    thisButton.BackgroundImage = Resources.YellowPiece2;
                }
            }
        }
        public void TempImageRemoved(int col) // used to remove the temp image
        {
            if (!ColumnIsFull(col))
            {
                int row = GetRow(col);
                Button otherButton;
                otherButton = gameBoard[row, col].GetButton();
                if (otherButton.Tag == null)
                {
                    otherButton.BackgroundImage = null;
                }
            }
        }
        private void WinMessage()// used to display the winning/gameover message
        {
            int results = GetPlayerTurn();
            if (results == 0)
            {
                turnDisplay.Text = "   Player 2 Wins!";
                MessageBox.Show("Player 2(computer) wins.");
            }
            if (results == 1)
            {
                turnDisplay.Text = "   Player 1 Wins!";
                MessageBox.Show("Player 1 wins.");
            }
            if (results == -1)
            {
                turnDisplay.Text = "     Tie Game!";
                MessageBox.Show("The Game is a Tie");
            }
        }
        private async void AnimationStart(int row, int col) //fuction to await the Task FallingGamePieces
        {
            await FallingGamePieces(row, col);
        }
        //private async void AnimationEnd(int row, int col) // trying to make a function to stop code from proceeding until AnimationStart is finished
        //{
        //    await WaitingOnPiece(row, col);
        //}
        private async Task FallingGamePieces(int row, int col) // function performing the animations for the pieces dropping
        {
            //animationIsFinished = false;
            Button tempButton = new Button();
            tempButton = gameBoard[row, col].GetButton();
            int endYAxis = tempButton.Location.Y;
            //endingLocation = endYAxis;
            int startYAxis = -30;
            int tempYAxis = endYAxis - 10;
            tempButton.Location = new Point(tempButton.Location.X, startYAxis);
            while (tempButton.Location.Y != endYAxis)
            {
                tempButton.Location = new Point(tempButton.Location.X, tempButton.Location.Y + 5);
                if (tempButton.Location.Y >= tempYAxis)
                {
                    tempButton.Location = new Point(tempButton.Location.X, endYAxis);
                }
                //if (tempButton.Location.Y == endYAxis) animationIsFinished = true;
                //Console.WriteLine(tempButton.Location.Y);
                await Task.Delay(1);
            }
            //await Task.Delay(500);
        }
    }
}
