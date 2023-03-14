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
        frmNewAccount val = new frmNewAccount();
        private string tag;
        public frmRegisterSale(frmLivestockHome parent, sales sales,livestock livestock)
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

        private void frmRegisterSale_Load(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType();
            List<string> initial_bid = livestock.getinitialBid();
            
            for (int i = 0; i < type.Count; i++)
            {
                cbxRegisterSale1.Items.Add(type[i] + "-" + initial_bid[i]);
            }
        }

        private void cbxRegisterSale1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(), timeslot = livestock.GetTimes(), initial_bid = livestock.getinitialBid();
            List<DateTime> dates = livestock.GetDates();
            lblRegisterSale2.Text = "Livestock";
            for (int i = 0; i < type.Count; i++)
            {
                if (cbxRegisterSale1.SelectedIndex == i)
                {
                    lblRegisterSale2.Text +=
                        "\nlivestock type: " + type[i]
                        + "\nbreed: " + breed[i]
                        + "\ngender: " + gender[i]
                        + "\nage: " + age[i]
                        + "\ntag: " + tag[i]
                        + "\ntimeslot: " + timeslot[i] + " " + livestock.GetDates()
                        + "\ninitial bid: " + initial_bid[i];
                    this.tag = tag[i];
                }
            }
        }

        private void btnRegisterSale2_Click(object sender, EventArgs e)
        {
            if (val.CheckPhone(ipdRegisterSale2.Text))
            {
                try
                {
                    Double price = Double.Parse(ipdRegisterSale3.Text);
                    sales.setsales(ipdRegisterSale1.Text, ipdRegisterSale2.Text, price,this.tag);

                }
                catch (FormatException)
                {
                    MessageBox.Show("invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("invalid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterSale1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
