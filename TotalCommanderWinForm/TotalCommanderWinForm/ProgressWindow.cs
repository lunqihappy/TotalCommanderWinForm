using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCommanderWinForm
{
    public partial class ProgressWindow : Form
    {
        public ProgressWindow()
        {
            InitializeComponent();
        }

        public delegate void CancelationPaddingHandler(object sender, EventArgs e);
        public event CancelationPaddingHandler Cancel;

        public void UpdateProgress(int progress)
        {
            v_ProgressBar_Progress.Value = progress;
        }

        private void v_Button_Background_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void v_Button_Cancel_Click(object sender, EventArgs e)
        {
            var copy = Cancel;
            if (Cancel != null)
            {
                copy(this, new EventArgs());
            }
        }
        

    }
}
