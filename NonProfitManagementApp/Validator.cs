using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonProfitManagementApp
{
    class Validator
    {
        public const string Title = "Entry Error";

        public static bool IsEmpty(TextBox txtBox)
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show(txtBox.Tag + " is a required field.",
                    Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox txtBox)
        {
            decimal number = 0.0M;
            if (!decimal.TryParse(txtBox.Text, out number))
            {
                MessageBox.Show(txtBox.Tag + " must be a decimal value.",
                    Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox txtBox)
        {
            int number = 0;
            if (!int.TryParse(txtBox.Text, out number))
            {
                MessageBox.Show(txtBox.Tag + " must be a integer value.",
                    Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsWithinRange(TextBox txtBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(txtBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(txtBox.Tag + " must be between " + min + " and " + max + ".",
                    Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsLong(TextBox textBox)
        {
            long number = 0;
            if (!long.TryParse(textBox.Text, out number))
            {
                MessageBox.Show(textBox.Tag + " must be a integer value.",
                    Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool isUnique(TextBox textBox, int pk, string db, string id)
        {
            /*SqlConnection sql = new SqlConnection(LoginForm.connID);
            SqlCommand cmd = new SqlCommand("select * from" + db + "where" + id + "=" + pk.ToString());
            */
            return true;
        }
    }
}
