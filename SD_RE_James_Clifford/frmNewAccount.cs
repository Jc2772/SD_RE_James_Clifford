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
    public partial class frmNewAccount : Form
    {
        frmLivestockHome parent;
        spoof_accounts accounts;
        public frmNewAccount(frmLivestockHome parent,spoof_accounts accounts)
        {
            this.parent = parent;
            this.accounts = accounts;
            InitializeComponent();
        }
        public frmNewAccount()
        {
            InitializeComponent();
        }
        public bool CheckOwner(string name, string Address1, string phone, string email, string Address2, string Address3)
        {
            
            /*The piece of code StringComparison.OrdinalIgnoreCase came from https://www.tutlane.com/tutorial/csharp/csharp-string-equals-method*/
            
            for (int i = 0; i< accounts.getAccPhone().Count; i++) { 
                if (phone.Equals(accounts.getAccPhone()[i]))
                {
                    return true;
                }
                else if (email.Equals(accounts.getAccEmail()[i]))
                {
                    return true;
                }
                else if (Address1.Equals(accounts.getAccAddress1()[i], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (Address2.Equals(accounts.getAccAddress1()[i], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (Address2.Equals(accounts.getAccAddress2()[i], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (Address3.Equals(accounts.getAccAddress3()[i], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if(name.Equals(accounts.getAccName()[i], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        return false;
        }
        public bool CheckData(String Phone,String Email)
        {
            for(int i = 0; i < Phone.Length; i++)
            {
                String num = Phone[i].ToString();
                /* i got variable[i] from https://stackoverflow.com/questions/3581741/c-sharp-equivalent-to-javas-charat*/
                /*i got Character.IsWhitespace https://stackoverflow.com/questions/19478780/how-to-check-if-string-character-is-a-space*/
                if (i == 3 || i == 7)
                {
                    if (!Char.IsWhiteSpace(Phone, 3) || !Char.IsWhiteSpace(Phone, 7))
                    {
                        return false;
                    } 
                }
                else
                {
                    switch (Phone[i])
                    {
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            {
                                break;
                            }
                        default:
                            {
                                return false;
                            }
                    }
                }
            }
            /*i got String.IsNullOrEmpty form https://www.geeksforgeeks.org/c-sharp-isnullorempty-method/#:~:text=In%20C%23%2C%20IsNullOrEmpty()%20is,is%20assigned%20%E2%80%9C%E2%80%9D%20or%20String.*/
            if (Email.Contains("@gmail.com") || Email.Contains("@outlook.com") ||
                Email.Contains("@yahoo.com") || Email.Contains("@hotmail.com") ||
                Email.Contains("@icloud.com") || string.IsNullOrEmpty(Email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAccountReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            String
                Name = ipdAccountName.Text,
                Address = ipdAccountAddress1.Text,
                town = ipdAccountAddress2.Text,
                county = ipdAccountAddress2.Text,
                Phone = ipdAccountPhone.Text,
                Email = ipdAccountEmail.Text;

            if (CheckOwner(Name, Address, Phone, Email,town,county))
            {
                MessageBox.Show("Account is already in the System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckData(Phone, Email))
            {
                MessageBox.Show("Data is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(Email))
                {
                    Email = "None supplied";
                }
                accounts.addValues(Name,Address,town,county,Phone,Email);
                MessageBox.Show("Account has been added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
