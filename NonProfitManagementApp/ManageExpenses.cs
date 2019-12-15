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
    public partial class ManageExpenses : Form
    {
        //Initializes the form
        public ManageExpenses()
        {
            InitializeComponent();
        }

        //Closes this form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Opens the Add Expense form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExpense form = new AddExpense();
            form.ShowDialog();
        }

        //Opens the Update Expense form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateExpense form = new UpdateExpense();
            form.ShowDialog();
        }

        //Not going to use it for now. Its dangerous to 
        //give deleting power in relational databases
        /*private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteExpense form = new DeleteExpense();
            form.ShowDialog();
        }*/

        //Reloads the Expenses table from the database into the datagridview
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Expenses", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvExpenses.DataSource = dtbl;
            }
        }

        //Loads the Expenses table from the database into the datagridView
        private void ManageExpenses_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Expenses", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvExpenses.DataSource = dtbl;
            }
        }
    }
}
