using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SD_RE_James_Clifford
{
    public partial class auction
    {
        OracleConnection connection;
        public auction(OracleConnection connection)
        {
            this.connection = connection;
        }
        private List<string> times = new List<string> { "09:00", "09:20", "09:40", "10:00", "10:20", "10:40", "12:00", "12:20", "12:40", "13:00", "13:20", "13:40"};
        
        public void addAuction(DateTime auction_date)
        {
            for (int i = 0; i < times.Count; i++) {
                String query = "INSERT INTO Auctions() VALUES ('"
                + auction_date + "','" 
                + times[i]+ "')";
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
        /*public void removeAuction(String auctionDate,livestock livestock)
        {
            for (int i = timeslots.Count- 1 ; i >= 0; i--)
            {
                if (timeslots[i].Contains(auctionDate))
                {
                    timeslots.RemoveAt(i);
                }
            }
            auction_date.Remove(auctionDate);
            livestock.CancelLivestock(auctionDate);
        }
    }*/
}
