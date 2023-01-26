using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SD_RE_James_Clifford
{
    public partial class spoof_accounts
    {
        OracleConnection connection;
        public spoof_accounts(OracleConnection connection)
        {
            this.connection = connection;
        }
        
        public List<string> getAccName()
        {
            String query = "SELECT OwnerName FROM OWNERS";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> AccName = new List<string>();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AccName = dataTable.AsEnumerable().Select(r => r.Field<string>("OwnerName")).ToList();
            return AccName;
        }
        public List<string> getAccAddress1()
        {
            String query = "SELECT Area FROM OWNERS";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> AccName = new List<string>();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AccName = dataTable.AsEnumerable().Select(r => r.Field<string>("Area")).ToList();
            return AccName;
        }
        public List<string> getAccAddress2()
        {
            String query = "SELECT Town FROM OWNERS";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> AccName = new List<string>();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AccName = dataTable.AsEnumerable().Select(r => r.Field<string>("Town")).ToList();
            return AccName;
        }
        public List<string> getAccAddress3()
        {
            String query = "SELECT County FROM OWNERS";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> AccName = new List<string>();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AccName = dataTable.AsEnumerable().Select(r => r.Field<string>("County")).ToList();
            return AccName;
        }
        public List<string> getAccPhone()
        {
            String query = "SELECT PhoneNo FROM OWNERS";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> AccName = new List<string>();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AccName = dataTable.AsEnumerable().Select(r => r.Field<string>("PhoneNo")).ToList();
            return AccName;
        }
        public List<string> getAccEmail()
        {
            String query = "SELECT Email FROM OWNERS";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> AccName = new List<string>();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AccName = dataTable.AsEnumerable().Select(r => r.Field<string>("Email")).ToList();
            return AccName;
        }
        public void addValues(string name,string address1, string address2, string address3, string phone,string email)
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
        public void updateValues(string name, string address1, string address2, string address3, string phone, string email,int id)
        {
        }
        public void removeAccounts(int id)
        {
        }
    }
}
