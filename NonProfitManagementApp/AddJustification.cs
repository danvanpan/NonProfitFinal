/**\
 * NonProfitManagementApp
 * Daniel Viera Pina
 * Email: daniel.viera@upr.edu 
 * Version: 11.7P
 * **/
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
    public partial class AddJustification : Form
    {
        //Initializes the form
        public AddJustification()
        {
            InitializeComponent();
        }
        
        //Create connection to database
        SqlConnection sql = new SqlConnection(LoginForm.connID);
       
        //Save the employee id
        string userId = LoginForm.UserID();

        //Adds a justification to an expense that has been approved or disaproved
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string query = "insert into Justifications( " +
                    "justId, " +
                    "justTitle, " +
                    "justDescript, " +
                    "expId, " +
                    "empId) " +
                    "values( " +
                    this.txtJustID.Text + ", '" +
                    this.txtJustTitle.Text + "', '" +
                    this.rtxtDescription.Text + "', " +
                    this.txtExpenseID.Text + ", " +
                    userId + ")";
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

        //Closes this form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears the text of all textboxes
        private void ClearFields()
        {
            txtJustID.Clear();
            txtJustTitle.Clear();
            txtExpenseID.Clear();
            rtxtDescription.Clear();
        }

        //Verifies that all textboxes are filled and of the correct type
        private bool IsValidData()
        {
            return Validator.IsEmpty(txtJustID) &&
                Validator.IsInt32(txtJustID) &&
                Validator.IsEmpty(txtJustTitle) &&
                Validator.IsEmpty(txtExpenseID) &&
                Validator.IsInt32(txtExpenseID);

        }
    }
}
