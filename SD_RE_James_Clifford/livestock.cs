using System;
using System.Collections.Generic;
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
        public void addValues(string livestockType,string livestockBreed,string livestockAge,string livestockGender, string livestockTagNumber, DateTime auction_date, string auction_time,string initial_bid,string owner)
        {
            String query = "INSERT INTO Owners(OwnerName,Area,Town,County,PhoneNo,Email) VALUES ('"
            + name + "','" +
            address1 + "','" +
            address2 + "','" +
            address3 + "','" +
            phone + "','" +
            email + "')";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        
        public List<string> getLivestockType()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        public List<string> getLivestockBreed()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        public List<string> getLivestockAge()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        public List<string> getLivestockGender()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        
        public List<string> getLivestockTagNumber()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        public List<string> getTimeslot()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        public List<string> getinitialBid()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
        public List<string> getstatus()
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0]["Status"].ToString(); ;
            return status;
        }
    }
}
