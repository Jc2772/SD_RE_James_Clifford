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
        sql sql;
        public frmManageAccount()
        {
            InitializeComponent();
        }
        public frmManageAccount(frmLivestockHome parent,sql sql)
        {
            this.parent = parent;
            this.sql = sql;
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
            List<string> name = sql.GetStrValues("SELECT ForeName FROM OWNERS WHERE Owner_Status = 'R'"),
            surname = sql.GetStrValues("SELECT SurName FROM OWNERS WHERE Owner_Status = 'R'");
            List<int> id = sql.GetIntValues("SELECT OwnerId FROM OWNERS WHERE Owner_Status = 'R'");
            for (int i = 0; i < name.Count; i++)
            {
                cbxManageAccount.Items.Add(name[i]+ " " + surname[i] + "-" + id[i]);
            }
        }

        private void cbxManageAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> 
                name = sql.GetStrValues("SELECT ForeName FROM OWNERS WHERE Owner_Status = 'R'"),
                surname = sql.GetStrValues("SELECT SurName FROM OWNERS WHERE Owner_Status = 'R'"),
                Address1 = sql.GetStrValues("SELECT Area FROM OWNERS WHERE Owner_Status = 'R'"), 
                Address2 = sql.GetStrValues("SELECT Town FROM OWNERS WHERE Owner_Status = 'R'"),
                Address3 = sql.GetStrValues("SELECT County FROM OWNERS WHERE Owner_Status = 'R'"),
                Phone = sql.GetStrValues("SELECT PhoneNo FROM OWNERS WHERE Owner_Status = 'R'"),
                Email = sql.GetStrValues("SELECT Email FROM OWNERS WHERE Owner_Status = 'R'");
            List<int> id = sql.GetIntValues("SELECT OwnerId FROM OWNERS WHERE Owner_Status = 'R'");
            lblManageAccounts2.Text = "Account Display";
            int i = cbxManageAccount.SelectedIndex;
            this.id = id[i];
            lblManageAccounts2.Text +=
            "\nname: " + name[i] + " " +surname
            +"\nid: " + id[i]
            + "\nAddress1: " + Address1[i]
            + "\nAddress2: " + Address2[i]
            + "\nAddress3: " + Address3[i]
            + "\nPhone: " + Phone[i]
            + "\nEmail: " + Email[i];
        }

        private void btnManageAccounts3_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnManageAccount2_Click(object sender, EventArgs e)
        {
            if (cbxManageAccount.SelectedIndex > -1) {
                sql.NonQuery("UPDATE Owners SET Owner_Status = 'D' WHERE OwnerId = " + id);
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
            DataSet dataset = sql.GetAllData("SELECT * FROM OWNERS WHERE OwnerId = " + id);
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
            sql.NonQuery(
                "UPDATE Owners Set ForeName = '" + ForeName
                + "',Surname = '" + Surname
                + "',Area = '" + Address1
                + "',Town = '" + Address2
                + "',County = '" + Address3
                + "',PhoneNo = '" + Phone
                + "',Email = '" + Email
                + "'WHERE " + id + " = OwnerId");
            UpdateForm();
        }
        public void UpdateForm()
        {
            lblManageAccounts2.Text = "";
            cbxManageAccount.Items.Clear();
            List<string> name = sql.GetStrValues("SELECT ForeName FROM OWNERS WHERE Owner_Status = 'R'"),
            surname = sql.GetStrValues("SELECT SurName FROM OWNERS WHERE Owner_Status = 'R'");
            List<int> id = sql.GetIntValues("SELECT OwnerId FROM OWNERS WHERE Owner_Status = 'R'");
            cbxManageAccount.SelectedIndex = -1;
            cbxManageAccount.Text = "";
            for (int i = 0; i < name.Count; i++)
            {
                cbxManageAccount.Items.Add(name[i] + " " + surname[i] + "-" + id[i]);
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
