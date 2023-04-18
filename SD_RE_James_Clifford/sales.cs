using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SD_RE_James_Clifford
{
    public partial class sales
    {
        OracleConnection connection;
        public sales(String login)
        {
            this.connection = new OracleConnection(login);
        }

        public void setsales(double final_price,int BookingId)
        {
            connection.Open();
            String query = "INSERT INTO Sales(saleid,FinalPrice,BookingId) VALUES (" 
                + nextSaleId() + ","
                + final_price + "," 
                + BookingId + ")";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            query = "UPDATE Bookings SET BookingStatus = 'S' WHERE BookingId = " + BookingId;
            cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Double> getProfits(string year)
        {
            
            String query = "SELECT sales.FinalPrice * 0.15 From ((Bookings Inner Join Auctions on Bookings.AuctionId = Auctions.AuctionId) Inner Join Sales on Bookings.BookingId = Sales.BookingId) Where EXTRACT(YEAR FROM AuctionDate) = " + year + "AND BookingStatus = 'S'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<double> list = new List<double>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                double item = Convert.ToDouble(row[0].ToString());
                list.Add(item);
            }
            connection.Close();
            return list;
        }

        public List<DateTime> getProfitDates(string year)
        {

            String query = "SELECT AuctionDate From (Bookings Inner Join Auctions on Bookings.AuctionId = Auctions.AuctionId) Where EXTRACT(YEAR FROM AuctionDate) = " + year + "AND BookingStatus = 'S'";
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
        //conection is open in setsales()
        private int nextSaleId()
        {
            String query = "Select MAX(SaleId) from Sales";
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
