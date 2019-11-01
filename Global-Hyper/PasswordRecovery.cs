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
    public partial class PasswordRecovery : Form
    {
        string password;
        public PasswordRecovery()
        {
            InitializeComponent();
            this.password = LoginForm.sPassword;
        }

        private bool validateData(string pSuperPass, string pNewPass, string pConfirmPass)
        {
            if (pSuperPass == string.Empty)
            {
                ValidateSupervisorPass.Text = "Please enter a valid password";
                txtSuperPassword.BackColor = Color.Red;
                return true;
            }
            if (pNewPass == string.Empty)
            {
                ValidateNewPass.Text = "Please enter a a new valid password";
                txtNewPassword.BackColor = Color.Red;
                return true;
            }
            if (pConfirmPass == string.Empty)
            {
                ValidateConfirmPass.Text = "Please confirm new password";
                txtConfirmPassword.BackColor = Color.Red;
                return true;
            }
            if (pConfirmPass == string.Empty)
            {
                ValidateEmpNumber.Text = "Please enter a valid employee number";
                txtConfirmPassword.BackColor = Color.Red;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string superPass = txtSuperPassword.Text;
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (!validateData(superPass, newPass, confirmPass))
            {
                int empID = Int32.Parse(txtEmpID.Text);
            if ((txtSuperPassword.Text.Equals(password)) && (txtNewPassword.Text.Equals(txtConfirmPassword.Text)))
            {
                UseDatabase.UseDatabase usePassRecover = new UseDatabase.UseDatabase();
                usePassRecover.ConnectToDB();
                try
                {
                    string queryString = "UPDATE WORKER SET iPassword = '" + txtNewPassword.Text + "' WHERE empID=" + empID;
                    if (usePassRecover.ExecuteCommand(queryString))
                    {
                        MessageBox.Show(empID + " HAS BEEN UPDATED HER PASSWORD", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("OOPS... SOMETHING WENT WRONG! YOU MIGHT OF ENTERED AN INVALID EMPLOYEE NUMBER");
                    }
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
                }
                finally
                {
                    usePassRecover.DisconnectToDB();
                }
            }
            else
            {
                lblResult.Text = "Your password(s) do not match!";
            }    
            }
        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PasswordRecovery_Activated(object sender, EventArgs e)
        {
            ValidateSupervisorPass.Text = "";
            ValidateNewPass.Text = "";
            ValidateConfirmPass.Text = "";
            ValidateEmpNumber.Text = "";
        }

        private void txtSuperPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateSupervisorPass.Text = "";

            txtSuperPassword.BackColor = Color.White;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateNewPass.Text = "";
            txtNewPassword.BackColor = Color.White;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPass.Text = "";
            txtConfirmPassword.BackColor = Color.White;
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            ValidateEmpNumber.Text = "";
            txtEmpID.BackColor = Color.White;
        }
    }
}
