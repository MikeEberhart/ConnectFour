using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    internal class CellData
    {
        private int row;
        private int column;
        private Button btn;

        public CellData(int r, int c, Button b)
        {
            row = r;
            column = c;
            btn = b;
        }
        public int GetRow()
        {
            return row;
        }
        public int GetColumn()
        {
            return column;
        }
        public Button GetButton()
        {
            return btn;
        }
    }
}
