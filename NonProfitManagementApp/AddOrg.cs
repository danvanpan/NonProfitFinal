﻿using System;
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
    public partial class AddOrg : Form
    {
        //employee login id
        string currentID;

        public AddOrg(string id)
        {
            InitializeComponent();
            this.currentID = id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string query = "insert into Organizations(" +
                    " orgId, " +
                    " orgName, " +
                    " orgAcronym," +
                    " orgAddress, " +
                    " orgPhoneNumber,  " +
                    " orgEmailAddress, " +
                    " empId)" +
                    " values('" +
                    this.txtOrgId.Text + "','" +
                    this.txtOrgName.Text + "','" +
                    this.txtAcronym.Text + "','" +
                    this.txtOrgAddress.Text + "','" +
                    this.txtOrgNumber.Text + "','" +
                    this.txtOrgEmail.Text + "','" +
                    currentID.ToString() + "')";
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataReader reader;
                try
                {
                    sql.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Data inserted into table.");
                    sql.Close();
                    this.txtOrgName.Clear();
                    this.txtOrgId.Clear();
                    this.txtAcronym.Clear();
                    this.txtOrgNumber.Clear();
                    this.txtOrgAddress.Clear();
                    this.txtOrgEmail.Clear();
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

        private void AddOrg_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
