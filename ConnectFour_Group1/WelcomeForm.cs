// =====================================================================================
// Authors: Mike Eberhart
//          Donovan Gilliam
//          Chase Miracle
// Date:    01-May-2024
// Desc:    This program is a Connect 4 game with both single and two player game modes.
// ======================================================================================
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
    public partial class WelcomeForm : Form
    {
        private Sound Sound = new Sound();

        public WelcomeForm()
        {
            InitializeComponent();
            CenterToScreen();
            Sound.MusicBack();
        }
        private void btn_SinglePlayer_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            SinglePlayerForm singlePlayer = new SinglePlayerForm(this);
            singlePlayer.Show();
            this.Hide();
        }
        private void btn_TwoPlayer_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            TwoPlayerForm twoPlayer = new TwoPlayerForm(this);
            twoPlayer.Show();
            this.Hide();
        }
        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            StatsForm stats = new StatsForm(this);
            stats.Show();
            this.Hide();
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Sound.ButtonClick();
            Environment.Exit(0);
        }
    }
}
