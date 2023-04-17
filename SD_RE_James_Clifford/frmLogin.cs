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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String oradb = "Data Source = oracle/orcl; User Id = " + tbxLogin1.Text + "; Password = " + tbxlogin2.Text + ";";
            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                conn.Close();
                this.Hide();
                frmLivestockHome MainMenu = new frmLivestockHome(oradb);
                MainMenu.Show();
            }
            catch(Oracle.ManagedDataAccess.Client.OracleException)
            {
                MessageBox.Show("Invalid Login", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
