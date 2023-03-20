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
        public auction(OracleConnection connection)
        {
            this.connection = connection;
        }
        public void addAuction(DateTime date)
        {
            String query = "INSERT INTO Auctions(AuctionId,AuctionDate) Values(" + nextAuctionId() + ",'" + date.ToString("yyy-MMM-ddd") + "')";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void removeAuction(DateTime date)
        {
            String query = "DELETE FROM where AuctionDate = '" + date.ToString("yyy-MMM-ddd") + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            query = "DELETE FROM where AuctionDate = '" + date.ToString("yyy-MMM-ddd") + "'";
            cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public List<DateTime> GetDates()
        {
            String query = "SELECT AuctionDate FROM Auction";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<DateTime> list = new List<DateTime>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(DateTime.Parse(row[0].ToString()));
            }
            return list;
        }
        public List<int> GetAuctionId(DateTime auctiondate)
        {
            String query = "SELECT AuctionId FROM Auction where auctiondate = " + auctiondate.ToString("yyy-MM-ddd") ;
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<int> list = new List<int>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(Convert.ToInt32(row[0]));
            }
            return list;
        }

        private int nextAuctionId()
        {
            String query = "Select MAX(AuctionId) from auctions";

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataReader data = cmd.ExecuteReader();

            if (data.IsDBNull(0))
            {
                return 1;
            }
            else
            {
                return data.GetInt32(0) + 1;
            }
        }
        public void addBooking(int id, double price,string timeslot,DateTime date)
        {
            String query = "INSERT INTO Bookings(BookingId,AuctionId,timeslot,OwnerId,StartingPrice) Values(" + nextBookingId() + "," + GetAuctionId(date) + ",'" + timeslot  + "'," + id + "," + price + ")";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        private int nextBookingId()
        {
            String query = "Select MAX(BookingId) from Bookings";

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataReader data = cmd.ExecuteReader();

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
