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
    public class GameLogic
    {
        private Button[,] passedBtnArray;
        public GameLogic(Button[,] btnarray) 
        {
            passedBtnArray = btnarray;
        }
    }
}
