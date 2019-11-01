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
    public partial class Admin_HomeForm : Form
    {
        UseDatabase.UseDatabase adminFunctions;
        Admin_DigitalPad adminPad = new Admin_DigitalPad();
        string queryString;
        string operatorUsername;
        string username;
        string password;
        float amount;
        string expression;

        public Admin_HomeForm()
        {
            InitializeComponent();
            this.username = LoginForm.sUsername;
            this.password = LoginForm.sPassword;
        }

        private void btnStandby_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private SqlDataReader checkUsername()
        {
            queryString = "SELECT * FROM WORKER WHERE username='" + operatorUsername + "' AND loggedIn='true'";
            SqlDataReader reader = adminFunctions.ExecuteQuery(queryString);
            return reader;
        }

        private SqlDataReader checkIfLoggedIn()
        {
            queryString = "SELECT * FROM WORKER WHERE username='" + operatorUsername + "' AND loggedIn='true'";
            SqlDataReader reader = adminFunctions.ExecuteQuery(queryString);
            return reader;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm openChangePass = new ChangePasswordForm();
            openChangePass.ShowDialog();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            LogOffForm openLogOff = new LogOffForm();
            openLogOff.ShowDialog();
        }

        private void btnCashFromOperator_Click(object sender, EventArgs e)
        {
            adminPad.ShowDialog();
            try
                {
                    adminFunctions = new UseDatabase.UseDatabase();
                    adminFunctions.ConnectToDB();

                    this.amount = Admin_DigitalPad.amount;
                    queryString = "SELECT * FROM WORKER WHERE username='" + username + "' AND iPassword='" + password + "' AND cashRecieved<=" + amount;
                    SqlDataReader reader = adminFunctions.ExecuteQuery(queryString);

                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();
                        this.operatorUsername = Admin_DigitalPad.operatorUsername;

                        reader = checkIfLoggedIn();
                        if (reader != null && reader.HasRows)
                        {
                            reader.Close();

                            SqlDataReader reader1 = checkUsername();
                            if (reader1 != null && reader1.HasRows)
                            {
                                reader1.Close();
                                queryString = "EXEC cashFromOperator " + amount + ", '" + operatorUsername + "'";
                                bool result = adminFunctions.ExecuteCommand(queryString);

                                if (result)
                                {
                                    MessageBox.Show("YOUR TRANSACTION HAS BEEN ACCEPTED SUCCESSFULLY");
                                }
                                else
                                {
                                    MessageBox.Show("USERNAME DOES NOT EXIST");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("YOUR ARE ATTEMPTING TO INTERACT WITH AN UN-LOGGED IN OPERATOR", "Un-logged in user", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CHECK IF YOU HAVE ENTERED THE CORRECT AMOUNT OR A VALID USERNAME!");
                    }
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
                }
                finally
                {
                    adminFunctions.DisconnectToDB();
                }       
        }

        private void btnCashToOperator_Click(object sender, EventArgs e)
        {
            adminPad.ShowDialog();
            try
                {
                    adminFunctions = new UseDatabase.UseDatabase();
                    adminFunctions.ConnectToDB();

                    this.amount = Admin_DigitalPad.amount;
                    this.operatorUsername = Admin_DigitalPad.operatorUsername;

                    queryString = "SELECT * FROM WORKER WHERE username='" + username + "' AND iPassword='" + password + "' AND balance>=" + amount;
                    SqlDataReader reader = adminFunctions.ExecuteQuery(queryString);

                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();

                        reader = checkIfLoggedIn();
                        if (reader != null && reader.HasRows)
                        {
                            reader.Close();
                            SqlDataReader reader1 = checkUsername();
                            if (reader1 != null && reader1.HasRows)
                            {
                                reader1.Close();
                                queryString = "EXEC cashToOperator " + amount + ", '" + operatorUsername + "'";
                                bool result = adminFunctions.ExecuteCommand(queryString);

                                if (result)
                                {
                                    MessageBox.Show("YOUR TRANSACTION HAS BEEN TRANSFERRED SUCCESSFULLY");
                                }
                                else
                                {
                                    MessageBox.Show("USERNAME DOES NOT EXIST");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("YOUR ARE ATTEMPTING TO INTERACT WITH AN UN-LOGGED IN OPERATOR", "Un-logged in user", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
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
                    adminFunctions.DisconnectToDB();
                }
                
            }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            adminFunctions = new UseDatabase.UseDatabase();
            adminFunctions.ConnectToDB();
            try
            {
                adminPad.ShowDialog();
                this.amount = Admin_DigitalPad.amount;
                if (amount != 0)
                {
                    queryString = "UPDATE WORKER SET balance = balance + " + amount + "WHERE username='" + username + "' AND position='Supervisor'";
                    if (adminFunctions.ExecuteCommand(queryString))
                    {
                        MessageBox.Show("TRANSACTION SUCCESSFULL!");
                    }
                    else
                    {
                        MessageBox.Show("OOPS! SOMETHING WENT WRONG. TRY AGAIN!");
                    } 
                }
                else
                {
                    MessageBox.Show("OOPS! SOMETHING WENT WRONG. TRY AGAIN!");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                adminFunctions.DisconnectToDB();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            adminFunctions = new UseDatabase.UseDatabase();
            adminFunctions.ConnectToDB();
            try
            {
                adminPad.ShowDialog();
                this.amount = Admin_DigitalPad.amount;
                if (amount != 0)
                {
                    queryString = "SELECT * FROM WORKER WHERE username='" + username + "' AND position='Supervisor' AND balance >= " + amount;
                    SqlDataReader reader = adminFunctions.ExecuteQuery(queryString);

                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();

                        queryString = "UPDATE WORKER SET balance = balance - " + amount + "WHERE position='Supervisor'";

                        if (adminFunctions.ExecuteCommand(queryString))
                        {
                            MessageBox.Show("TRANSACTION SUCCESSFULL!");
                        }
                        else
                        {
                            MessageBox.Show("OOPS! SOMETHING WENT WRONG. TRY AGAIN!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("TRANSACTION UNSUCCESSFUL!\n\nCHECK YOUR BALANCE AND MAKE SURE YOU ARE TRANSFERRING THE CORRECT AMOUNT");
                    }
                }
                else
                {
                    MessageBox.Show("OOPS! SOMETHING WENT WRONG. TRY AGAIN!");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                adminFunctions.DisconnectToDB();
            }
        }

        private void btnCashReport_Click(object sender, EventArgs e)
        {
            DateTime date;
            adminFunctions = new UseDatabase.UseDatabase();
            adminFunctions.ConnectToDB();
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
                adminFunctions.DisconnectToDB();
            }
        }

        private DataRow[] getRow(string filterExpression)
        {
            DataTable dt = adminFunctions.getData().Tables[0];
            string expression = filterExpression;
            DataRow[] rowFound = dt.Select(expression);
            return rowFound;
        }

        private void btnAddOperator_Click(object sender, EventArgs e)
        {
            AddCashier openAddCashier = new AddCashier();
            openAddCashier.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductItem openAddProduct = new AddProductItem();
            openAddProduct.ShowDialog();
        }

        private void btnPasswordRecovery_Click(object sender, EventArgs e)
        {
            PasswordRecovery openPassRecover = new PasswordRecovery();
            openPassRecover.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Lifa Sibiya\nYear: 2017");
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct openDelPro = new DeleteProduct();
            openDelPro.ShowDialog();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProducts openViewProducts = new ViewProducts();
            openViewProducts.ShowDialog();
        }

        private void btnViewOperators_Click(object sender, EventArgs e)
        {
            View_Operators openViewOperators = new View_Operators();
            openViewOperators.ShowDialog();
        }

        private void btnDelOperator_Click(object sender, EventArgs e)
        {
            RemoveOperator openRevOperator = new RemoveOperator();
            openRevOperator.ShowDialog();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(165, 135);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(155, 125);
        }

        private void btnDelOperator_Click_1(object sender, EventArgs e)
        {
            DeleteOperator delOperator = new DeleteOperator();
            delOperator.ShowDialog();
        }
    }
}
