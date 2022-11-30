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
    public partial class frmLivestockHome : Form
    {
        spoof_accounts accounts = new spoof_accounts();
        spoof_auction auction = new spoof_auction();
        spoof_livestock livestock = new spoof_livestock();
        spoof_sales sales = new spoof_sales();
        public frmLivestockHome()
        {
            InitializeComponent();
        }

        /*The code in these methods are from https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form */

        private void btnLivestockHome7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewAccount enter = new frmNewAccount(this, accounts);
            enter.Show();
        }

        private void updatederegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageAccount enter = new frmManageAccount(this, accounts);
            enter.Show();
        }

        private void registerLivestockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterLivestock enter = new frmRegisterLivestock(this, livestock, auction);
            enter.Show();
        }

        private void registerSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterSale enter = new frmRegisterSale(this, sales,livestock);
            enter.Show();
        }

        private void queryLivestockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryLivestock enter = new frmQueryLivestock(this, livestock);
            enter.Show();
        }

        private void scheduleAuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetTime enter = new frmSetTime(this, auction, livestock);
            enter.Show();
        }
    }
}
