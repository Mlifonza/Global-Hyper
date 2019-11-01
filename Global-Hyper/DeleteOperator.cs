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

namespace Global_Hyper
{
    public partial class DeleteOperator : Form
    {
        UseDatabase.UseDatabase delOperator = new UseDatabase.UseDatabase();
        public DeleteOperator()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != string.Empty)
            {
                try
                {
                    int empID = Int32.Parse(txtEmpID.Text);
                    delOperator.ConnectToDB();
                    string queryString = "SELECT * FROM WORKER WHERE empID = " + empID;

                    SqlDataReader reader = delOperator.ExecuteQuery(queryString);
                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();
                        DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            queryString = "EXEC deleteOperatorProc " + empID;
                            if (delOperator.ExecuteCommand(queryString))
                            {
                                MessageBox.Show("YOU HAVE REMOVED AN OPERATOR SUCCESSFULLY");
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
                    lblResult.Text = "Oops! check if you've entered a valid operator number";
                }
                finally
                {
                    delOperator.DisconnectToDB();
                }
            }
            else
            {
                lblResult.Text = "Please enter a employee identification";
            }
        }
    }
}
