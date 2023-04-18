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
        sales sale;
        livestock livestock;
        public frmDataAnalysis()
        {
            InitializeComponent();
        }
        public frmDataAnalysis(frmLivestockHome parent, sales sale, livestock livestock)
        {
            InitializeComponent();
            this.parent = parent;
            this.livestock = livestock;
            this.sale = sale;
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
            List<Double> money = sale.getProfits(cbxDataAnalysis2.SelectedItem.ToString());
            List<DateTime> dates = sale.getProfitDates(cbxDataAnalysis2.SelectedItem.ToString());
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
            List<String> Type = livestock.AnalyseLiveStock(cbxDataAnalysis2.SelectedItem.ToString());
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
