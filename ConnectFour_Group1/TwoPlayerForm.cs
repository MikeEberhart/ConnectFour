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
        public TwoPlayerForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            wForm = wf;
        }

        private void TwoPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            //AddPieces(); //maybe add this whole function to this form
                           //or make it a public function in the other and call it here
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
