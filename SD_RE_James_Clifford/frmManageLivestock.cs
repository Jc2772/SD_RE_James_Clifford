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
    public partial class frmManageLivestock : Form
    {
        frmLivestockHome parent;
        sql sql;
        private int BookingId;
        private string tagno;
        public frmManageLivestock(sql sql,frmLivestockHome parent)
        {
            InitializeComponent();
            this.sql = sql;
            this.parent = parent;
        }

        public frmManageLivestock()
        {
            InitializeComponent();
        }

        private void frmManageLivestock_Load(object sender, EventArgs e)
        {
            List<string> Breed = sql.GetStrValues("SELECT Livestock.Breed FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'");
            List<string> initial_bid = sql.GetStrValues("SELECT StartingPrice From Bookings Where BookingStatus =  'U'");
            
            for (int i = 0; i < Breed.Count; i++)
            {
                cbxManageLivestock1.Items.Add(Breed[i] + "-" + initial_bid[i]);
            }
        }

        private void cbxManageLivestock1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string>
                type = sql.GetStrValues("SELECT Livestock.LivestockType FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'"),
                breed = sql.GetStrValues("SELECT Livestock.Breed FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'"),
                gender = sql.GetStrValues("SELECT Livestock.Gender FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'"),
                age = sql.GetStrValues("SELECT Livestock.Age FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'"),
                tag = sql.GetStrValues("SELECT TagNo FROM Bookings Where BookingStatus =  'U'"),
                time = sql.GetStrValues("SELECT TimeSlot From Bookings Where BookingStatus =  'U'"),
                initial_bid = sql.GetStrValues("SELECT StartingPrice From Bookings Where BookingStatus =  'U'");
            List<DateTime> dates = sql.GetDateValues("SELECT auctions.AuctionDate FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where bookingstatus = 'U'");
            lblManageLivestock2.Text = "";
            int i = cbxManageLivestock1.SelectedIndex;
            lblManageLivestock2.Text += "Livestock"
            + "\nlivestock type: " + type[i]
            + "\nbreed: " + breed[i]
            + "\ngender: " + gender[i]
            + "\nage: " + age[i]
            + "\ntag: " + tag[i]
            + "\ntimeslot: " + time[i] + " " + dates[i].ToString("dd-MMM-yyy")
            + "\ninitial bid: " + initial_bid[i];
            string query = "SELECT BookingId FROM Bookings where TagNo = '" + tag[i] + "'";
            BookingId = sql.GetIntValue(query);
            tagno = tag[i];
        }

        private void btnManageLivestock2_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                if (cbxManageLivestock1.SelectedIndex > -1) {
                    Double price = Double.Parse(ipdManageLivestock1.Text);
                    if (new frmRegisterLivestock().checkMoney(ipdManageLivestock1.Text)) {
                        query = "SELECT auctions.AuctionDate FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where BookingId = " + BookingId;
                        DateTime date = sql.GetDateValue(query);
                        DateTime today = DateTime.Today;
                        if (DateTime.Compare(date, today) < 0)
                        {
                            query = "INSERT INTO Sales(saleid,FinalPrice,BookingId) VALUES ("
                            + sql.NextSaleId() + ","
                            + price + ","
                            + BookingId + ")";
                            sql.NonQuery(query);
                            MessageBox.Show("Livestock Has Been Sold", "Sold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateForm();
                        }
                        else
                        {
                            MessageBox.Show("invalid livestock selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("invalid livestock selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           

        private void btnManageLivestock1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        public void UpdateForm()
        {
            lblManageLivestock2.Text = "";
            cbxManageLivestock1.Items.Clear();
            cbxManageLivestock1.SelectedIndex = -1;
            cbxManageLivestock1.Text = "";
            ipdManageLivestock1.Clear();
            List<string> Breed = sql.GetStrValues("SELECT Livestock.Breed FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'");
            List<string> initial_bid = sql.GetStrValues("SELECT StartingPrice From Bookings Where BookingStatus =  'U'");

            for (int i = 0; i < Breed.Count; i++)
            {
                cbxManageLivestock1.Items.Add(Breed[i] + "-" + initial_bid[i]);
            }
        }

        private void btnManagelivestock3_Click(object sender, EventArgs e)
        {
            string query;
            if (cbxManageLivestock1.SelectedIndex > -1)
            {
                query = "SELECT auctions.AuctionDate FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where BookingId = " + BookingId;
                DateTime date = sql.GetDateValue(query);
                DateTime today = DateTime.Today;
                if (DateTime.Compare(date, today) > 0)
                { 
                    query = "DELETE FROM Bookings where BookingId = " + BookingId;
                    sql.NonQuery(query);
                    MessageBox.Show("Booking Has Been Removed", "Booking removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("invalid livestock selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("invalid livestock selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
