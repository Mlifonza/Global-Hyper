using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Services;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Global_Hyper
{
    public partial class HomeForm : Form
    {
        UseDatabase.UseDatabase functions;
        DigitalPad numPad = new DigitalPad();
        string queryString;
        string expression;
        string username;
        string password;
        DataTable dt;
        double num;
        DataRow userRow;

        DateTime date;

        public HomeForm()
        {
            InitializeComponent();

            username = LoginForm.sUsername;
            password = LoginForm.sPassword;
            dt = (DataTable) LoginForm.sDataTable;
            userRow = (DataRow) LoginForm.dsReader;
        }

        private DataRow[] getRow(string filterExpression)
        {
            DataTable dt = functions.getData().Tables[0];
            string expression = filterExpression;
            DataRow[] rowFound = dt.Select(expression);
            return rowFound;
        }

        private void btnStandby_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btnCashFromSuper_Click(object sender, EventArgs e)
        {
            numPad.ShowDialog();
            try
            {
                functions = new UseDatabase.UseDatabase();
                functions.ConnectToDB();

                num = DigitalPad.numEntered;
                queryString = "SELECT * FROM WORKER WHERE username='" + username + "' AND iPassword='" + password + "' AND cashRecieved=" + num;
                SqlDataReader reader = functions.ExecuteQuery(queryString);

                if (reader != null && reader.HasRows)
                {
                    reader.Close();
                    queryString = "EXEC cashFromSupervisor " + num + ", '" + username + "', '" + password + "'";
                    bool result = functions.ExecuteCommand(queryString);

                    if (result)
                    {
                        MessageBox.Show("YOUR TRANSACTION HAS BEEN ACCEPTED SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("SOMETHING WENT WRONG WHEN PERFORMING TRANSACTION");
                    }
                    
                    numPad.Hide();

                }
                else
                {
                    MessageBox.Show("CHECK IF YOU HAVE ENTERED THE CORRECT AMOUNT!");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                functions.DisconnectToDB();
            }
        }

        private void btnCashToSupervisor_Click(object sender, EventArgs e)
        {
            numPad.ShowDialog();
            try
            {
                functions = new UseDatabase.UseDatabase();
                functions.ConnectToDB();

                num = DigitalPad.numEntered;
                queryString = "SELECT * FROM WORKER WHERE username='" + username + "' AND iPassword='" + password + "' AND balance>=" + num;
                SqlDataReader reader = functions.ExecuteQuery(queryString);

                if (reader != null && reader.HasRows)
                {
                    reader.Close();
                    queryString = "EXEC cashToSupervisor " + num + ", '" + username + "', '" + password + "'";
                    bool result = functions.ExecuteCommand(queryString);

                    if (result)
                    {
                        MessageBox.Show("YOUR TRANSACTION HAS BEEN ACCEPTED SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("SOMETHING WENT WRONG WHEN PERFORMING TRANSACTION");
                    }

                    numPad.Hide();

                }
                else
                {
                    MessageBox.Show("CHECK IF YOU HAVE ENTERED THE CORRECT AMOUNT!");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                functions.DisconnectToDB();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Form start = new Start_Form();
            start.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm openPasswordForm = new ChangePasswordForm();
            openPasswordForm.ShowDialog();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            LogOffForm openLogOff = new LogOffForm();
            openLogOff.ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCashReport_Click(object sender, EventArgs e)
        {
            functions = new UseDatabase.UseDatabase();
            functions.ConnectToDB();
            try
            {
                expression = "username='" + username + "' AND iPassword='" + password + "'";
                DataRow[] foundRow = getRow(expression);

                if (foundRow != null)
                {
                    date = DateTime.Now;
                    string balance = Convert.ToString(foundRow[0]["balance"]);
                    double cashRecieved = Convert.ToDouble(foundRow[0]["cashRecieved"]);
                    double cashTransferred = Convert.ToDouble(foundRow[0]["cashTransfered"]);
                    
                    if (cashRecieved != 0)
                    {
                        MessageBox.Show(@date + "\nBalance = R" + balance + "\n  PENDING TRANSFER\n----------------------\n\n  CASH RECIEVED = R"
                                        + cashRecieved);
                    }
                    else if (cashTransferred != 0)
                    {
                        MessageBox.Show(@date + "\nBalance = R" + balance + "\n  PENDING TRANSFER\n----------------------\n\n  CASH TRANSFERRED = R"
                                        + cashTransferred);
                    }
                    else if ((cashTransferred != 0) && (cashRecieved != 0))
                    {
                        MessageBox.Show(@date + "\nBalance = R" + balance + "\n  PENDING TRANSFER\n----------------------\n\n    CASH RECIEVED = R"
                                        + cashRecieved + "\n    CASH TRANSFERRED = R" + cashTransferred);
                    }
                    else
                    {
                        MessageBox.Show(@date + "\nBalance = R" + balance + "\n  PENDING TRANSFER\n ----------------------\n\n      Nil");
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                functions.DisconnectToDB();
            }
        }

        private void btnStandby_KeyDown(object sender, KeyEventArgs e)
        {
            btnStandby.ForeColor = Color.Red;
        }

        private void btnCashReport_KeyDown(object sender, KeyEventArgs e)
        {
            btnStandby.ForeColor = Color.Red;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(165, 135);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(155, 125);
        }
    }
}
