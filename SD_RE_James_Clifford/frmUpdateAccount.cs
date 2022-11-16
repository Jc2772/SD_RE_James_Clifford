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
    public partial class frmUpdateAccount : Form
    {
        private int id;
        public frmUpdateAccount()
        {
            InitializeComponent();
        }
        public frmUpdateAccount(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            String
                Name = ipdUpdateName.Text,
                Address1 = ipdUpdateAddress1.Text,
                Phone = ipdUpdatePhone.Text,
                Email = ipdUpdateEmail.Text;
            frmNewAccount accountOptions = new frmNewAccount();
            Boolean
                update_check1 = accountOptions.CheckData(Phone, Email);
            if (!update_check1)
            {
                MessageBox.Show("Data is is Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new spoof().updateValues(Name, Address1, Phone, Email, id);
            }
            else
            {
                MessageBox.Show("Data is invalid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
