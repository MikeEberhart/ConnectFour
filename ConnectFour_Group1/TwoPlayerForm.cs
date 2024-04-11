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
    public partial class TwoPlayerForm : Form
    {
        private WelcomeForm wForm;
        private GameBoard gameBoardHere = new GameBoard(); // any way to do this without being static? 
        public TwoPlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.SetLabel(lbl_TurnDisplay);
            wForm = wf;
            //int num = 0;
            //foreach (CellData cldta in cellDataArray)
            //{
            //    num++;
            //    cldta.GetButton().Text = num.ToString(); // used to see the order of the buttons in the panel - delete later
            //}
        }

        private void PlacingPieces(object sender, EventArgs e)
        {
            gameBoardHere.Piece_Placement(sender, e);
        }

        private void TwoPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            gameBoardHere.AddPieces(pnl_BoardPanel);
            gameBoardHere.ResetTurn(pnl_BoardPanel);
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
    }
}
