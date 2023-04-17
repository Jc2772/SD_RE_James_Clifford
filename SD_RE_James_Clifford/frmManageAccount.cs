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
        frmLivestockHome parent;
        private int id;
        accounts accounts;
        public frmManageAccount()
        {
            InitializeComponent();
        }
        public frmManageAccount(frmLivestockHome parent,accounts accounts)
        {
            this.parent = parent;
            this.accounts = accounts;
            InitializeComponent();
        }

        private void btnManageAccount1_Click(object sender, EventArgs e)
        {
            if (cbxManageAccount.SelectedIndex > -1) { 
                frmUpdateAccount7 update = new frmUpdateAccount7(id,this);
                update.Show();
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManageAccount_Load(object sender, EventArgs e)
        {
            List<string> name = accounts.getAccName();
            List<int> id = accounts.getId();
            for (int i = 0; i < name.Count; i++)
            {
                cbxManageAccount.Items.Add(name[i] + "-" + id[i]);
            }
        }

        private void cbxManageAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> name = accounts.getAccName(), Address1 = accounts.getAccAddress1(), Address2 = accounts.getAccAddress2(),Address3 = accounts.getAccAddress3(),Phone = accounts.getAccPhone(),Email = accounts.getAccEmail();
            List<int> id = accounts.getId();
            for (int i = 0; i < name.Count; i++)
            {
                if (cbxManageAccount.Text.Contains(name[i]))
                {
                    lblManageAccounts2.Text = "Account Display";
                    this.id = id[i];
                    lblManageAccounts2.Text +=
                        "\nname: " + name[i]
                        +"\nid: " + id[i]
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
            if (cbxManageAccount.SelectedIndex > -1) {
                accounts.removeAccounts(id);
                UpdateForm();
                MessageBox.Show("Account has been Removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("you didnt pick a choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         public void checkUpdate(String ForeName,String Surname, String Address1, String Address2, String Address3, String Phone, String Email, int id)
        {
            List<string> values = new List<string> { ForeName,Surname, Address1, Address2, Address3, Phone, Email };
            DataSet dataset = accounts.GetData(id);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                int Counts = 0;
                foreach (DataColumn column in dataset.Tables[0].Columns)
                {
                    if(Counts >= 1 && Counts <= 7)
                    {
                        if (String.IsNullOrEmpty(values[Counts - 1])){
                            switch (Counts)
                            {
                                case 1:
                                    {
                                        ForeName = row[column].ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        Surname = row[column].ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        Address1 = row[column].ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        Address2 = row[column].ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        Address3 = row[column].ToString();
                                        break;
                                    }
                                case 6:
                                    {
                                        Phone = row[column].ToString();
                                        break;
                                    }
                                case 7:
                                    {
                                        Email = row[column].ToString();
                                        break;
                                    }
                            }
                        }
                    }
                    Counts++;
                }
            }
            accounts.updateValues(ForeName,Surname, Address1, Address2, Address3, Phone, Email ,id);
            UpdateForm();
        }
        public void UpdateForm()
        {
            lblManageAccounts2.Text = "";
            cbxManageAccount.Items.Clear();
            List<string> name = accounts.getAccName();
            List<int> id = accounts.getId();
            cbxManageAccount.SelectedIndex = -1;
            for (int i = 0; i < name.Count; i++)
            {
                cbxManageAccount.Items.Add(name[i] + "-" + id[i]);
            }
        }

        private void cbxManageAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            cbxManageAccount.PreviewKeyDown -= cbxManageAccount_PreviewKeyDown;
            if (cbxManageAccount.DroppedDown)
            {
                cbxManageAccount.Focus();
            }
        }

        private void cbxManageAccount_DropDown(object sender, EventArgs e)
        {
            cbxManageAccount.PreviewKeyDown += new PreviewKeyDownEventHandler(cbxManageAccount_PreviewKeyDown);
        }
    }
}
