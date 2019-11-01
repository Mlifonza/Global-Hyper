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
    public partial class AddCashier : Form
    {
        public AddCashier()
        {
            InitializeComponent();
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateData(string pName, string pSurname, string pUsername, string pPassword, string pConfirmPassword)
        {
            if (pName == string.Empty)
            {
                ValidateName.Text = "Please enter your name";
                txtName.BackColor = Color.Red;
                return true;
            }
            if (pSurname == string.Empty)
            {
                ValidateSurname.Text = "Please enter your surname";
                txtSurname.BackColor = Color.Red;
                return true;
            }
            if (pUsername == string.Empty)
            {
                ValidateUsername.Text = "Please enter a unique username";
                txtUsername.BackColor = Color.Red;
                return true;
            }
            
            if (pPassword == string.Empty)
            {
                ValidatePassword.Text = "Please enter a valid password";
                txtPassword.BackColor = Color.Red;
                return true;
            }
            else if (pConfirmPassword == string.Empty)
            {
                ValidateConfirmPassword.Text = "Please enter a confirmation password";
                txtConfirmPassword.BackColor = Color.Red;
                return true;
            }
            else if (pConfirmPassword != pPassword)
            {
                ValidateConfirmPassword.Text = "Your passwords do not match";
                txtConfirmPassword.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;


            if (!validateData(name, surname, username, password, confirmPassword))
            {
                if (password.Equals(txtConfirmPassword.Text))
                {
                    string queryString = "EXEC insertTable " + name + "," + surname + "," + username + "," + password + "";

                    UseDatabase.UseDatabase addCashierFunctions = new UseDatabase.UseDatabase();
                    addCashierFunctions.ConnectToDB();
                    try
                    {
                        if (addCashierFunctions.ExecuteCommand(queryString))
                        {
                            MessageBox.Show("YOU HAVE ADDED AN OPERATOR SUCCESSFULLY");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("SOMETHING WENT WRONG, CHECK YOUR DETAILS AND RE-ENTER THEM AGAIN");
                        }
                    }
                    catch (SqlException sql)
                    {
                        MessageBox.Show(sql.Message);
                    }
                    finally
                    {
                        addCashierFunctions.DisconnectToDB();
                    }
                }
                else
                {
                    lblResults.Text = "Your password(s) do not match";
                }
            }
        }

        private void AddCashier_Activated(object sender, EventArgs e)
        {
            ValidateName.Text = "";
            ValidateSurname.Text = "";
            ValidateUsername.Text = "";
            ValidatePassword.Text = "";
            ValidateConfirmPassword.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateName.Text = "";
            txtName.BackColor = Color.White;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            ValidateSurname.Text = "";
            txtSurname.BackColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername.Text = "";
            txtUsername.BackColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword.Text = "";
            txtPassword.BackColor = Color.White;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword.Text = "";
            txtConfirmPassword.BackColor = Color.White;
        }
    }
}
