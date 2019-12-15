/**\
 * NonProfitManagementApp
 * Daniel Viera Pina
 * Email: daniel.viera@upr.edu 
 * Version: 11.7P
 * **/
 using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace NonProfitManagementApp
{
    //This form Displays the 
    public partial class ManageOrganizations : Form
    {
        

        public ManageOrganizations()
        {
            InitializeComponent();
            //this.currentID = id;
        }

        //Loads the Organization table to this form's Datatable
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

        //Opens new Form for adding organizations to the table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrg form = new AddOrg();
            form.ShowDialog();
        }

        //Opens new Form to update existing organizations in the table
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOrgs form = new UpdateOrgs();
            form.ShowDialog();
        }

        //Refreshes the Datatable after any changes
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

        //Closes this current form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
