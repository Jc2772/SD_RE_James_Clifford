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
    public partial class frmUpdateAccount7 : Form
    {
        private int id;
        frmManageAccount accounts;
        public frmUpdateAccount7()
        {
            InitializeComponent();
        }
        public frmUpdateAccount7(int id, frmManageAccount accounts)
        {
            this.id = id;
            this.accounts = accounts;
            InitializeComponent();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            String
                ForeName = ipdUpdateAccount1.Text,
                Surname = ipdUpdateAccount3.Text,
                Address1 = ipdUpdateAccount3.Text,
                Address2 = ipdUpdateAccount4.Text,
                Address3 = ipdUpdateAccount5.Text,
                Phone = ipdUpdateAccount6.Text,
                Email = ipdUpdateAccount7.Text;
            frmNewAccount accountOptions = new frmNewAccount();
            Boolean
                update_check1 = accountOptions.CheckPhone(Phone),
                update_check2 = accountOptions.CheckEmail(Email); ;
            if ((update_check1 && update_check2) || (string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(Phone)))
            {
                MessageBox.Show("Data is is Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                accounts.checkUpdate(ForeName,Surname, Address1, Address2, Address3, Phone, Email, id);
            }
            else if(!update_check1)
            {
                MessageBox.Show("Data is invalid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (!update_check2)
            {
                MessageBox.Show("Email is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
