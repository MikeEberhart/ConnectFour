using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public partial class SinglePlayerForm : Form
    {
        int click = 0;
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
        private void DropPieces(object sender,int click, int colindex)
        {

        }
        
        private int GetRow(int colindex)
        {
            Button currentButton;
            for (int row = boardArray.GetLength(0) -1; row >= 0; row--) 
            { 
                currentButton = boardArray[row, colindex];
                if (currentButton.BackgroundImage != Connect4Testing.Properties.Resources.YellowPiece2 && currentButton.BackgroundImage != Connect4Testing.Properties.Resources.RedPiece2)
                {
                    return row;
                }    
            }
            return -1;
        }
        // could use something like this to change the background pics and just use the buttons as display while they aren't enabled
        private void Piece_Placement(object sender, EventArgs e)
        {
            if (sender == btn_ColumnOne)
            {
                DropPieces(sender, click, 0);
                if (click == 0)
                {
                    lbl_TurnDisplay.Text = "Player Two's Turn";

                    btn_ZeroZero.BackgroundImage = Connect4Testing.Properties.Resources.YellowPiece2;
                    click++;
                }
                else
                {
                    lbl_TurnDisplay.Text = "Player One's Turn";
                    btn_ZeroZero.BackgroundImage = Connect4Testing.Properties.Resources.RedPiece2;
                    click--;
                }
            }
            if (sender == btn_ColumnTwo)
            {
                if (click == 0)
                {
                    lbl_TurnDisplay.Text = "Player Two's Turn";
                    btn_ZeroOne.BackgroundImage = Connect4Testing.Properties.Resources.YellowPiece2;
                    click++;
                }
                else
                {
                    lbl_TurnDisplay.Text = "Player One's Turn";
                    btn_ZeroOne.BackgroundImage = Connect4Testing.Properties.Resources.RedPiece2;
                    click--;
                }
            }
            if (sender == btn_ColumnThree)
            {
                if (click == 0)
                {
                    lbl_TurnDisplay.Text = "Player Two's Turn";
                    btn_ZeroTwo.BackgroundImage = Connect4Testing.Properties.Resources.YellowPiece2;
                    click++;
                }
                else
                {
                    lbl_TurnDisplay.Text = "Player One's Turn";
                    btn_ZeroTwo.BackgroundImage = Connect4Testing.Properties.Resources.RedPiece2;
                    click--;
                }
            }

        }
        // uses the public function in WelcomeForm to exit the program when the red 'X' is click
        private void SinglePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
        }

        // used when hovering over column selection to show next possible move...work in progress
        private void ShowPossibleMoves(object sender, EventArgs e)
        {
            if (sender == btn_ColumnOne)
            {
                if (click == 0)
                {
                    btn_ZeroZero.BackgroundImage = Properties.Resources.YellowPiece2;
                }
                else
                {
                    btn_ZeroZero.BackgroundImage = Properties.Resources.RedPiece2;
                }
            }
        }

        // used to set the background pic back to null when the mouse is no longer over over column selection...work in progress
        private void RemovePossibleMoves(object sender, EventArgs e)
        {
            if(sender == btn_ColumnOne)
            {
                btn_ZeroZero.BackgroundImage = null;
            }
        }


    }
}
