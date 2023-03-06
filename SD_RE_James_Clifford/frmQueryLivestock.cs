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
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(),time = livestock.GetTimes(), initial_bid = livestock.getinitialBid();
            List<DateTime> dates = livestock.GetDates();
            lblQueryLivestock2.Text = "Livestock";
            for (int i = 0; i < type.Count; i++)
            {
                if (cbxQueryLivestock.SelectedIndex == i)
                {
                    lblQueryLivestock2.Text +=
                        "\nlivestock type: " + type[i]
                        + "\nbreed: " + breed[i]
                        + "\ngender: " + gender[i]
                        + "\nage: " + age[i]
                        + "\ntag: " + tag[i]
                        + "\ntimeslot: " + time[i] + " " + dates[i].ToString("dd-MMM-yyy")
                        + "\ninitial bid: " + initial_bid[i];
                }
            }
        }

        private void frmQueryLivestock_Load(object sender, EventArgs e)
        {
            List<string> breed = livestock.getLivestockBreed();
            List<string> bid = livestock.getinitialBid();
            for (int i = 0; i < breed.Count; i++)
            {
                cbxQueryLivestock.Items.Add(breed[i] + "-" + bid[i]);
            }
        }

        private void btnfrmQueryLivestock3_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
