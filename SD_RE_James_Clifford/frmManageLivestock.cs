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
    public partial class frmManageLivestock : Form
    {
        frmLivestockHome parent;
        sales sales;
        livestock livestock;
        auction auction;
        private int BookingId;
        private string tagno;
        public frmManageLivestock(frmLivestockHome parent, sales sales,livestock livestock,auction auction)
        {
            InitializeComponent();
            this.parent = parent;
            this.sales = sales;
            this.livestock = livestock;
            this.auction = auction;
        }

        public frmManageLivestock()
        {
            InitializeComponent();
        }

        private void frmManageLivestock_Load(object sender, EventArgs e)
        {
            List<string> Breed = livestock.getLivestockBreed();
            List<string> initial_bid = livestock.getinitialBid();
            
            for (int i = 0; i < Breed.Count; i++)
            {
                cbxManageLivestock1.Items.Add(Breed[i] + "-" + initial_bid[i]);
            }
        }

        private void cbxManageLivestock1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(), timeslot = livestock.GetTimes(), initial_bid = livestock.getinitialBid();
            List<DateTime> dates = auction.GetAuctionDates();
            lblManageLivestock2.Text = "";
            int i = cbxManageLivestock1.SelectedIndex;
            lblManageLivestock2.Text += "Livestock"
            + "\nlivestock type: " + type[i]
            + "\nbreed: " + breed[i]
            + "\ngender: " + gender[i]
            + "\nage: " + age[i]
            + "\ntag: " + tag[i]
            + "\ntimeslot: " + timeslot[i] + " " + dates[i]
            + "\ninitial bid: " + initial_bid[i];
            BookingId = auction.getBookingId(tag[i]);
            tagno = tag[i];
        }

        private void btnManageLivestock2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxManageLivestock1.SelectedIndex > -1) {
                    Double price = Double.Parse(ipdManageLivestock1.Text);
                    if (new frmRegisterLivestock().checkMoney(ipdManageLivestock1.Text)) {
                        sales.setsales(price, BookingId);
                        MessageBox.Show("Livestock Has Been Sold", "Sold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateForm();
                    }
                    else
                    {
                        MessageBox.Show("invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("invalid livestock selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           

        private void btnManageLivestock1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        public void UpdateForm()
        {
            lblManageLivestock2.Text = "";
            cbxManageLivestock1.Items.Clear();
            cbxManageLivestock1.SelectedIndex = -1;
            cbxManageLivestock1.Text = "";
            ipdManageLivestock1.Clear();
            List<string> Breed = livestock.getLivestockBreed();
            List<string> initial_bid = livestock.getinitialBid();

            for (int i = 0; i < Breed.Count; i++)
            {
                cbxManageLivestock1.Items.Add(Breed[i] + "-" + initial_bid[i]);
            }
        }

        private void btnManagelivestock3_Click(object sender, EventArgs e)
        {
            if (cbxManageLivestock1.SelectedIndex > -1)
            {
                livestock.removebooking(tagno,BookingId);
            }
            else
            {
                MessageBox.Show("invalid livestock selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
