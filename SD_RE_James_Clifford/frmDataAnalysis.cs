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

        private void cbxDataAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDataAnalysis.SelectedIndex == 0)
            {
                crtDataAnalysis.Series[0].Points.Clear();
                crtDataAnalysis.Visible = false;
                cbxDataAnalysis2.Visible = true;
            }
            if (cbxDataAnalysis.SelectedIndex == 1)
            {
                crtDataAnalysis.Series[0].Points.Clear();
                crtDataAnalysis.Visible = true;
                cbxDataAnalysis2.Visible = false;
                List<String> Type = livestock.AnalyseLiveStock();
                String[] types = new String[] { "cattle", "sheep", "goat" };
                Series series = crtDataAnalysis.Series[0];
                series.ChartType = SeriesChartType.Pie;
                for(int i = 0; i< 3; i++)
                {
                    int count = 0;
                    foreach(String item in Type)
                    {
                        if (item.Equals(types[i])){
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        series.Points.AddXY(types[i], count);
                    }
                }
            }
        }

        private void frmDataAnalysis_Load(object sender, EventArgs e)
        {
            loadYears();

            cbxDataAnalysis.Items.Add("Yearly revenue analysis");
            cbxDataAnalysis.Items.Add("Yearly livestock analysis");
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
            crtDataAnalysis.Visible = true;
            Series series = crtDataAnalysis.Series[0];
            series.ChartType = SeriesChartType.Bar;
            List<Double> money = sale.getProfits(cbxDataAnalysis2.SelectedItem.ToString());
            List<DateTime> dates = sale.getProfitDates(cbxDataAnalysis2.SelectedItem.ToString());
            String[] types = new String[] { "Jan", "Feb", "Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
            Double[] MonthlyProfits = new Double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < types.Length; i++)
            {
                double count = 0;
                for(int j = 0; j < dates.Count;j++)
                {
                    if (dates[j].ToString("MMM").Equals(types[i]))
                    {
                        MonthlyProfits[i] += money[j];
                    }
                }
            }
            crtDataAnalysis.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            crtDataAnalysis.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            series.Points.DataBindXY(types, MonthlyProfits);
        }
    }
}
