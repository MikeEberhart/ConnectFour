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
        public SinglePlayerForm()
        {
            InitializeComponent();
        }

        private void Player_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //Console.WriteLine(btn);
            //string name = btn;
            if(btn != null)
            {
                if (click == 0)
                {
                    btn.BackgroundImage = Connect4Testing.Properties.Resources.YellowPieceSmall;
                    click++;
                }
                else
                {
                    btn.BackgroundImage = Connect4Testing.Properties.Resources.RedPieceSmall;
                    click--;
                }
            }

        }


    }
}
