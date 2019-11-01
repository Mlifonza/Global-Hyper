using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Global_Hyper
{
    public partial class LogOffForm : Form
    {
        UseDatabase.UseDatabase logOff = new UseDatabase.UseDatabase();
        string username;
        string password;
        public LogOffForm()
        {
            InitializeComponent();
            username = LoginForm.sUsername;
            password = LoginForm.sPassword;
        }

        private DataRow[] getRow(string filterExpression)
        {
            DataTable dt = logOff.getData().Tables[0];
            string expression = filterExpression;
            DataRow[] rowFound = dt.Select(expression);
            return rowFound;
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            logOff.ConnectToDB();
            try
            {
                string expression = "username='" + username + "' AND iPassword='" + password + "'";
                DataRow[] foundRow = getRow(expression);

                if (foundRow != null)
                {
                    double balance = Convert.ToDouble(foundRow[0]["balance"]);
                    double cashRecieved = Convert.ToDouble(foundRow[0]["cashRecieved"]);
                    double cashTransfered = Convert.ToDouble(foundRow[0]["cashTransfered"]);

                    if ((balance == 0) && (cashRecieved == 0) && (cashTransfered == 0))
                    {
                        string queryString = "UPDATE WORKER SET loggedIn='false' WHERE username='" + username + "' AND iPassword='" + password + "'";
                        bool update = logOff.ExecuteCommand(queryString);

                        this.Hide();
                        LoginForm openLogin = new LoginForm();
                        openLogin.ShowDialog();
                    }
                    else if (balance != 0)
                    {
                        MessageBox.Show("YOUR BALANCE IS NOT TRANSFERED", "TRANSFER YOUR BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cashRecieved != 0)
                    {
                        MessageBox.Show("YOUR CASH TRANSFERED TO SUPERVISOR IS NOT ACCEPTED YET", "TRANSFER YOUR BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cashTransfered != 0)
                    {
                        MessageBox.Show("YOUR CASH RECIEVED IS NOT ACCEPTED YET", "TRANSFER YOUR BALANCE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("(YOUR LOGGING OFF WAS UNSUCCESSFUL. CHECK IF HAVE CLEARED YOUR SCREEN OR YOUR BALANCE) " + se.Message);
            }
            finally
            {
                logOff.DisconnectToDB();
            }
        }

        private void LogOffForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
