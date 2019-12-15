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
                    txtPercent.Text = (dr["servPercentage"].ToString());
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
                txtPercent.ReadOnly = false;
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
                    " servCat=@ServCat, " +
                    " servPercentage=@ServPercentage " +
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
                    cmd.Parameters.AddWithValue("ServTitle", txtServiceTitle.Text);
                    cmd.Parameters.AddWithValue("ServDescription", rtxtServiceDescription.Text);
                    cmd.Parameters.AddWithValue("ServCat", type);
                    cmd.Parameters.AddWithValue("ServPercentage", double.Parse(txtPercent.Text));
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

            this.txtPercent.Clear();
            this.txtPercent.ReadOnly = true;

            this.txtServId.Focus();
        }

        private bool IsValidData()
        {
            return Validator.IsEmpty(txtServId) &&
                Validator.IsEmpty(txtServiceTitle) &&
                Validator.IsInt32(txtServId) &&
                Validator.IsEmpty(txtPercent) &&
                Validator.IsDecimal(txtPercent) ;
        }
    }
}
