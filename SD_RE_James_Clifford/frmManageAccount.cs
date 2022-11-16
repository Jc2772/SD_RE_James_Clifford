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
    public partial class frmManageAccount : Form
    {
        public frmManageAccount()
        {
            InitializeComponent();
        }

        private void btnManageAccount1_Click(object sender, EventArgs e)
        {
            frmUpdateAccount update = new frmUpdateAccount();
            update.Show();
        }
    }
}
