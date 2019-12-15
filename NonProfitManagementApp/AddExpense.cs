/**\
 * NonProfitManagementApp
 * Daniel Viera Pina
 * Email: daniel.viera@upr.edu 
 * Version: 11.7P
 * **/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NonProfitManagementApp
{
    //This class adds an expense id, title, and subcategory to corresponding service and organization
    public partial class AddExpense : Form
    {
        //Initializes form
        public AddExpense()
        {
            InitializeComponent();
        }

        //Save the employee id
        string userId = LoginForm.UserID();

        //Create connection to database
        SqlConnection sql = new SqlConnection(LoginForm.connID);

        //Load All services and organizations tables with their name/title
        //and ID to their respective Drop Down lists
        private void AddExpense_Load(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("Select * from Services", sql);
            SqlCommand cmd2 = new SqlCommand("Select * from Organizations", sql);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            
            adp.Fill(ds);
            adp2.Fill(ds2);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            sql.Close();
            
            cbbServiceList.DisplayMember = "servTitle";
            cbbServiceList.ValueMember = "servId";
            cbbServiceList.DataSource = ds.Tables[0];
            
            cbbOrganizationList.DisplayMember = "orgName";
            cbbOrganizationList.ValueMember = "orgId";
            cbbOrganizationList.DataSource = ds2.Tables[0];

            
        }

        //Saves all fields into a new row of the Expense Table of the database
        //and clears all textboxes when succesful
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int idserv = cbbServiceList.SelectedIndex + 1;
                int idorg = cbbOrganizationList.SelectedIndex + 1;
                string query = "insert into Expenses( " +
                    "expId, " +
                    "expTitle, " +
                    "expAmount, " +
                    "expSubcategory, " +
                    "servId, " +
                    "orgId) " +
                    "values( " +
                    this.txtExpenseID.Text + ", '" +
                    this.txtExpenseTitle.Text + "', " +
                    this.txtExpenseAmount.Text + ", '" +
                    this.txtExpenseSubcategory.Text + "', " +
                    idserv + ", " +
                    idserv + ")";
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataReader reader;
                try
                {
                    sql.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Data inserted into table.");
                    sql.Close();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Clears all textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //Closes this form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Verifies if fields are empty and if they contain the correct type of information
        private bool IsValidData()
        {
            return Validator.IsEmpty(txtExpenseID) &&
                Validator.IsEmpty(txtExpenseTitle) &&
                Validator.IsEmpty(txtExpenseAmount) &&
                Validator.IsDecimal(txtExpenseAmount) &&
                Validator.IsEmpty(txtExpenseSubcategory);
        }

        //Clears all the text from the textboxes
        private void ClearFields()
        {
            this.txtExpenseID.Clear();
            this.txtExpenseTitle.Clear();
            this.txtExpenseAmount.Clear();
            this.txtExpenseSubcategory.Clear();
        }
        

    }
}
