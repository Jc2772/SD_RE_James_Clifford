using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_RE_James_Clifford
{
    public partial class frmDataAnalysis : Form
    {
        frmLivestockHome parent;
        public frmDataAnalysis()
        {
            InitializeComponent();
        }
        public frmDataAnalysis(frmLivestockHome parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnDataAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cbxDataAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDataAnalysis.SelectedIndex == 1)
            {
                pcbViewData.Image = Image.FromFile("data1.PNG");
            }
            if(cbxDataAnalysis.SelectedIndex == 2)
            {
                pcbViewData.Image = Image.FromFile("data2.PNG");
            }
        }

        private void frmDataAnalysis_Load(object sender, EventArgs e)
        {
            cbxDataAnalysis.Items.Add("Yearly revenue analysis");
            cbxDataAnalysis.Items.Add("Yearly livestock analysis")
        }
    }
}
