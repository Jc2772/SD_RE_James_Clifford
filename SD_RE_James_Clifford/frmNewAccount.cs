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
        sql sql;
        public frmNewAccount(frmLivestockHome parent, sql sql)
        {
            this.parent = parent;
            this.sql = sql;
            InitializeComponent();
        }
        public frmNewAccount()
        {
            InitializeComponent();
        }
        public Boolean checkNull(String Forename,String Surname,String Address,String Town,String County,String Phone)
        {
            if (String.IsNullOrEmpty(Forename))
            {
                return true;
            }
            else if (String.IsNullOrEmpty(Surname))
            {
                return true;
            }
            else if (String.IsNullOrEmpty(Address))
            {
                return true;
            }
            else if (String.IsNullOrEmpty(Town))
            {
                return true;
            }
            else if (String.IsNullOrEmpty(County))
            {
                return true;
            }
            else if (String.IsNullOrEmpty(Phone))
            {
                return true;
            }
            return false;
        }
        public bool CheckOwner(string phone, string email)
        {
            List<string> phonecheck = sql.GetStrValues("SELECT PhoneNo FROM OWNERS WHERE Owner_Status = 'R'");
            List<string> emailcheck = sql.GetStrValues("SELECT Email FROM OWNERS WHERE Owner_Status = 'R'");
            for (int i = 0; i < phonecheck.Count; i++) {
                if (phone.Equals(phonecheck[i]))
                {
                    return true;
                }
                else if (email.Equals(emailcheck[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckPhone(String Phone)
        {
            for (int i = 0; i < Phone.Length; i++)
            {
                String num = Phone[i].ToString();
                /* i got variable[i] from https://stackoverflow.com/questions/3581741/c-sharp-equivalent-to-javas-charat*/
                /*i got Character.IsWhitespace https://stackoverflow.com/questions/19478780/how-to-check-if-string-character-is-a-space*/
                
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
            return true;
        }
        public Boolean CheckEmail(String Email)
        {
            String[] emails = new String[] { "@gmail.com" , "@outlook.com" , "@yahoo.com", "@hotmail.com" };
            /*i got String.IsNullOrEmpty form https://www.geeksforgeeks.org/c-sharp-isnullorempty-method/#:~:text=In%20C%23%2C%20IsNullOrEmpty()%20is,is%20assigned%20%E2%80%9C%E2%80%9D%20or%20String.*/


            if (string.IsNullOrEmpty(Email))
            {
                return true;
            }
            else
            {
                for (int i = 0; i < emails.Length; i++)
                {
                    int cut = Email.Length - emails[i].Length;
                    if (Email.Substring(cut).Contains(emails[i]))
                    {
                        return true;
                    }
                }
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
            string
                forename = ipdNewAccount1.Text,
                surname = ipdNewAccount2.Text,
                Address = ipdNewAccount3.Text,
                town = ipdNewAccount4.Text,
                county = ipdNewAccount5.Text,
                Phone = ipdNewAccount6.Text,
                Email = ipdNewAccount7.Text;

            if (CheckOwner(Phone, Email))
            {
                String status = sql.GetStrValue("SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'");
                if (status.Equals("D")) {
                    DialogResult dialogResult = MessageBox.Show("Account is already in the System", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sql.NonQuery("UPDATE Owners Set Owner_Status = 'R' WHERE PhoneNo ='" + Phone + "'");
                        resetform();
                    }
                    else {
                        MessageBox.Show("User was not registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User is in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkNull(forename, surname, Address, town, county, Phone))
            {
                MessageBox.Show("Values are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckPhone(Phone))
            {
                MessageBox.Show("Phone number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckEmail(Email))
            {
                MessageBox.Show("Email is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!County(county))
            {
                MessageBox.Show("County is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(Email))
                {
                    Email = "None supplied";
                }
                try{
                    sql.NonQuery(
                        "INSERT INTO Owners(OwnerID,ForeName,Surname,Area,Town,County,PhoneNo,Email) VALUES (" +
                    sql.NextId() + ",'" +
                    forename + "','" +
                    surname + "','" +
                    Address + "','" +
                    town + "','" +
                    county + "','" +
                    Phone + "','" +
                    Email + "')"
                    );
                    MessageBox.Show("Account has been added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetform();
                }
                catch (Exception)
                {
                    MessageBox.Show("invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Boolean County(string value)
        {
            List<string> county = new List<string>() { "Antrim", "Armagh", "LondonDerry", "Derry", "Down", "Fermanagh", "Tyrone", "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Dublin", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow" };
            if (county.Contains(value)){
                return true;
            }
            else
            {
                return false;
            }
        }
        public void resetform()
        {
            ipdNewAccount1.Clear();
            ipdNewAccount2.Clear();
            ipdNewAccount3.Clear();
            ipdNewAccount4.Clear();
            ipdNewAccount5.Clear();
            ipdNewAccount6.Clear();
            ipdNewAccount7.Clear();
        }
    }
}
