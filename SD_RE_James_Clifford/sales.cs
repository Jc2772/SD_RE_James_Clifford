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

        public void setsales(double final_price,int BookingId)
        {
            String query = "INSERT INTO Sales(saleid,FinalPrice,BookingId) VALUES (" 
                + nextSaleId() + ",'"
                + final_price + "," 
                + BookingId + ")";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.ExecuteNonQuery();

            query = "UPDATE Bookings SET BookingStatus = 'S' WHERE BookingId = " + BookingId;
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
