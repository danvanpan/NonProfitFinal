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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                string type;
                if (radMedular.Checked)
                    type = "Medular";
                else
                    type = "Support";
                string query = "insert into Services(" +
                    "servId, " +
                    "servTitle, " +
                    "servDescription, " +
                    "servCat, " +
                    "servPercentage)" +
                    "Values(" +
                    this.txtServId.Text + ", '" +
                    this.txtServiceTitle.Text + "', '" +
                    this.rtxtServiceDescription.Text + "', '" +
                    type +"', " + 
                    this.txtServPercent.Text + ")";
                SqlConnection sql = new SqlConnection(LoginForm.connID);
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataReader reader;
                try
                {
                    sql.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Data inserted into table.");
                    sql.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to close window?",
                "Close current window", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        private bool IsValidData()
        {
            return Validator.IsEmpty(txtServId) &&
                Validator.IsEmpty(txtServiceTitle) &&
                Validator.IsInt32(txtServId) &&
                Validator.IsEmpty(txtServPercent) &&
                Validator.IsDecimal(txtServPercent);
        }
        

        private void AddService_Load(object sender, EventArgs e)
        {
            this.rtxtServiceDescription.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            this.txtServId.Clear();
            
            this.txtServiceTitle.Clear();
            
            this.rtxtServiceDescription.Clear();
            
            this.radMedular.Checked = true;

            this.txtServPercent.Clear();

            this.txtServId.Focus();

        }
    }
}
