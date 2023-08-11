using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    public partial class sql
    {
        OracleConnection connection;
        public sql(String login)
        {
            this.connection = new OracleConnection(login);
        }
        public List<string> GetStrValues(string query)
        {
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
        public List<int> GetIntValues(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            connection.Close();
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
        public List<DateTime> GetDateValues(string query)
        {
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

        public void NonQuery(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public String GetStrValue(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0].ToString();
            connection.Close();
            return status;
        }
        public int GetIntValue(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            int v = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
            int id = v;
            connection.Close();
            return id;
        }
        
        public DateTime GetDateValue(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            DateTime status = DateTime.Parse(dataset.Tables[0].Rows[0].ToString());
            connection.Close();
            return status;
        }
        public DataSet GetAllData(string query)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            connection.Close();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            connection.Close();
            return dataset;
        }
        // generate id
        public int NextId()
        {
            connection.Open();
            String query = "Select MAX(OwnerId) from Owners";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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

        public int NextAuctionId()
        {
            connection.Open();
            string query = "Select MAX(AuctionId) from auctions";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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

        public int NextBookingId()
        {
            connection.Open();
            string query = "Select MAX(BookingId) from Bookings";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
        public int NextSaleId()
        {
            connection.Open();
            String query = "Select MAX(SaleId) from Sales";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataReader data = cmd.ExecuteReader();
            connection.Close();
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
