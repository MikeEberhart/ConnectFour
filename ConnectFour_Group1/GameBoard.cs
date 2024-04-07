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
    public static class GameBoard
    {
        //make 2d array with 6 rows and 7 columns
        public static Button[,] boardArray = new Button[6, 7];

        public static void AddPieces(Panel pnl)
        {
            //clear out array to avoid repetition or breakage
            Array.Clear(boardArray, 0, boardArray.Length);
            int rows = 0;
            int columns = 0;
            foreach (Button piece in pnl.Controls.OfType<Button>())
            {
                boardArray[rows, columns] = piece;
                columns++;
                if (columns == 7)
                {
                    columns = 0;
                    rows++;
                }
            }
        }
    }
}
