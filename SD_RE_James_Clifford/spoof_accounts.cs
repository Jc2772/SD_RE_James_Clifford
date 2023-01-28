﻿using System;
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
            String query = "SELECT OwnerName FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<string>(0)).ToList();
            return list;
        }
        public List<string> getAccAddress1()
        {
            String query = "SELECT Area FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<string>(0)).ToList();
            return list;
        }
        public List<string> getAccAddress2()
        {
            String query = "SELECT Town FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<string>(0)).ToList();
            return list;
        }
        public List<string> getAccAddress3()
        {
            String query = "SELECT County FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<string>(0)).ToList();
            return list;
        }
        public List<string> getAccPhone()
        {
            String query = "SELECT PhoneNo FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<string>(0)).ToList();
            return list;
        }
        public List<string> getAccEmail()
        {
            String query = "SELECT Email FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<string> list = new List<string>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<string>(0)).ToList();
            return list;
        }
        public List<int> getId()
        {
            String query = "SELECT OwnerId FROM OWNERS WHERE STATUS = 'R'";
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
            List<int> list = new List<int>();
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            list = dataset.Tables[0].AsEnumerable().Select(r => r.Field<int>(0)).ToList();
            return list;
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
            String query = "UPDATE Owners Set OwnerName = " + name + ",Area = " + address1 + ",Town = " + address2 + ",County = " + address3 + ",PhoneNo = " + phone + ",Email = " + email + ",WHERE " + id + " := OwnerId" ;
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public void removeAccounts(int id)
        {
            String query = "UPDATE Owners Set Status := 'D'"; 
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
    }
}
