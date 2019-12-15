/**\
 * NonProfitManagementApp
 * Daniel Viera Pina
 * Email: daniel.viera@upr.edu 
 * Version: 11.7P
 * **/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NonProfitManagementApp
{
    public partial class UpdateExpense : Form
    {
        //Initializes the form
        public UpdateExpense()
        {
            InitializeComponent();
        }

        //Searches and displays the Title, Amount, and 
        //subcategory of an expense from the database
        private void btnFetch_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(LoginForm.connID);
            SqlCommand cmd = new SqlCommand("select * from Expenses where expId = " +
                int.Parse(txtExpenseID.Text), sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    txtExpenseID.Text = (dr["expId"].ToString());
                    txtExpenseTitle.Text = (dr["expTitle"].ToString());
                    txtExpenseAmount.Text = (dr["expAmount"].ToString());
                    txtExpenseSubcategory.Text = (dr["expSubcategory"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                txtExpenseID.ReadOnly = true;
                txtExpenseTitle.ReadOnly = false;
                txtExpenseAmount.ReadOnly = false;
                txtExpenseSubcategory.ReadOnly = false;
            }
            sql.Close();
        }

        //Updates an expense's title, amount, and subcategory on the database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string query = "update Expenses SET " +
                    " expTitle=@ExpTitle, " +
                    " expAmount=@ExpAmount," +
                    " expSubcategory=@ExpSubcategory, " +
                    " where expId=" + txtExpenseID.Text;
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);

                SqlDataReader reader;
                try
                {
                    sql.Open();
                    cmd.Parameters.AddWithValue("ExoTitle", txtExpenseTitle.Text);
                    cmd.Parameters.AddWithValue("ExpAmount", txtExpenseAmount.Text);
                    cmd.Parameters.AddWithValue("ExpSubcategory", txtExpenseSubcategory.Text);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Data updated into table.");
                    sql.Close();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Closes this form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears the text from all textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //Clears all the text from the textboxes
        private void ClearFields()
        {
            this.txtExpenseID.Clear();
            this.txtExpenseTitle.Clear();
            this.txtExpenseAmount.Clear();
            this.txtExpenseSubcategory.Clear();

            txtExpenseID.ReadOnly = false;
            txtExpenseTitle.ReadOnly = true;
            txtExpenseAmount.ReadOnly = true;
            txtExpenseSubcategory.ReadOnly = true;
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
    }
}
