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
    public partial class frmQueryLivestock : Form
    {
        frmLivestockHome parent;
        livestock livestock;
        public frmQueryLivestock()
        {
            InitializeComponent();
        }
        public frmQueryLivestock(frmLivestockHome Parent,livestock livestock)
        {
            InitializeComponent();
            this.parent = Parent;
            this.livestock = livestock;
        }

        private void cbxQueryLivestock_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(),timeslot = livestock.getTimeslot(), initial_bid = livestock.getinitialBid();
            lblQueryLivestock2.Text = "Livestock";
            for (int i = 1; i <= type.Count; i++)
            {
                if (cbxQueryLivestock.Text.Contains(i.ToString()))
                {
                    lblQueryLivestock2.Text +=
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
                cbxQueryLivestock.Items.Add("id-" + i + " name-" + type[i - 1]);
                if (livestock.getstatus()[i - 1].Equals("s"))
                {
                    cbxQueryLivestock.Items.Remove("id-" + i + " name-" + type[i - 1]);
                }
            }
        }

        private void btnfrmQueryLivestock3_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
