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
    public partial class GameOverForm : Form
    {
        private WelcomeForm wForm; // not used probably delete later
        private SinglePlayerForm sForm; //could be used to pass the previous game board

        public GameOverForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            wForm = wf;
        }
        public GameOverForm(SinglePlayerForm sf) 
        {
            InitializeComponent();
            CenterToScreen();
            UpdatingData();
            sForm = sf;
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            playAgain();
            sForm.ShowFormButtons();
        }

        private void playAgain()
        {
            sForm.ClearBoard();
            sForm.Show();
            this.Hide();
        }

        private void btn_Review_Click(object sender, EventArgs e)
        {
            sForm.Show();
            sForm.HideFormButtons();
        }

        //function to be used to update the txt file with the new win/loss/tie data from previous game
        private void UpdatingData() 
        {

        }
    }
}
