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
        public sales(OracleConnection connection)
        {
            this.connection = connection;
        }

        public void setsales(string name, string phone,double final_price,string tag)
        {
            String query = "INSERT INTO Sales(BuyerName,BuyerPhoneNo,FinalPrice,LivestockTag) VALUES ('"
                + name + "','" 
                + phone + "'," 
                + final_price + ",'" 
                + tag + "')";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();

            query = "UPDATE Livestock SET LivestockStatus = 'S' WHERE LivestockTag = '" + tag + "'";
            cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public List<Double> getProfits()
        {
            String query = "SELECT FinalPrice * 0.15, ";
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
            return list;
        }
    }
}
