using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SD_RE_James_Clifford
{
    public partial class livestock
    {
        OracleConnection connection;
        public livestock(String login)
        {
            this.connection = new OracleConnection(login);
        }
        public void addValues(string livestockType,string livestockBreed,int livestockAge,string livestockGender, string livestockTagNumber,int id )
        {
            connection.Open();
            if (!tagCheck(livestockTagNumber)) {
                String query = "INSERT INTO Livestock(TagNo,ownerid,LivestockType,Breed,Age,Gender) VALUES('"
                    + livestockTagNumber
                    + "'," + id
                    + ",'" + livestockType
                    + "','" + livestockBreed
                    + "'," + livestockAge
                    + ",'" + livestockGender
                    + "')";
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                if (isSold(livestockTagNumber))
                {
                    String query = "UPDATE Livestock Set Age = " + livestockAge + ", OwnerId = " + id + "Where TagNo = '" + livestockTagNumber + "'";
                    OracleCommand cmd = new OracleCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
        
        public List<string> getLivestockType()
        {
            String query = "SELECT Livestock.LivestockType FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public List<string> getLivestockBreed()
        {
            String query = "SELECT Livestock.Breed FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public List<string> getLivestockAge()
        {
            String query = "SELECT Livestock.Age FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public List<string> getLivestockGender()
        {
            String query = "SELECT Livestock.Gender FROM (Bookings inner join Livestock on Bookings.tagNo = Livestock.TagNo) WHERE BookingStatus = 'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        
        public List<string> getLivestockTagNumber()
        {
            String query = "SELECT TagNo FROM Bookings Where BookingStatus =  'U'"; 
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public List<string> getinitialBid()
        {
            String query = "SELECT StartingPrice From Bookings Where BookingStatus =  'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public List<String> GetTimes()
        {
            String query = "SELECT TimeSlot From Bookings Where BookingStatus =  'U'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public List<string> AnalyseLiveStock(string year)
        {
            String query = "SELECT Livestock.LivestockType FROM (Bookings Inner Join Auctions on Bookings.AuctionId = Auctions.AuctionId) inner join Livestock on Bookings.TagNo = Livestock.TagNo Where EXTRACT(YEAR FROM AuctionDate) = " + year + "AND BookingStatus = 'S'";
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            connection.Close();
            return list;
        }
        public Boolean tagCheck(string tagNumber)
        {
            String query = "SELECT TagNo FROM Bookings";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> taglist = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                taglist.Add(row[0].ToString());
            }
            foreach (string tag in taglist)
            {
                if (tagNumber.Equals(tag, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean isSold(string tagNumber)
        {
            String query = "SELECT TagNo FROM Bookings Where BookingStatus = 'S'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> taglist = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                taglist.Add(row[0].ToString());
            }
            foreach (string tag in taglist)
            {
                if (tagNumber.Equals(tag, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
