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
    public partial class frmSetTime : Form
    {
        frmLivestockHome parent;
        public frmSetTime()
        {
            InitializeComponent();
        }
        public frmSetTime(frmLivestockHome parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnSetTime1_Click(object sender, EventArgs e)
        {
            string starttime = ipdSetTime1.Text, finishtime = ipdSetTime2.Text,slots = ipdSetTime3.Text;
            try
            {
                Convert.ToInt32(starttime.Substring(0,2));
                try
                {
                    Convert.ToInt32(finishtime.Substring(0, 2));
                    try
                    {
                        Convert.ToInt32(slots);
                        MessageBox.Show("Time accepted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("slots is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("finish time is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Start time is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
