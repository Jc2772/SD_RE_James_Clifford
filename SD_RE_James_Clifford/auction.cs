using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SD_RE_James_Clifford
{
    public partial class auction
    {
        OracleConnection connection;
        public auction(String login)
        {
            this.connection = new OracleConnection(login);
        }
        public void addAuction(DateTime date)
        {
            connection.Open();
            string auctionDate = date.Date.ToString("dd-MMM-yyy");
            string query = "INSERT INTO Auctions(AuctionId,AuctionDate) Values(" + nextAuctionId() + ",'" + auctionDate + "')";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void removeAuction(DateTime date)
        {
            string query = "DELETE FROM Auctions where AuctionDate = '" + date.Date.ToString("dd-MMM-yyy") + "'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM where AuctionDate = '" + date.Date.ToString("dd-MMM-yyy") + "'";
            cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<DateTime> GetDates()
        {
            string query = "SELECT AuctionDate FROM Auctions";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<DateTime> list = new List<DateTime>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(DateTime.Parse(row[0].ToString()));
            }
            connection.Close();
            return list;
        }
        // open and close is in addBookings
        public int GetAuctionId(DateTime auctiondate)
        {
            string query = "SELECT AuctionId FROM Auctions where auctiondate = '" + auctiondate.Date.ToString("dd-MMM-yyy") + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            int id = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
            return id ;
        }
        public List<DateTime> GetAuctionDates()
        {
            string query = "SELECT auctions.AuctionDate FROM (Bookings inner join Auctions on bookings.auctionid = auctions.auctionid) where bookingstatus = 'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<DateTime> list = new List<DateTime>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(DateTime.Parse(row[0].ToString()));
            }
            connection.Close();
            return list;
        }
        private int nextAuctionId()
        {
            string query = "Select MAX(AuctionId) from auctions";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
        public void addBooking(int id, double price,string timeslot,DateTime date,String TagNo)
        {
            connection.Open();
            string query = "INSERT INTO Bookings(BookingId,AuctionId,timeslot,OwnerId,StartingPrice,TagNo) Values(" + nextBookingId() + "," + GetAuctionId(date) + ",'" + timeslot  + "'," + id + "," + price +"," + TagNo  + ")";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery(); 
            connection.Close();
        }
        public List<string> getTimes()
        {
            string query = "SELECT TimeSlot FROM Bookings where BookingStatus = 'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            connection.Close();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public int getBookingId(string TagNo)
        {
            string query = "SELECT BookingId FROM Bookings where TagNo = '" + TagNo + "'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            connection.Close();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            int id = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
            return id;
        }
        //connection is open in addbookings()
        private int nextBookingId()
        {
            string query = "Select MAX(BookingId) from Bookings";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            data.Read();
            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
    }
}
