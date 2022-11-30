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
    public partial class frmRegisterSale : Form
    {
        frmLivestockHome parent;
        spoof_sales sales;
        public frmRegisterSale(frmLivestockHome parent, spoof_sales sales)
        {
            InitializeComponent();
            this.parent = parent;
            this.sales = sales;
        }

        public frmRegisterSale()
        {
            InitializeComponent();
        }
    }
}
