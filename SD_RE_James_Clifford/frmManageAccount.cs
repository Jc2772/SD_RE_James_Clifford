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
        private Boolean found;
        private int id;
        frmLivestockHome parent;
        public frmManageAccount()
        {
            InitializeComponent();
        }
        public frmManageAccount(frmLivestockHome parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnManageAccount1_Click(object sender, EventArgs e)
        {
            if (found == true) { 
                frmUpdateAccount update = new frmUpdateAccount(id);
                update.Show();
            }
        }

        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            spoof_accounts item = new spoof_accounts();
            this.found = false;
            int combo_num = new spoof_accounts().getSize();
            for(int i = 1; i <= combo_num; i++)
            {
                cbxManageAccount.Items.Add("id-" + i + " name-" + item.getAccName(i-1));
            }
        }

        private void cbxManageAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            spoof_accounts item = new spoof_accounts();
            string name = "", address1 = "" ,phone = "", email = "";
            for (int i = 1; i <= item.getSize();i++)
            {
                if (cbxManageAccount.Text.Contains(i.ToString()))
                {
                    name = item.getAccName(i - 1);
                    address1 = item.getAccAddress1(i - 1);
                    phone = item.getAccPhone(i - 1);
                    email = item.getAccEmail(i - 1);
                    lblManageAccounts2.Text = "\n\nAccount: " + name + "\n\nAddress 1: " + address1
                        + "\n\nPhone: " + phone + "\n\nEmail: " + email;
                    id = i;
                    found = true;
                    break;
                }
            }
        }

        private void btnNewAccount3_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
