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
        public WelcomeForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_SinglePlayer_Click(object sender, EventArgs e)
        {
            SinglePlayerForm singlePlayer = new SinglePlayerForm(this);
            singlePlayer.Show();
            this.Hide();
        }

        private void btn_TwoPlayer_Click(object sender, EventArgs e)
        {
            TwoPlayerForm twoPlayer = new TwoPlayerForm(this);
            twoPlayer.Show();
            this.Hide();
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            StatsForm stats = new StatsForm(this);
            stats.Show();
            this.Hide();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // public function used all forms to exit the program when the red 'X' is clicked 
        public void ExitProgram() // could use this but just as much code if it was in each form anyways.
        {
            Application.Exit();
        }
    }
}
