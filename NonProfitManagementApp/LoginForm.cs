/**\
 * NonProfitManagementApp
 * Daniel Viera Pina
 * Email: daniel.viera@upr.edu 
 * Version: 11.7P
 * **/
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NonProfitManagementApp
{
    public partial class LoginForm : Form
    {
        //Database Access public for any form to call and use
        public const string connID = "Data Source=DESKTOP-0RB8SDD;Initial Catalog=NonProfits;Integrated Security=true";
        
        //employee login id
        private static string currentID = "";

        //Initializes the Form and gives the Password property to the password textbox
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        
        //Saves the Employee id number on a method other forms can call and access
        public static string UserID()
        {
            return currentID;
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
                        MainForm form = new MainForm();
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
