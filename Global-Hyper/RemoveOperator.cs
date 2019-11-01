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

namespace Global_Hyper
{
    public partial class RemoveOperator : Form
    {
        UseDatabase.UseDatabase delOperator = new UseDatabase.UseDatabase();
        public RemoveOperator()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != string.Empty)
            {
                try
                {
                    int emp = Int32.Parse(txtEmpID.Text);
                    delOperator.ConnectToDB();
                    string queryString = "SELECT * FROM WORKER WHERE empID = " + emp;

                    SqlDataReader reader = delOperator.ExecuteQuery(queryString);
                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();
                        DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            queryString = "EXEC deleteWorker " + emp;
                            if (delOperator.ExecuteCommand(queryString))
                            {
                                MessageBox.Show("YOU HAVE DELETED AN ITEM SUCCESSFULLY");
                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                catch (SqlException sql)
                {
                    lblResult.Text = "Oops! check your product ID value";
                }
                finally
                {
                    delOperator.DisconnectToDB();
                }
            }
            else
            {
                lblResult.Text = "Please enter a operator's identification";
            }
        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
