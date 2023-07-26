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
        private int nextId()
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

        private int nextAuctionId()
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

        private int nextBookingId()
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
        private int nextSaleId()
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
