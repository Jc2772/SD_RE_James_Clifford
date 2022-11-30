﻿using System;
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
        spoof_accounts accounts;
        public frmManageAccount()
        {
            InitializeComponent();
        }
        public frmManageAccount(frmLivestockHome parent,spoof_accounts accounts)
        {
            this.parent = parent;
            this.accounts = accounts;
            InitializeComponent();
        }

        private void btnManageAccount1_Click(object sender, EventArgs e)
        {
            if (found == true) { 
                frmUpdateAccount update = new frmUpdateAccount(id,accounts);
                update.Show();
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            
            this.found = false;
            List<string> name = accounts.getAccName();
            for(int i = 1; i <= name.Count; i++)
            {
                cbxManageAccount.Items.Add("id-" + i + " name-" + name[i-1]);
            }
        }

        private void cbxManageAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<string> name = accounts.getAccName(), address1 = accounts.getAccAddress1(), phone = accounts.getAccPhone(), email = accounts.getAccEmail();
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
                accounts.removeAccounts(id);
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
