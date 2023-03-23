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
    public partial class accounts
    {
        OracleConnection connection;
        public accounts(OracleConnection connection)
        {
            this.connection = connection;
        }
        
        public List<string> getAccName()
        {
            String query = "SELECT OwnerName FROM OWNERS WHERE Owner_Status = 'R'";
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
        public List<string> getAccAddress1()
        {
            String query = "SELECT Area FROM OWNERS WHERE Owner_Status = 'R'";
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
        public List<string> getAccAddress2()
        {
            String query = "SELECT Town FROM OWNERS WHERE Owner_Status = 'R'";
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
        public List<string> getAccAddress3()
        {
            String query = "SELECT County FROM OWNERS WHERE Owner_Status = 'R'";
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
        public List<string> getAccPhone()
        {
            String query = "SELECT PhoneNo FROM OWNERS WHERE Owner_Status = 'R'";
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
        public List<string> getAccEmail()
        {
            String query = "SELECT Email FROM OWNERS WHERE Owner_Status = 'R'";
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
        public List<int> getId()
        {
            String query = "SELECT OwnerId FROM OWNERS WHERE Owner_Status = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<int> list = new List<int>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            foreach(DataRow row in dataset.Tables[0].Rows)
            {
                list.Add(Convert.ToInt32(row[0]));
            }
            return list;
        }
        public void addValues(string name,string address1, string address2, string address3, string phone,string email)
        {
                String query = "INSERT INTO Owners(OwnerID,OwnerName,Area,Town,County,PhoneNo,Email) VALUES (" + 
                nextId() + ",'" +
                name + "','" +
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
            String query = "UPDATE Owners Set OwnerName = '" + name 
                + "',Area = '" + address1 
                + "',Town = '" + address2 
                + "',County = '" + address3 
                + "',PhoneNo = '" + phone 
                + "',Email = '" + email 
                + "'WHERE " + id + " = OwnerId";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void removeAccounts(int id)
        {
            String query = "UPDATE Owners SET Owner_Status = 'D' WHERE OwnerId = " + id; 
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void reinstateAccount(String Phone)
        {
            String query = "UPDATE Owners Set Owner_Status = 'R' WHERE PhoneNo ='" + Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public string getUserStatus(String Phone)
        {
            String query = "SELECT Owner_Status FROM OWNERS WHERE PhoneNo = '" +  Phone + "'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            String status = dataset.Tables[0].Rows[0].ToString(); ;
            return status;
        }
        public DataSet GetData(int id)
        {
            String query = "SELECT * FROM OWNERS WHERE OwnerId = " + id;
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            return dataset;
        }
        private int nextId()
        {
            String query = "Select MAX(OwnerId) from Owners";

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
