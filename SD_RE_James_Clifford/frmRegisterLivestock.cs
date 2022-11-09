using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_RE_James_Clifford
{
    public partial class frmRegisterLivestock : Form
    {
        public frmRegisterLivestock()
        {
            InitializeComponent();
        }

        private void ckxRegisterLivestock1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxRegisterLivestock1.Checked)
            {
                ckxRegisterLivestock2.Checked = false;
            }
        }

        private void ckxRegisterLivestock2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxRegisterLivestock2.Checked)
            {
                ckxRegisterLivestock1.Checked = false;
            }
        }
    }
}
