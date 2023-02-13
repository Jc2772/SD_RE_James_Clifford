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
        auction auction;
        livestock livestock;
        frmLivestockHome parent;
        public frmSetTime()
        {
            InitializeComponent();
        }
        public frmSetTime(frmLivestockHome parent,auction auction,livestock livestock)
        {
            this.parent = parent;
            this.auction = auction;
            this.livestock = livestock;
            InitializeComponent();
        }

        private void btnSetTime1_Click(object sender, EventArgs e)
        {
            DateTime date = dpkSetTime.Value;
            //got this line from https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time
            DateTime today = DateTime.Today;
            if (DateTime.Compare(date,today) <= 0)
            {
                MessageBox.Show("invalid date","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                auction.addAuction(date);
            }
        }

        private void btnSetTime3_Click(object sender, EventArgs e)
        {
            DateTime date = dpkSetTime.Value;
            DateTime today = DateTime.Today;
            if (DateTime.Compare(date, today) <= 0)
            {
                MessageBox.Show("invalid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                auction.DeRegisterTimeSlot(date);
                MessageBox.Show("Auction date removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSetTime2_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void dpkSetTime_ValueChanged(object sender, EventArgs e)
        {
            lblSetTime2.Text = dpkSetTime.Text;
        }
    }
}
