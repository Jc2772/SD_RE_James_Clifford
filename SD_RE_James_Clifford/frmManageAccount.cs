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
        frmLivestockHome parent;
        private int id;
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
            if (cbxManageAccount_SelectedIndexChanged == true) { 
                frmUpdateAccount update = new frmUpdateAccount(id,this);
                update.Show();
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            List<int> id = accounts.getId();
            List<string> name = accounts.getAccName();

            for (int i = 0; i <= name.Count; i++)
            {
                cbxManageAccount.Items.Add(id[i] + " name-" + name[i]);
            }
        }

        private void cbxManageAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> name = accounts.getAccName(), Address1 = accounts.getAccAddress1(), Address2 = accounts.getAccAddress2(),Address3 = accounts.getAccAddress3(),Phone = accounts.getAccPhone(),Email = accounts.getAccEmail();
            lblManageAccounts2.Text = "";
            List<int> id = accounts.getId();
            for (int i = 0; i <= name.Count; i++)
            {
                if (cbxManageAccount.Text.Contains(i.ToString()))
                {
                    this.id = id[i];
                    lblManageAccounts2.Text +=
                        "\nname: " + name[i]
                        +"" + id[i]
                        + "\nAddress1: " + Address1[i]
                        + "\nAddress2: " + Address2[i]
                        + "\nAddress3: " + Address3[i]
                        + "\nPhone: " + Phone[i]
                        + "\nEmail: " + Email[i];
                }
            }
        }

        private void btnManageAccounts3_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnManageAccount2_Click(object sender, EventArgs e)
        {
            if () {
                accounts.removeAccounts(id);
                this.Refresh();
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         public void checkUpdate(String Name, String Address1, String Address2, String Address3, String Phone, String Email, int id)
        {
            List<string> values = new List<string> { Name, Address1, Address2, Address3, Phone, Email };
            for (int i = 0; i < 5; i++)
            {
                if (string.IsNullOrEmpty(values[i]))
                {
                    switch (i)
                    {
                        case 0:
                            {
                                Name = accounts.getAccName()[id];
                                break;
                            }
                        case 1:
                            {
                                Address1 = accounts.getAccAddress1()[id];
                                break;
                            }
                        case 2:
                            {
                                Address2 = accounts.getAccAddress2()[id];
                                break;
                            }
                        case 3:
                            {
                                Address3 = accounts.getAccAddress3()[id];
                                break;
                            }
                        case 4:
                            {
                                Phone = accounts.getAccPhone()[id];
                                break;
                            }
                        case 5:
                            {
                                Email = accounts.getAccEmail()[id];
                                break;
                            }
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            {
                                Name = values[0];
                                break;
                            }
                        case 1:
                            {
                                Address1 = values[1];
                                break;
                            }
                        case 2:
                            {
                                Address2 = values[2];
                                break;
                            }
                        case 3:
                            {
                                Address3 = values[3];
                                break;
                            }
                        case 4:
                            {
                                Phone = values[4];
                                break;
                            }
                        case 5:
                            {
                                Email = values[5];
                                break;
                            }
                    }
                }
            }
            accounts.updateValues(Name, Address1, Address2, Address3, Phone, Email ,id);
        }
    }
}
