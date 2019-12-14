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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        SqlConnection sql = new SqlConnection(LoginForm.connID);

        private void AddExpense_Load(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("Select * from Services", sql);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            cmd.ExecuteNonQuery();
            sql.Close();

            cbbServiceList.DataSource = ds.Tables[0];
            cbbServiceList.DisplayMember = "servTitle";
            cbbServiceList.ValueMember = "servId";
        }
    }
}
