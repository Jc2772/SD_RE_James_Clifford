using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace SD_RE_James_Clifford
{
    public partial class auction
    {
        OracleConnection connection;
        public auction(OracleConnection connection)
        {
            this.connection = connection;
        }
        private List<string> times = new List<string> { "09:00", "09:20", "09:40", "10:00", "10:20", "10:40", "12:00", "12:20", "12:40", "13:00", "13:20", "13:40"};

        public void addAuction(DateTime auction_date)
        {
            List<DateTime> dateList = getDates();
            bool checkDate = false;
            string dateAsStr = auction_date.Date.ToString("dd-MMM-yyy");
            for (int i = 0;i < dateList.Count; i++)
            {
                if (dateAsStr.Equals(dateList[i].Date.ToString("dd-MMM-yyy")))
                {
                    checkDate = true;
                }
            }
            if (checkDate)
            {
                String query = "SELECT TimeSlot_Status FROM TimeSlots WHERE TimeSlot_Date = '" + dateAsStr + "'";
                OracleCommand cmd = new OracleCommand(query, connection);
                OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                String status = dataset.Tables[0].Rows[0].ToString();
                if (!status.Equals("A",StringComparison.OrdinalIgnoreCase)){
                    String query2 = "UPDATE TimeSlots SET TimeSlot_Status = 'A' WHERE TimeSlot_Date = '" + dateAsStr + "'";
                    OracleCommand cmd2 = new OracleCommand(query2, connection);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    return;
                }
            }
            else
            {
                for (int i = 0; i < times.Count; i++)
                {
                    String query = "INSERT INTO TIMESLOTS(TIMESLOT_date,TIMESLOT_time) VALUES ('"
                    + dateAsStr + "','"
                    + times[i] + "')";
                    OracleCommand cmd = new OracleCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<DateTime> getDates()
        {
            String query = "SELECT TIMESLOT_DATE FROM TIMESLOTS";
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
        public List<DateTime> getAuctionDate()
        {
            String query = "SELECT TIMESLOT_DATE FROM TIMESLOTS WHERE TimeSlot_Status = 'A'";
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
        public List<String> getAuctionTime()
        {
            String query = "SELECT TimeSlot_Time FROM TimeSlots WHERE TimeSlot_Status = 'A'";
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
        
        public void DeRegisterTimeSlot(DateTime date)
        {
            for (int i = 0; i < times.Count; i++)
            {
                String query = "UPDATE TimeSlots SET TimeSlot_Status = 'R' WHERE TimeSlot_Date = '" + date.Date.ToString("dd-MMM-yyy") + "'";
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
