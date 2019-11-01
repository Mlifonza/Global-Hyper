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
    public partial class ChangePasswordForm : Form
    {
        UseDatabase.UseDatabase changePass;
        string queryString;
        string username;
        string password;
        string newPassword;

        public ChangePasswordForm()
        {
            InitializeComponent();
            this.username = LoginForm.sUsername;
            this.password = LoginForm.sPassword;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newPassword = txtNewPassword.Text;
            changePass = new UseDatabase.UseDatabase();

            if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                try
                {
                    changePass.ConnectToDB();

                    queryString = "SELECT * FROM WORKER WHERE username = '" + username + "' AND iPassword = '" + password + "'";
                    SqlDataReader reader = changePass.ExecuteQuery(queryString);

                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();

                        queryString = "UPDATE WORKER SET iPassword = '" + newPassword + "' WHERE username = '" + username + "' AND iPassword = '" + password + "'";
                        bool result = changePass.ExecuteCommand(queryString);
                        if (result)
                        {
                            MessageBox.Show("Your password is changed!");
                            
                            this.Hide();
                        }
                        else
                        {
                            lblResult.Text = "Unable to change password, try again";
                        }
                    }
                    else
                    {
                        lblResult.Text = "Unable to change password, try again";
                    }
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
                }
                finally
                {
                    changePass.DisconnectToDB();
                }
            }
            else
            {
                lblResult.Text = "Your password(s) do not match";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
