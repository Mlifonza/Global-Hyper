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
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using UseDatabase;

namespace Global_Hyper
{
    public partial class LoginForm : Form
    {
        UseDatabase.UseDatabase useDbSql;

        //Static variable to be sent to other forms
        public static string sUsername;
        public static string sPassword;
        public static object dsReader;
        public static object sDataTable;
        string queryString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                useDbSql = new UseDatabase.UseDatabase();
                useDbSql.ConnectToDB();

                sUsername = txtUsername.Text;
                sPassword = txtPassword.Text;

                queryString = "SELECT * FROM WORKER WHERE username='" + sUsername + "' AND iPassword='" + sPassword + "'";
                SqlDataReader reader = useDbSql.ExecuteQuery(queryString);

                //Check if row was found
                if (reader != null && reader.HasRows)
                {
                    reader.Close();

                    queryString = "SELECT * FROM WORKER WHERE username='" + sUsername + "' AND iPassword='" + sPassword + "' AND position='Supervisor'";
                    reader = useDbSql.ExecuteQuery(queryString);
                    if (reader.HasRows)
                    {
                        reader.Close();
                        queryString = "UPDATE WORKER SET loggedIn = 'true' WHERE username='" + sUsername + "' AND iPassword='" + sPassword + "'";
                        bool result = useDbSql.ExecuteCommand(queryString);

                        this.Hide();
                        Admin_HomeForm openAdminHome = new Admin_HomeForm();
                        openAdminHome.ShowDialog();
                    }
                    else
                    {
                        reader.Close();
                        queryString = "UPDATE WORKER SET loggedIn = 'true' WHERE username='" + sUsername + "' AND iPassword='" + sPassword + "'";
                        bool result = useDbSql.ExecuteCommand(queryString);

                        this.Hide();
                        HomeForm homeFrm = new HomeForm();
                        homeFrm.ShowDialog();
                    }
                }
                else
                {
                    lblResults.Text = "Username or Password is wrong!";
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("An error has occurred... " + se.Message);
            }
            finally
            {
                useDbSql.DisconnectToDB();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, true);

                useDbSql = (UseDatabase.UseDatabase)Activator.GetObject(typeof(UseDatabase.UseDatabase), "tcp://localhost:720/GlobalHyper");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
