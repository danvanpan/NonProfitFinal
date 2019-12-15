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
    /***
     * THIS FORM IS CURRENTLY NOT IN USE
     * FURTHER CONSIDERATION REQUIRED
     */
    public partial class DeleteExpense : Form
    {
        //Initializes the form
        public DeleteExpense()
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
            }
            sql.Close();
        }

        //Clears the text from all textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(LoginForm.connID);
            SqlCommand cmd = new SqlCommand("delete from Expenses where expId = " +
                int.Parse(txtExpenseID.Text), sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            sql.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
