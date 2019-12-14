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
    public partial class ManageServices : Form
    {
        public ManageServices()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddService form = new AddService();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateServices form = new UpdateServices();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Services", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvServices.DataSource = dtbl;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageServices_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(LoginForm.connID))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Services", sqlConnect);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgvServices.DataSource = dtbl;
            }
        }
    }
}
