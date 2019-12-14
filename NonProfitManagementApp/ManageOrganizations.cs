using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonProfitManagementApp
{
    public partial class ManageOrganizations : Form
    {
        //employee login id
        string currentID;

        public ManageOrganizations(string id)
        {
            InitializeComponent();
            this.currentID = id;
        }

        private void ManageOrganizations_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Organizations", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvOrganizations.DataSource = dtbl;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrg form = new AddOrg(currentID);
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOrgs form = new UpdateOrgs();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Organizations", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvOrganizations.DataSource = dtbl;
                sqlConnect.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
