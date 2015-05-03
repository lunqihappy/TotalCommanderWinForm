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

        public void UpdateProgress(int progress)
        {
            v_ProgressBar_Progress.Value = progress;
        }

        private void v_Button_Background_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
