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
        public frmLivestockHome()
        {
            InitializeComponent();
        }

        /*The code in these methods are from https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form */
        private void btnLivestockHome1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewAccount AccountOptions = new frmNewAccount(this);
            AccountOptions.Show();
        }

        private void btnLivestockHome2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetTime SetTime = new frmSetTime(this);
            SetTime.Show();
        }

        private void btnLivestockHome6_Click(object sender, EventArgs e)
        {
            /*
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
            frmRegisterLivestock registerLivestock = new frmRegisterLivestock();
            registerLivestock.Show();
        }
    }
}
