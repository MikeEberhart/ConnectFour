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
    public partial class StatsForm : Form
    {
        private WelcomeForm wForm;
        public StatsForm(WelcomeForm wf)
        {
            InitializeComponent();
            CenterToScreen();
            wForm = wf;
        }

        private void StatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wForm.ExitProgram();
        }
    }
}
