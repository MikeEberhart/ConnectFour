using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Testing
{
    internal class CellData
    {
        private int row;
        private int column;

        public CellData(int r, int c)
        {
            row = r;
            column = c;
        }
        public int GetRow()
        {
            return row;
        }
        public int GetColumn()
        {
            return column;
        }
    }
}
