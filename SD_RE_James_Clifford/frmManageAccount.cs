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
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            spoof_accounts item = new spoof_accounts();
            this.found = false;
            List<string> name = item.getAccName();
            for(int i = 1; i <= name.Count; i++)
            {
                cbxManageAccount.Items.Add("id-" + i + " name-" + name[i-1]);
            }
        }

        private void cbxManageAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            spoof_accounts item = new spoof_accounts();
            List<string> name = item.getAccName(), address1 = item.getAccAddress1(), phone = item.getAccPhone(), email = item.getAccEmail();
            for (int i = 1; i <= name.Count;i++)
            {
                if (cbxManageAccount.Text.Contains(i.ToString()))
                {
                    lblManageAccounts2.Text = "\n\nAccount: " + name[i-1] + "\n\nAddress 1: " + address1[i-1]
                        + "\n\nPhone: " + phone[i-1] + "\n\nEmail: " + email[i-1];
                    id = i - 1;
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

        private void btnManageAccount2_Click(object sender, EventArgs e)
        {
            if (found == true) {
                spoof_accounts spoof = new spoof_accounts();
                spoof.removeAccounts(id);
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
