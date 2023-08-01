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
    public partial class frmRegisterLivestock : Form
    {
        frmLivestockHome parent;
        sql sql;
        List<string> times = new List<string> { "09:00", "09:20", "09:40", "10:00", "10:20", "10:40", "12:00", "12:20", "12:40", "13:00", "13:20", "13:40" };
        List<DateTime> dates;
        List<int> id;
        public frmRegisterLivestock()
        {
            InitializeComponent();
        }
        public frmRegisterLivestock(frmLivestockHome parent,sql sql)
        {
            this.sql = sql;
            this.dates = sql.GetDateValues("SELECT AuctionDate FROM Auctions");
            this.parent = parent;
            InitializeComponent();
        }
        private void ckxRegisterLivestock1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxRegisterLivestock1.Checked)
            {
                ckxRegisterLivestock2.Checked = false;
            }
        }

        private void ckxRegisterLivestock2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxRegisterLivestock2.Checked)
            {
                ckxRegisterLivestock1.Checked = false;
            }
        }

        private void btnRegisterLivestock_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRegisterLivestock_Load(object sender, EventArgs e)
        {
            cbxRegisterLivestock1.Items.Add("cattle");
            cbxRegisterLivestock1.Items.Add("sheep");
            cbxRegisterLivestock1.Items.Add("goat");
        }

        private void cbxRegisterLivestock1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetcbx();
            if (cbxRegisterLivestock1.Text.Equals("cattle"))
            {
                cbxRegisterLivestock2.Items.Add("Limousin");
                cbxRegisterLivestock2.Items.Add("Charolais");
                cbxRegisterLivestock2.Items.Add("Aberdeen Angus");
                cbxRegisterLivestock2.Items.Add("Charolais");
                cbxRegisterLivestock2.Items.Add("Hereford");
                cbxRegisterLivestock2.Items.Add("Simmental");
                cbxRegisterLivestock2.Items.Add("Belgian Blue");
                cbxRegisterLivestock2.Items.Add("Jersey");
                cbxRegisterLivestock2.Items.Add("Salers");
                cbxRegisterLivestock2.Items.Add("Shorthorn");
                grpRegisterLivestock.Visible = true;
            }
            else if (cbxRegisterLivestock1.Text.Equals("sheep"))
            {
                cbxRegisterLivestock2.Items.Add("Suffolk sheep");
                cbxRegisterLivestock2.Items.Add("Texel sheep");
                cbxRegisterLivestock2.Items.Add("Charollais sheep");
                cbxRegisterLivestock2.Items.Add("Scottish Blackface");
                cbxRegisterLivestock2.Items.Add("Vendéen");
                cbxRegisterLivestock2.Items.Add("Lleyn sheep");
                cbxRegisterLivestock2.Items.Add("Blue Texel sheep");
                grpRegisterLivestock.Visible = true;
            }
            else if (cbxRegisterLivestock1.Text.Equals("goat"))
            {
                cbxRegisterLivestock2.Items.Add("Saanen");
                cbxRegisterLivestock2.Items.Add("British Alpine");
                cbxRegisterLivestock2.Items.Add("Toggenburg");
                cbxRegisterLivestock2.Items.Add("Anglo-Nubian");
                grpRegisterLivestock.Visible = true;
            }
            id = sql.GetIntValues("SELECT OwnerId FROM OWNERS WHERE Owner_Status = 'R'");

            List<string> 
            name = sql.GetStrValues("SELECT ForeName FROM OWNERS WHERE Owner_Status = 'R'"),
            surname = sql.GetStrValues("SELECT SurName FROM OWNERS WHERE Owner_Status = 'R'");
            for (int i = 0; i < id.Count; i++)
            {
                cbxRegisterLivestock4.Items.Add(name[i] + " " + surname[i]);
            }
            sortTimeslots();
        }
        private void sortTimeslots()
        {
            for(int i = 0; i < dates.Count; i++)
            {
                for (int j = 0; j < times.Count; j++)
                {
                    cbxRegisterLivestock3.Items.Add(times[j] + " - " + dates[i].Date.ToString("dd-MMM-yyy"));
                }
            }
            verifytime();
        }

        private void btnRegisterLivestock2_Click(object sender, EventArgs e)
        {
            string livestockType = cbxRegisterLivestock1.Text, livestockBreed = cbxRegisterLivestock2.Text, livestockTagNumber = ipdRegisterLivestock2.Text, livestockGender;
            try
            {
                int age = Convert.ToInt32(ipdRegisterLivestock1.Text);
                Double bid = Convert.ToDouble(ipdRegisterLivestock3.Text);
                if (checkMoney(ipdRegisterLivestock3.Text)) {
                    if (ipdRegisterLivestock2.Text.Length == 15)
                    {
                        if (ckxRegisterLivestock1.Checked) {
                            livestockGender = "M";
                        }
                        else
                        {
                            livestockGender = "F";
                        }
                        if (cbxRegisterLivestock3.SelectedIndex > -1 && cbxRegisterLivestock2.SelectedIndex > -1 && cbxRegisterLivestock4.SelectedIndex > -1) {
                            if (age > 0 && bid > 0) {
                                string query = "INSERT INTO Livestock(TagNo,ownerid,LivestockType,Breed,Age,Gender) VALUES('"
                                    + livestockTagNumber
                                    + "'," + id[cbxRegisterLivestock4.SelectedIndex]
                                    + ",'" + livestockType
                                    + "','" + livestockBreed
                                    + "'," + age
                                    + ",'" + livestockGender
                                    + "')"; ;
                                sql.NonQuery(query);
                                string idquery = "SELECT AuctionId FROM Auctions where auctiondate = '" + GetDate() + "'";
                                query = "INSERT INTO Bookings(BookingId, AuctionId, timeslot, OwnerId, StartingPrice, TagNo) Values(" 
                                    + sql.NextBookingId() 
                                    + ", " + sql.GetIntValue(idquery) 
                                    + ", '" + GetTime() + "', " 
                                    + id + ", " 
                                    + bid + ", " 
                                    + livestockTagNumber 
                                    + ")";
                                sql.NonQuery(query);
                                MessageBox.Show("Livestock has been added", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                updateform();
                            }
                            else
                            {
                                MessageBox.Show("invalid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("combo box not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid tag number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    MessageBox.Show("invald money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void verifytime()
        {
            List<string> time = sql.GetStrValues("SELECT TimeSlot FROM Bookings where BookingStatus = 'U'");
            DateTime today = DateTime.Today;
            List<DateTime> rmdate = new List<DateTime>();
            for (int i = 0; i < dates.Count; i++)
            {
               
                if (DateTime.Compare(dates[i], today) <= 0)
                {
                    for (int j = 0; j < times.Count; j++)
                    {
                        cbxRegisterLivestock3.Items.Remove(times[j] + " - " + dates[i].Date.ToString("dd-MMM-yyy"));
                        rmdate.Add(dates[i]);
                    }
                }
                else
                {
                   for(int j = 0; j < time.Count; j++)
                    {
                        string timeslot = time[j] + " - " + dates[i].Date.ToString("dd-MMM-yyy");
                        cbxRegisterLivestock3.Items.Remove(timeslot);
                    }
                }
            }
            for(int i = 0; i < rmdate.Count; i++)
            {
                dates.Remove(rmdate[i]);
            }
        }
        public DateTime GetDate()
        {
            foreach(DateTime date in dates)
            {
                if (cbxRegisterLivestock3.Items[cbxRegisterLivestock3.SelectedIndex].ToString().Contains(date.ToString())){
                    return date;
                }
            }
            return dates[0];
        }

        public string GetTime()
        {
            foreach (string time in times)
            {
                if (cbxRegisterLivestock3.Items[cbxRegisterLivestock3.SelectedIndex].ToString().Contains(time))
                {
                    return time;
                }
            }
            return times[0];
        }
        public void updateform()
        {
            ipdRegisterLivestock1.Clear();
            ipdRegisterLivestock2.Clear();
            ipdRegisterLivestock3.Clear();
            ckxRegisterLivestock1.Checked = false;
            ckxRegisterLivestock2.Checked = false;
            cbxRegisterLivestock1.SelectedIndex = -1;
            cbxRegisterLivestock2.SelectedIndex = -1;
            cbxRegisterLivestock3.SelectedIndex = -1;
            cbxRegisterLivestock4.SelectedIndex = -1;
            verifytime();
            resetcbx();
            grpRegisterLivestock.Visible = false;
        }
        public Boolean checkMoney(String bid)
        {
            if(bid.Length > 5)
            {
                if(bid[5] == '.')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public void resetcbx() {
            cbxRegisterLivestock2.Items.Clear();
            cbxRegisterLivestock3.Items.Clear();
            cbxRegisterLivestock4.Items.Clear();
            cbxRegisterLivestock2.Text = "";
            cbxRegisterLivestock3.Text = "";
            cbxRegisterLivestock4.Text = "";
        }
    }
}
