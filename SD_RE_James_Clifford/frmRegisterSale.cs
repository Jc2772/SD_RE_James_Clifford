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
        spoof_livestock livestock;
        public frmRegisterSale(frmLivestockHome parent, spoof_sales sales,spoof_livestock livestock)
        {
            InitializeComponent();
            this.parent = parent;
            this.sales = sales;
            this.livestock = livestock;
        }

        public frmRegisterSale()
        {
            InitializeComponent();
        }
        private void cbxfrmQueryLivestock_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(), timeslot = livestock.getTimeslot(), initial_bid = livestock.getinitialBid();
            for (int i = 1; i <= type.Count; i++)
            {
                if (cbx.Text.Contains(i.ToString()))
                {
                    lblfrmQueryLivestock2.Text +=
                        "\nlivestock type: " + type[i - 1]
                        + "\nbreed: " + breed[i - 1]
                        + "\ngender: " + gender[i - 1]
                        + "\nage: " + age[i - 1]
                        + "\ntag: " + tag[i - 1]
                        + "\ntimeslot: " + timeslot[i - 1]
                        + "\ninitial bid: " + initial_bid[i - 1];
                }
            }
        }

        private void frmQueryLivestock_Load(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType();
            for (int i = 1; i <= type.Count; i++)
            {
                cbxfrmQueryLivestock.Items.Add("id-" + i + " name-" + type[i - 1]);
                if (livestock.getstatus()[i - 1].Equals("s"))
                {
                    cbxfrmQueryLivestock.Items.Remove("id-" + i + " name-" + type[i - 1]);
                }
            }
        }
    }
}
