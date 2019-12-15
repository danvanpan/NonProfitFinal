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
    public partial class UpdateJustification : Form
    {
        //Initializes the form
        public UpdateJustification()
        {
            InitializeComponent();
        }

        //Searches and displays the title and description of selected justification
        //from the database
        private void btnFetch_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(LoginForm.connID);
            SqlCommand cmd = new SqlCommand("select * from Justifications where justId = " +
                int.Parse(txtJustID.Text), sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    txtExpenseID.Text = (dr["expId"].ToString());
                    txtJustTitle.Text = (dr["justTitle"].ToString());
                    rtxtDescription.Text = (dr["justDescript"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                txtExpenseID.ReadOnly = true;
                txtJustID.ReadOnly = true;
                txtJustTitle.ReadOnly = false;
                rtxtDescription.ReadOnly = false;
            }
            sql.Close();
        }

        //Updates the Title and description of selected row in the database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string query = "update Justifications SET " +
                    " justTitle=@JustTitle, " +
                    " justDescript=@JustDescription," +
                    " where justId=" + txtJustID.Text;
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);

                SqlDataReader reader;
                try
                {
                    sql.Open();
                    cmd.Parameters.AddWithValue("JustTitle", txtJustTitle.Text);
                    cmd.Parameters.AddWithValue("JustDescription", rtxtDescription.Text);
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
        private void ClearFields()
        {
            this.rtxtDescription.Clear();
            this.txtJustID.Clear();
            this.txtJustTitle.Clear();
            this.txtExpenseID.Clear();

            this.txtExpenseID.ReadOnly = true;
            this.txtJustID.ReadOnly = false;
            this.txtJustTitle.ReadOnly = true;
            this.rtxtDescription.ReadOnly = true;
        }

        //Verifies that all textboxes are filled and in correct type
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
