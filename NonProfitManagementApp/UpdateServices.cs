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
    public partial class UpdateServices : Form
    {
        public UpdateServices()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(LoginForm.connID);
            SqlCommand cmd = new SqlCommand("select * from Services where servId = " +
                int.Parse(txtServId.Text), sql);

            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    txtServiceTitle.Text = (dr["servTitle"].ToString());
                    rtxtServiceDescription.Text = (dr["servDescription"].ToString());
                    string type = (dr["servCat"].ToString());
                    if (type == "Medular")
                        radMedular.Checked = true;
                    else
                        radSupport.Checked = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                txtServId.ReadOnly = true;
                txtServiceTitle.ReadOnly = false;
                rtxtServiceDescription.ReadOnly = false;
                radMedular.Visible = true;
                radSupport.Visible = true;
            }
            sql.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string query = "update Services SET " +
                    " servTitle=@ServTitle, " +
                    " servDescription=@ServDescription," +
                    " servCat=@ServCat " +
                    " where servId=" + txtServId.Text;
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);

                SqlDataReader reader;
                try
                {
                    string type;
                    if (radMedular.Checked)
                        type = "Medular";
                    else
                        type = "Support";
                    sql.Open();
                    cmd.Parameters.AddWithValue("servTitle", txtServiceTitle.Text);
                    cmd.Parameters.AddWithValue("servDescription", rtxtServiceDescription.Text);
                    cmd.Parameters.AddWithValue("servCat", type);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            this.txtServId.Clear();
            this.txtServId.ReadOnly = false;

            this.txtServiceTitle.Clear();
            this.txtServiceTitle.ReadOnly = true;

            this.rtxtServiceDescription.Clear();
            this.rtxtServiceDescription.ReadOnly = true;

            this.radMedular.Checked = true;

            this.txtServId.Focus();
        }

        private bool IsValidData()
        {
            return Validator.IsEmpty(txtServId) &&
                Validator.IsEmpty(txtServiceTitle) &&
                Validator.IsInt32(txtServId);
        }
    }
}
