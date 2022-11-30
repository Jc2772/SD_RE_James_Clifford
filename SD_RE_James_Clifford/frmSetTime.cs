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
        spoof_auction auction;
        spoof_livestock livestock;
        frmLivestockHome parent;
        public frmSetTime()
        {
            InitializeComponent();
        }
        public frmSetTime(frmLivestockHome parent,spoof_auction auction,spoof_livestock livestock)
        {
            this.parent = parent;
            this.auction = auction;
            this.livestock = livestock;
            InitializeComponent();
        }

        private void btnSetTime1_Click(object sender, EventArgs e)
        {
            String date = dpkSetTime.Text;


        }

        private void btnSetTime3_Click(object sender, EventArgs e)
        {
            String date = dpkSetTime.Text;
            auction.removeAuction(date,livestock);
            MessageBox.Show("Auction date removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSetTime2_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
