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
    public partial class UpdateOrgs : Form
    {
        public UpdateOrgs()
        {
            InitializeComponent();
        }

        private void btnFetchOrg_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(LoginForm.connID);
            SqlCommand cmd = new SqlCommand("select * from Organizations where orgId = " + 
                int.Parse(txtOrgId.Text), sql);

            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    txtOrgName.Text = (dr["orgName"].ToString());
                    txtAcronym.Text = (dr["orgAcronym"].ToString());
                    txtOrgEmail.Text = (dr["orgEmailAddress"].ToString());
                    txtOrgAddress.Text = (dr["orgAddress"].ToString());
                    txtOrgNumber.Text = (dr["orgPhoneNumber"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                txtOrgId.ReadOnly = true;
                txtOrgName.ReadOnly = false;
                txtAcronym.ReadOnly = false;
                txtOrgAddress.ReadOnly = false;
                txtOrgNumber.ReadOnly = false;
                txtOrgEmail.ReadOnly = false;
            }
            sql.Close();
            
        }

        private void btnUpdateOrg_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string query = "update Organizations SET " +
                    " orgName=@OrgName, " +
                    " orgAcronym=@OrgAcronym," +
                    " orgAddress=@OrgAddress, " +
                    " orgPhoneNumber=@OrgNumber,  " +
                    " orgEmailAddress=@OrgEmail " +
                    " where orgId=" + txtOrgId.Text;
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);

                SqlDataReader reader;
                try
                {
                    sql.Open();
                    cmd.Parameters.AddWithValue("OrgName", txtOrgName.Text);
                    cmd.Parameters.AddWithValue("OrgAcronym", txtAcronym.Text);
                    cmd.Parameters.AddWithValue("OrgAddress", txtOrgAddress.Text);
                    cmd.Parameters.AddWithValue("OrgNumber", txtOrgNumber.Text);
                    cmd.Parameters.AddWithValue("OrgEmail", txtOrgEmail.Text);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Data updated into table.");
                    sql.Close();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateOrgs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to close window?",
                "Close current window", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        private bool IsValidData()
        {
            return Validator.IsEmpty(txtOrgId) &&
                Validator.IsEmpty(txtOrgName) &&
                Validator.IsEmpty(txtAcronym) &&
                Validator.IsEmpty(txtOrgAddress) &&
                Validator.IsEmpty(txtOrgEmail) &&
                Validator.IsEmpty(txtOrgNumber) &&
                Validator.IsInt32(txtOrgId) &&
                Validator.IsLong(txtOrgNumber);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            this.txtOrgId.Clear();
            this.txtOrgId.ReadOnly = false;

            this.txtOrgName.Clear();
            this.txtOrgName.ReadOnly = true;

            this.txtAcronym.Clear();
            this.txtAcronym.ReadOnly = true;

            this.txtOrgNumber.Clear();
            this.txtOrgNumber.ReadOnly = true;

            this.txtOrgAddress.Clear();
            this.txtOrgAddress.ReadOnly = true;

            this.txtOrgEmail.Clear();
            this.txtOrgEmail.ReadOnly = true;

            this.txtOrgId.Focus();
        }
    }
}
