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
    public partial class DeleteProduct : Form
    {
        UseDatabase.UseDatabase delProduct = new UseDatabase.UseDatabase();
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtProID.Text != string.Empty)
            {
                try
                {
                    int product = Int32.Parse(txtProID.Text);
                    delProduct.ConnectToDB();
                    string queryString = "SELECT * FROM PRODUCTS WHERE proID = " + product;

                    SqlDataReader reader = delProduct.ExecuteQuery(queryString);
                    if (reader != null && reader.HasRows)
                    {
                        reader.Close();
                        DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            queryString = "EXEC deleteProduct " + product;
                            if (delProduct.ExecuteCommand(queryString))
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
                    delProduct.DisconnectToDB();
                }
            }
            else
            {
                lblResult.Text = "Please enter a product identification";
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
