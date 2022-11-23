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
            string starttime = ipdSetTime1.Text, finishtime = ipdSetTime2.Text;
            int start1,start2, finish1,finish2;
            try
            {
                start1 = Convert.ToInt32(starttime.Substring(0,2));
                start2 = Convert.ToInt32(starttime.Substring(3, 2));

                try
                {
                    finish1 = Convert.ToInt32(finishtime.Substring(0, 2));
                    finish2 = Convert.ToInt32(finishtime.Substring(3, 2));
                    MessageBox.Show("Time accepted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
