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

        public SinglePlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            GameBoard.AddPieces(pnl_BoardPanel);
            GameBoard.SetLabel(lbl_TurnDisplay);
            wForm = wf;
            int num = 0;
            foreach (Button btn in GameBoard.boardArray)
            {
                num++;
                btn.Text = num.ToString(); // used to see the order of the buttons in the panel - delete later
            }
        }
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            GameBoard.AddPieces(pnl_BoardPanel);
            GameBoard.ResetTurn();
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
        private void Placing_Pieces(object sender, EventArgs e)
        {
            GameBoard.Piece_Placement(sender, e);
        }
        // uses the public function in WelcomeForm to exit the program when the red 'X' is playerTurn
        private void SinglePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
        }

        // used when hovering over column selection to show next possible move...work in progress

    }
}
