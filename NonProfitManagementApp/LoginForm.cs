using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NonProfitManagementApp
{
    public partial class LoginForm : Form
    {
        
        public const string connID = "Data Source=DESKTOP-0RB8SDD;Initial Catalog=NonProfits;Integrated Security=true";
        //employee login id
        public string currentID;

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                    MessageBox.Show("Please enter username and password");
                else
                {
                    SqlConnection sql = new SqlConnection(connID);
                    SqlCommand cmd = new SqlCommand("select * from employees where empUsername=@UserName and empPassword=@UserPassword", sql);
                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);


                    sql.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                        currentID = (dr["empId"].ToString());
                    sql.Close();

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Connected");
                        this.Hide();
                        MainForm form = new MainForm(currentID);
                        form.Show();

                    }

                    else
                        MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
