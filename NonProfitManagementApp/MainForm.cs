/**\
 * NonProfitManagementApp
 * Daniel Viera Pina
 * Email: daniel.viera@upr.edu 
 * Version: 11.7P
 * **/
using System;
using System.Windows.Forms;

namespace NonProfitManagementApp
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOrgs_Click(object sender, EventArgs e)
        {
            ManageOrganizations mOrgs = new ManageOrganizations();
            mOrgs.ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ManageServices mServices = new ManageServices();
            mServices.ShowDialog();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ManageExpenses form = new ManageExpenses();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViews_Click(object sender, EventArgs e)
        {
            ManageViews form = new ManageViews();
            form.ShowDialog();
        }
        
    }
}
