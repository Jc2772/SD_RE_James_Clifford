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
    public partial class frmQueryLivestock : Form
    {
        frmLivestockHome parent;
        sql sql;
        public frmQueryLivestock()
        {
            InitializeComponent();
        }
        public frmQueryLivestock(frmLivestockHome Parent,sql sql)
        {
            InitializeComponent();
            this.parent = Parent;
            this.sql = sql;
        }

        private void cbxQueryLivestock_SelectedIndexChanged(object sender, EventArgs e)
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
            lblQueryLivestock2.Text = "";
            for (int i = 0; i < type.Count; i++)
            {
                if (cbxQueryLivestock.SelectedIndex == i)
                {
                    lblQueryLivestock2.Text +=
                        "Livestock"
                        +"\nlivestock type: " + type[i]
                        + "\nbreed: " + breed[i]
                        + "\ngender: " + gender[i]
                        + "\nage: " + age[i]
                        + "\ntag: " + tag[i]
                        + "\ntimeslot: " + time[i] + " " + dates[i].ToString("dd-MMM-yyy")
                        + "\ninitial bid: " + initial_bid[i];
                }
            }
        }

        private void frmQueryLivestock_Load(object sender, EventArgs e)
        {
            List<string> breed = sql.GetStrValues("SELECT Livestock.Breed FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'");
            List<string> bid = sql.GetStrValues("SELECT StartingPrice From Bookings Where BookingStatus =  'U'");
            for (int i = 0; i < breed.Count; i++)
            {
                cbxQueryLivestock.Items.Add(breed[i] + "-" + bid[i]);
            }
        }

        private void btnfrmQueryLivestock3_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
