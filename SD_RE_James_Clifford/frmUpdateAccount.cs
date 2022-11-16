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
        public frmUpdateAccount()
        {
            InitializeComponent();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            String
                Name = ipdUpdateName.Text,
                Address = ipdUpdateAddress1.Text,
                Phone = ipdUpdatePhone.Text,
                Email = ipdUpdateEmail.Text;
            frmNewAccount accountOptions = new frmNewAccount();
            Boolean 
                update_check1 = accountOptions.CheckData(Phone,Email),
                update_check2 = accountOptions.CheckOwner(Name,Address,Phone,Email);
            if (!update_check1)
            {
                MessageBox.Show("Data is is Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Data is invalid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
