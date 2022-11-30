﻿using System;
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
        frmLivestockHome Parent;
        spoof_livestock livestock;
        public frmQueryLivestock()
        {
            InitializeComponent();
        }
        public frmQueryLivestock(frmLivestockHome Parent,spoof_livestock livestock)
        {
            InitializeComponent();
            this.Parent = Parent;
            this.livestock = livestock;
        }

        private void cbxfrmQueryLivestock_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType(), breed = livestock.getLivestockBreed(), gender = livestock.getLivestockGender(), age = livestock.getLivestockAge(), tag = livestock.getLivestockTagNumber(),timeslot = livestock.getTimeslot();
            for (int i = 1; i <= type.Count; i++)
            {
                if (cbxfrmQueryLivestock.Text.Contains(i.ToString()))
                {
                    lblfrmQueryLivestock2.Text =
                        "\nlivestock type: " + type[i-1] 
                        + "\nbreed: " + breed[i-1]
                        + "\ngender: " + gender[i - 1]
                        + "\nage: " + age[i - 1]
                        + "\ntag: " + tag[i - 1]
                        + "\ntimeslot: " + timeslot[i - 1];
                }
            }
        }

        private void frmQueryLivestock_Load(object sender, EventArgs e)
        {
            List<string> type = livestock.getLivestockType();
            for (int i = 1; i <= type.Count; i++)
            {
                cbxfrmQueryLivestock.Items.Add("id-" + i + " name-" + type[i - 1]);
            }
        }
    }
}
