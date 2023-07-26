using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SD_RE_James_Clifford
{
    public partial class frmLivestockHome : Form
    {
        sql sql;
        public frmLivestockHome()
        {
            InitializeComponent();
        }
        public frmLivestockHome(String connection)
        {
            InitializeComponent();
            this.sql = new sql(connection);
        }
        /*The code in these methods are from https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form */

        private void btnLivestockHome7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewAccount enter = new frmNewAccount(this, sql);
            enter.Show();
        }

        private void updatederegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageAccount enter = new frmManageAccount(this, sql);
            enter.Show();
        }

        private void registerLivestockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterLivestock enter = new frmRegisterLivestock(this, sql);
            enter.Show();
        }

        private void ManageLivestockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageLivestock enter = new frmManageLivestock(this, sql);
            enter.Show();
        }

        private void queryLivestockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryLivestock enter = new frmQueryLivestock(this, sql);
            enter.Show();
        }

        private void scheduleAuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetTime enter = new frmSetTime(this, sql);
            enter.Show();
        }

        private void dataAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDataAnalysis enter = new frmDataAnalysis(this, sql);
            enter.Show();
        }

        private void frmLivestockHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
