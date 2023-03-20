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
        public livestock(OracleConnection connection)
        {
            this.connection = connection;
        }
        public void addValues(string livestockType,string livestockBreed,int livestockAge,string livestockGender, string livestockTagNumber, DateTime auction_date, string auction_time,double startingPrice, int OwnerId)
        {
            if (!tagCheck(livestockTagNumber)) {
                String query = "INSERT INTO Livestock(LivestockTag,OwnerId,LivestockType,Breed,Age,Gender,Startingprice,TimeslotTime,TimeslotDate) VALUES('"
                    + livestockTagNumber
                    + "'," + OwnerId
                    + ",'" + livestockType
                    + "','" + livestockBreed
                    + "'," + livestockAge
                    + ",'" + livestockGender
                    + "'," + startingPrice
                    + ",'" + auction_time
                    + "','" + auction_date.Date.ToString("dd-MMM-yyy")
                    + "')";
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
                query = "UPDATE TimeSlots Set TimeSlotStatus = 'U' WHERE TIMESLOTDATE = '" + auction_date.Date.ToString("dd-MMM-yyy") + "' AND TIMESLOTTIME = '" + auction_time + "'";
                cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                String query = "UPDATE Livestock Set Age = " + livestockAge + ", OwnerId = " + OwnerId + "Where LivestockTag = '" + livestockTagNumber + "'";
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
                query = "UPDATE TimeSlots Set TimeSlotStatus = 'U' WHERE TIMESLOTDATE = '" + auction_date.Date.ToString("dd-MMM-yyy") + "' AND TIMESLOTTIME = '" + auction_time + "'";
                cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
        
        public List<string> getLivestockType()
        {
            String query = "SELECT LivestockType FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public List<string> getLivestockBreed()
        {
            String query = "SELECT Breed FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public List<string> getLivestockAge()
        {
            String query = "SELECT Age FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public List<string> getLivestockGender()
        {
            String query = "SELECT Gender FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        
        public List<string> getLivestockTagNumber()
        {
            String query = "SELECT LivestockTag FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public List<string> getinitialBid()
        {
            String query = "SELECT Startingprice FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public List<DateTime> GetDates()
        {
            String query = "SELECT TimeSlotDate FROM Livestock WHERE LivestockStatus = 'U'";
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
        public List<String> GetTimes()
        {
            String query = "SELECT TimeSlotTime FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public List<string> AnalyseLiveStock()
        {
            String query = "SELECT LivestockType FROM Livestock WHERE LivestockStatus = 'S'";
            OracleCommand cmd = new OracleCommand(query, connection);
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
        public Boolean tagCheck(string tagNumber)
        {
            String query = "SELECT LivestockTag FROM Livestock WHERE LivestockStatus = 'U'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> taglist = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                taglist.Add(row[0].ToString());
            }
            foreach(string tag in taglist)
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
