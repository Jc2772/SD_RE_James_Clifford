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
        livestock livestock;
        accounts accounts;
        auction auction;
        List<string> times;
        List<DateTime> dates;
        List<int> id;
        public frmRegisterLivestock()
        {
            InitializeComponent();
        }
        public frmRegisterLivestock(frmLivestockHome parent,livestock livestock,auction auction,accounts accounts)
        {
            this.parent = parent;
            this.livestock = livestock;
            this.auction = auction;
            this.accounts = accounts;
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

        private void btnRegisterLivestock_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRegisterLivestock_Load(object sender, EventArgs e)
        {
            cbxRegisterLivestock1.Items.Add("cattle");
            cbxRegisterLivestock1.Items.Add("sheep");
            cbxRegisterLivestock1.Items.Add("goat");
            id = accounts.getId();
            for (int i = 0; i < id.Count; i++)
            {
                cbxRegisterLivestock4.Items.Add(accounts.getAccName()[i]);
            }
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
            cbxRegisterLivestock2.Items.Add("Saanen");
            cbxRegisterLivestock2.Items.Remove("British Alpine");
            cbxRegisterLivestock2.Items.Remove("Toggenburg");
            cbxRegisterLivestock2.Items.Remove("Anglo-Nubian");
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
            dates = auction.GetDates(); 
            for(int i = 0; i < dates.Count; i++)
            {
                cbxRegisterLivestock3.Items.Add(times[i]+ " - "+ dates[i].Date.ToString("dd-MMM-yyy"));
            }
        }

        private void btnRegisterLivestock2_Click(object sender, EventArgs e)
        {
            string livestockType = cbxRegisterLivestock1.Text, livestockBreed = cbxRegisterLivestock2.Text, livestockTagNumber = ipdRegisterLivestock2.Text, livestockGender;
            try
            { 
                int age = Convert.ToInt32(ipdRegisterLivestock1.Text);
                Double bid = Convert.ToDouble(ipdRegisterLivestock3.Text);
                if(ipdRegisterLivestock2.Text.Length == 15)
                   {
                       if(ckxRegisterLivestock1.Checked) {
                            livestockGender = "M";
                       }
                       else
                       {
                            livestockGender = "F";
                       }
                       if (cbxRegisterLivestock3.SelectedIndex > -1) {
                            livestock.addValues(livestockType, livestockBreed, age, livestockGender, livestockTagNumber,id[cbxRegisterLivestock4.SelectedIndex]);
                        auction.addBooking(id[cbxRegisterLivestock4.SelectedIndex], bid,times[cbxRegisterLivestock3.SelectedIndex]);  
                            MessageBox.Show("Livestock has been added", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       else
                       {
                            MessageBox.Show("invalid owner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                    }
                else
                {
                    MessageBox.Show("invalid tag number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
