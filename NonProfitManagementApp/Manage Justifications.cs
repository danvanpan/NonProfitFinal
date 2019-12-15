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
    public partial class Manage_Justifications : Form
    {
        public Manage_Justifications()
        {
            InitializeComponent();
        }

        private void btnJustification_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateJustification_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Justifications", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvExpenses.DataSource = dtbl;
            }
        }

        private void Manage_Justifications_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Justifications", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvExpenses.DataSource = dtbl;
            }
        }
    }
}
