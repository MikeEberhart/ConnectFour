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
        private WelcomeForm wForm;
        public GameOverForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            wForm = wf;
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
        }

        private void playAgain()
        {
            wForm.Show();
            this.Hide();
        }
    }
}
