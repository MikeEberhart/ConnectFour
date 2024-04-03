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

        // could use something like this to change the background pics and just use the buttons as display while they aren't enabled
        private void Piece_Placement(object sender, EventArgs e)
        {
            if(sender == btn_column_one)
            {
                if (click == 0)
                {
                    btn_zero_zero.BackgroundImage = Connect4Testing.Properties.Resources.YellowPiece2;
                    click++;
                }
                else
                {
                    btn_zero_zero.BackgroundImage = Connect4Testing.Properties.Resources.RedPiece2;
                    click--;
                }
            }
            if(sender == btn_column_two)
            {
                if (click == 0)
                {
                    btn_zero_one.BackgroundImage = Connect4Testing.Properties.Resources.YellowPiece2;
                    click++;
                }
                else
                {
                    btn_zero_one.BackgroundImage = Connect4Testing.Properties.Resources.RedPiece2;
                    click--;
                }
            }
            if (sender == btn_column_three)
            {
                if (click == 0)
                {
                    btn_zero_one.BackgroundImage = Connect4Testing.Properties.Resources.YellowPiece2;
                    click++;
                }
                else
                {
                    btn_zero_one.BackgroundImage = Connect4Testing.Properties.Resources.RedPiece2;
                    click--;
                }
            }

        }


    }
}
