using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonProfitManagementApp
{
    public partial class MainForm : Form
    {
        //employee login id
        public string currentID;
        public MainForm(string id)
        {
            InitializeComponent();
            currentID = id;
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
            ManageOrganizations mOrgs = new ManageOrganizations(currentID);
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

        private void btnCharts_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
