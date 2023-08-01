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
    public partial class frmSetTime : Form
    {
        sql sql;
        frmLivestockHome parent;
        public frmSetTime()
        {
            InitializeComponent();
        }
        public frmSetTime(frmLivestockHome parent,sql sql)
        {
            this.parent = parent;
            this.sql = sql;
            InitializeComponent();
        }

        private void btnSetTime1_Click(object sender, EventArgs e)
        {
            DateTime date = dpkSetTime.Value;
            //got this line from https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time
            DateTime today = DateTime.Today;
            if (DateTime.Compare(date,today) <= 0)
            {
                MessageBox.Show("invalid date","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                if (checkdates(date)) 
                {
                    MessageBox.Show("invalid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                { 
                    sql.NonQuery("insert into auctions(auctionid,auctiondate) values(" + sql.NextAuctionId() + ",'" + date + "')");
                    MessageBox.Show("Auction date was added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnSetTime3_Click(object sender, EventArgs e)
        {
            DateTime date = dpkSetTime.Value;
            DateTime today = DateTime.Today;
            if (DateTime.Compare(date, today) <= 0){ 
                MessageBox.Show("invalid date","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT TagNo FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where auctiondate = '" + date.Date.ToString("dd-MMM-yyy") + "'";
                List<string> tag = sql.GetStrValues(query);
                for(int i = 0; i< tag.Count; i++)
                {
                    query = "DELETE FROM Livestock where TagNo = '" + tag[i] + "'";
                    sql.NonQuery(query);
                }
                query = "SELECT BookingId FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where auctiondate = '" + date.Date.ToString("dd-MMM-yyy") + "'";
                List<int> bkgids = sql.GetIntValues(query);
                for(int i = 0; i < bkgids.Count; i++)
                {
                    query = "DELETE FROM Bookings where BookingId = '" + bkgids[i] + "'";
                    sql.NonQuery(query);
                }
                sql.NonQuery("DELETE FROM Auctions where AuctionDate = '" + date.Date.ToString("dd-MMM-yyy") + "'");
                MessageBox.Show("Auction removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSetTime2_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void dpkSetTime_ValueChanged(object sender, EventArgs e)
        {
            lblSetTime2.Text = dpkSetTime.Text;
        }
        private Boolean checkdates(DateTime date)
        {
            List<DateTime> lod = sql.GetDateValues("SELECT auctions.AuctionDate FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where bookingstatus = 'U'");
            for(int i = 0; i < lod.Count; i++)
            {
                if (DateTime.Compare(date,lod[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
