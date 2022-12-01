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
    }
}
