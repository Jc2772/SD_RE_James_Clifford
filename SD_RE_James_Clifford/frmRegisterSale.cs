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
        sales sales;
        livestock livestock;
        auction auction;
        frmNewAccount val = new frmNewAccount();
        private int BookingId;
        public frmRegisterSale(frmLivestockHome parent, sales sales,livestock livestock,auction auction)
        {
            InitializeComponent();
            this.parent = parent;
            this.sales = sales;
            this.livestock = livestock;
            this.auction = auction;
        }

        public frmRegisterSale()
        {
            InitializeComponent();
        }

        private void frmRegisterSale_Load(object sender, EventArgs e)
        {
            List<string> Breed = livestock.getLivestockBreed();
            List<string> initial_bid = livestock.getinitialBid();
            
            for (int i = 0; i < Breed.Count; i++)
            {
                cbxRegisterSale1.Items.Add(Breed[i] + "-" + initial_bid[i]);
            }
        }

        private void cbxRegisterSale1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(), timeslot = livestock.GetTimes(), initial_bid = livestock.getinitialBid();
            List<DateTime> dates = auction.GetAuctionDates();
            lblRegisterSale2.Text = "";
            int i = cbxRegisterSale1.SelectedIndex;
            lblRegisterSale2.Text += "Livestock"
            + "\nlivestock type: " + type[i]
            + "\nbreed: " + breed[i]
            + "\ngender: " + gender[i]
            + "\nage: " + age[i]
            + "\ntag: " + tag[i]
            + "\ntimeslot: " + timeslot[i] + " " + dates[i]
            + "\ninitial bid: " + initial_bid[i];
            BookingId = auction.getBookingId(tag[i]);
        }

        private void btnRegisterSale2_Click(object sender, EventArgs e)
        {
            try
            {
                Double price = Double.Parse(ipdRegisterSale1.Text);
                sales.setsales(price, BookingId);
                MessageBox.Show("Livestock Has Been Sold", "Sold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateForm();
            }
            catch (FormatException)
            {
                MessageBox.Show("invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           

        private void btnRegisterSale1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        public void UpdateForm()
        {
            lblRegisterSale2.Text = "";
            cbxRegisterSale1.Items.Clear();
            cbxRegisterSale1.SelectedIndex = -1;
            cbxRegisterSale1.Text = "";
            ipdRegisterSale1.Clear();
            List<string> Breed = livestock.getLivestockBreed();
            List<string> initial_bid = livestock.getinitialBid();

            for (int i = 0; i < Breed.Count; i++)
            {
                cbxRegisterSale1.Items.Add(Breed[i] + "-" + initial_bid[i]);
            }
        }
    }
}
