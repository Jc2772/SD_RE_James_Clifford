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
    public partial class frmRegisterLivestock : Form
    {
        frmLivestockHome parent;
        public frmRegisterLivestock()
        {
            InitializeComponent();
        }
        public frmRegisterLivestock(frmLivestockHome parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void ckxRegisterLivestock1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxRegisterLivestock1.Checked)
            {
                ckxRegisterLivestock2.Checked = false;
            }
        }

        private void ckxRegisterLivestock2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxRegisterLivestock2.Checked)
            {
                ckxRegisterLivestock1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRegisterLivestock_Load(object sender, EventArgs e)
        {
            cbxRegisterLivestock1.Items.Add("cattle");
            cbxRegisterLivestock1.Items.Add("sheep");
            cbxRegisterLivestock1.Items.Add("goat");
        }

        private void cbxRegisterLivestock1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRegisterLivestock2.Items.Remove("Limousin");
            cbxRegisterLivestock2.Items.Remove("Charolais");
            cbxRegisterLivestock2.Items.Remove("Aberdeen Angus");
            cbxRegisterLivestock2.Items.Remove("Charolais");
            cbxRegisterLivestock2.Items.Remove("Hereford");
            cbxRegisterLivestock2.Items.Remove("Simmental");
            cbxRegisterLivestock2.Items.Remove("Belgian Blue");
            cbxRegisterLivestock2.Items.Remove("Jersey");
            cbxRegisterLivestock2.Items.Remove("Salers");
            cbxRegisterLivestock2.Items.Remove("Shorthorn");
            cbxRegisterLivestock2.Items.Remove("Suffolk sheep");
            cbxRegisterLivestock2.Items.Remove("Texel sheep");
            cbxRegisterLivestock2.Items.Remove("Charollais sheep");
            cbxRegisterLivestock2.Items.Remove("Scottish Blackface");
            cbxRegisterLivestock2.Items.Remove("Vendéen");
            cbxRegisterLivestock2.Items.Remove("Lleyn sheep");
            cbxRegisterLivestock2.Items.Remove("Blue Texel sheep");
            if (cbxRegisterLivestock1.Text.Equals("cattle"))
            {
                cbxRegisterLivestock2.Items.Add("Limousin");
                cbxRegisterLivestock2.Items.Add("Charolais");
                cbxRegisterLivestock2.Items.Add("Aberdeen Angus");
                cbxRegisterLivestock2.Items.Add("Charolais");
                cbxRegisterLivestock2.Items.Add("Hereford");
                cbxRegisterLivestock2.Items.Add("Simmental");
                cbxRegisterLivestock2.Items.Add("Belgian Blue");
                cbxRegisterLivestock2.Items.Add("Jersey");
                cbxRegisterLivestock2.Items.Add("Salers");
                cbxRegisterLivestock2.Items.Add("Shorthorn");
                grpRegisterLivestock.Visible = true;
            }
            else if (cbxRegisterLivestock1.Text.Equals("sheep"))
            {
                cbxRegisterLivestock2.Items.Add("Suffolk sheep");
                cbxRegisterLivestock2.Items.Add("Texel sheep");
                cbxRegisterLivestock2.Items.Add("Charollais sheep");
                cbxRegisterLivestock2.Items.Add("Scottish Blackface");
                cbxRegisterLivestock2.Items.Add("Vendéen");
                cbxRegisterLivestock2.Items.Add("Lleyn sheep");
                cbxRegisterLivestock2.Items.Add("Blue Texel sheep");
                grpRegisterLivestock.Visible = true;
            }
            else if (cbxRegisterLivestock1.Text.Equals("goat"))
            {
                cbxRegisterLivestock2.Items.Add("Saanen");
                cbxRegisterLivestock2.Items.Add("British Alpine");
                cbxRegisterLivestock2.Items.Add("Toggenburg");
                cbxRegisterLivestock2.Items.Add("Anglo-Nubian");
                grpRegisterLivestock.Visible = true;
            }
            sortTimeslots();
        }
        private void sortTimeslots()
        {
            spoof_auction auction = new spoof_auction();
            spoof_livestock livestock = new spoof_livestock();
            if (auction.getSize() == livestock.getSize()) {
                cbxRegisterLivestock3.Items.Add("Booked out");
            }
            else
            {
                for (int i = 0; i < auction.getSize(); i++)
                {
                    cbxRegisterLivestock3.Items.Add(auction.getTimeslot(i));
                    for(int j = 0; j < livestock.getSize(); j++)
                    {
                        if (auction.getTimeslot(i).Equals(livestock.getTimeslot(j)))
                        {
                            cbxRegisterLivestock3.Items.Remove(auction.getTimeslot(i));
                        }
                    }
                }
            }
        }

        private void btnRegisterLivestock2_Click(object sender, EventArgs e)
        {
            string livestockType = cbxRegisterLivestock1.Text, livestockBreed = cbxRegisterLivestock2.Text, livestockAge = ipdRegisterLivestock1.Text, livestockTagNumber = ipdRegisterLivestock2.Text,livestockGender, timeslot = cbxRegisterLivestock3.Text;
            try
            {
                Convert.ToInt32(ipdRegisterLivestock1.Text);
                try
                {
                    Convert.ToInt32(ipdRegisterLivestock2.Text);
                    if(ipdRegisterLivestock2.Text.Length == 15)
                    {
                        if(ckxRegisterLivestock1.Checked) {
                            livestockGender = "male";
                        }
                        else
                        {
                            livestockGender = "female";
                        }
                        new spoof_livestock().addValues(livestockType, livestockBreed, livestockAge, livestockGender, livestockTagNumber,timeslot);
                        MessageBox.Show("tag number is invalid", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("tag number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Age is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
