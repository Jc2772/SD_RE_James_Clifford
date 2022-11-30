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
        public frmLivestockHome()
        {
            InitializeComponent();
        }

        /*The code in these methods are from https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form */
        private void btnLivestockHome1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewAccount AccountOptions = new frmNewAccount(this,accounts);
            AccountOptions.Show();
        }

        private void btnLivestockHome2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetTime SetTime = new frmSetTime(this,auction,livestock);
            SetTime.Show();
        }

        private void btnLivestockHome6_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            frmShowdata show_data = new frmShowData(this);
            ShowData.Show();
             */
        }

        private void btnLivestockHome7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLivestockHome3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterLivestock registerLivestock = new frmRegisterLivestock(this,livestock,auction);
            registerLivestock.Show();
        }

        private void btnLivestockHome8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageAccount ManageAccount = new frmManageAccount(this,accounts);
            ManageAccount.Show();
        }
    }
}
