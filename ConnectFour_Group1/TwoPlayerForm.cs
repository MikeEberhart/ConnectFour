using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public partial class TwoPlayerForm : Form
    {
        private WelcomeForm wForm;
        private GameBoard gameBoardHere = new GameBoard();
        private Sound Sound = new Sound();

        public TwoPlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.SetLabel(lbl_TurnDisplay);
            wForm = wf;
            //Sound.MusicBack();
        }
        private void PlacingPieces(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            gameBoardHere.Piece_Placement(sender, 2);
            if (gameBoardHere.WinChecker(gameBoardHere.GetGameBoard()))
            {
                GameOver();
            }
            else if (gameBoardHere.TieGameCheck())
            {
                GameOver();
            }
        }
        private void TwoPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sound.ButtonClick();
            Environment.Exit(0);
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            Environment.Exit(0);
        }
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.ResetTurn(pnl_BoardPanel);
            ShowFormButtons();
            foreach (Button piece in pnl_BoardPanel.Controls.OfType<Button>())
            {
                piece.BackgroundImage = null;
            }
        }
        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            wForm.Show();
            this.Hide();
        }
        private void GameOver()
        {
            Sound.Warning();
            HideFormButtons();
        }
        public void HideFormButtons() // after a win hide the column buttons // used with gameover function
        {
            btn_ColumnZero.Visible = false;
            btn_ColumnOne.Visible = false;
            btn_ColumnTwo.Visible = false;
            btn_ColumnThree.Visible = false;
            btn_ColumnFour.Visible = false;
            btn_ColumnFive.Visible = false;
            btn_ColumnSix.Visible = false;
            btn_MainMenu.Location = new Point(270, 438);
            btn_PlayAgain.Location = new Point(91, 438);
            btn_Quit.Location = new Point(449, 438);
        }
        public void ShowFormButtons() // used to show buttons again // used with playagain button
        {
            btn_ColumnZero.Visible = true;
            btn_ColumnOne.Visible = true;
            btn_ColumnTwo.Visible = true;
            btn_ColumnThree.Visible = true;
            btn_ColumnFour.Visible = true;
            btn_ColumnFive.Visible = true;
            btn_ColumnSix.Visible = true;
            btn_MainMenu.Location = new Point(270, 531);
            btn_PlayAgain.Location = new Point(91, 531);
            btn_Quit.Location = new Point(449, 531);
        }
        private void ShowMove(object sender, EventArgs e) // MOUSE ENTER // not working
        {
            gameBoardHere.ShowPossibleMoves(sender);
        }
        private void HideMove(object sender, EventArgs e) // MOUSE LEAVE // not working
        {
            gameBoardHere.HidePossibleMove(sender);
        }
    }
}
