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
    public partial class frmSetTime : Form
    {
        private spoof_auction auction = new spoof_auction();
        frmLivestockHome parent;
        public frmSetTime()
        {
            InitializeComponent();
        }
        public frmSetTime(frmLivestockHome parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnSetTime1_Click(object sender, EventArgs e)
        {
            String date = dpkSetTime.Text;


        }

        private void btnSetTime3_Click(object sender, EventArgs e)
        {
            String date = dpkSetTime.Text;
            auction.removeAuction(date);
        }
    }
}
