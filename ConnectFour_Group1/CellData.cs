using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Testing
{
    public class CellData
    {
        private int row {  get; set; }
        private int column {  get; set; }
        private Button btn  {  get; set; }

        public CellData(int r, int c, Button b)
        {
            row = r;
            column = c;
            btn = b;
        }
        public Button GetButton() 
        {
            return btn;
        }
    }
}
