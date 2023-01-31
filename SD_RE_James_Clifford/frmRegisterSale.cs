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
            for (int i = 1; i <= type.Count; i++)
            {
                cbxRegisterSale1.Items.Add("id-" + i + " name-" + type[i - 1]);
                if (livestock.getstatus()[i - 1].Equals("s"))
                {
                    cbxRegisterSale1.Items.Remove("id-" + i + " name-" + type[i - 1]);
                }
            }
        }

        private void cbxRegisterSale1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(), timeslot = livestock.getTimeslot(), initial_bid = livestock.getinitialBid();
            lblRegisterSale2.Text = "Livestock";
            for (int i = 1; i <= type.Count; i++)
            {
                if (cbxRegisterSale1.Text.Contains(i.ToString()))
                {
                    lblRegisterSale2.Text +=
                        "\nlivestock type: " + type[i - 1]
                        + "\nbreed: " + breed[i - 1]
                        + "\ngender: " + gender[i - 1]
                        + "\nage: " + age[i - 1]
                        + "\ntag: " + tag[i - 1]
                        + "\ntimeslot: " + timeslot[i - 1]
                        + "\ninitial bid: " + initial_bid[i - 1];
                    this.tag = tag[i - 1];
                }
            }
        }

        private void btnRegisterSale2_Click(object sender, EventArgs e)
        {
            if (val.CheckPhone(ipdRegisterSale2.Text))
            {
                try
                {
                    Double.Parse(ipdRegisterSale3.Text);
                    sales.setsales(ipdRegisterSale1.Text, ipdRegisterSale2.Text, ipdRegisterSale3.Text,this.tag);

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
