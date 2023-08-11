using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SD_RE_James_Clifford
{
    public partial class frmDataAnalysis : Form
    {
        frmLivestockHome parent;
        sql sql;
        livestock livestock;
        public frmDataAnalysis()
        {
            InitializeComponent();
        }
        public frmDataAnalysis(frmLivestockHome parent, sql sql)
        {
            InitializeComponent();
            this.parent = parent;
            this.sql = sql;
        }

        private void btnDataAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmDataAnalysis_Load(object sender, EventArgs e)
        {
            loadYears();
        }

        public void loadYears()
        {
            int year = DateTime.Today.Year;

            for (int i = 0; i < 4; i++)
            {
                cbxDataAnalysis2.Items.Add(year.ToString());
                year--;
            }
        }

        private void cbxDataAnalysis2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setchart1();
            setchart2();
        }
        public void setchart1()
        {
            crtDataAnalysis1.Series[0].Points.Clear();
            crtDataAnalysis1.Titles.Clear();
            crtDataAnalysis1.Visible = true;
            crtDataAnalysis1.Titles.Add("Yearly Revenue");
            Series series1 = crtDataAnalysis1.Series[0];
            series1.ChartType = SeriesChartType.Bar;
            string query;
            query = "SELECT sales.FinalPrice * 0.15 From ((Bookings Inner Join Auctions on Bookings.AuctionId = Auctions.AuctionId) Inner Join Sales on Bookings.BookingId = Sales.BookingId) Where EXTRACT(YEAR FROM AuctionDate) = " + cbxDataAnalysis2.SelectedItem.ToString() + "AND BookingStatus = 'S'";
            List<Double> money = sql.GetDoubleValues(query);
            query = "SELECT AuctionDate From (Bookings Inner Join Auctions on Bookings.AuctionId = Auctions.AuctionId) Where EXTRACT(YEAR FROM AuctionDate) = " + cbxDataAnalysis2.SelectedItem.ToString() + "AND BookingStatus = 'S'";
            List<DateTime> dates = sql.GetDateValues(query);
            String[] date = new String[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Double[] MonthlyProfits = new Double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < date.Length; i++)
            {
                for (int j = 0; j < dates.Count; j++)
                {
                    if (dates[j].ToString("MMM").Equals(date[i]))
                    {
                        MonthlyProfits[i] += money[j];
                    }
                }
            }
            crtDataAnalysis1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            crtDataAnalysis1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            for (int i = 0; i < date.Length; i++)
            {
                series1.Points.DataBindXY(date, MonthlyProfits);
                series1.LegendText = "Monthly Revenue";
            }
        }
        public void setchart2()
        {
            crtDataAnalysis2.Series[0].Points.Clear();
            crtDataAnalysis2.Titles.Clear();
            crtDataAnalysis2.Visible = true;
            crtDataAnalysis2.Titles.Add("Livestock Analysis");
            string query = "SELECT Livestock.LivestockType FROM (Bookings Inner Join Auctions on Bookings.AuctionId = Auctions.AuctionId) inner join Livestock on Bookings.TagNo = Livestock.TagNo Where EXTRACT(YEAR FROM AuctionDate) = " + cbxDataAnalysis2.SelectedItem.ToString() + "AND BookingStatus = 'S'";
            List<String> Type = sql.GetStrValues(query);
            String[] types = new String[] { "cattle", "sheep", "goat" };
            Series series2 = crtDataAnalysis2.Series[0];
            series2.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < 3; i++)
            {
                int count = 0;
                foreach (String item in Type)
                {
                    if (item.Equals(types[i]))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    series2.Points.AddXY(types[i], count);
                }
            }
        }
    }
}
