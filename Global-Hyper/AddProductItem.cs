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
    public partial class AddProductItem : Form
    {
        UseDatabase.UseDatabase useAddProducts;
        public AddProductItem()
        {
            InitializeComponent();
        }

        private bool validateData(string pName, float price, int stock)
        {
            if (pName == string.Empty)
            {
                ValidateName.Text = "Please enter a product name";
                txtName.BackColor = Color.Red;
                return true;
            }
            if (price <= 0)
            {
                ValidatePrice.Text = "Please enter a value and must be above zero";
                txtPrice.BackColor = Color.Red;
                return true;
            }
            if (stock <= 0)
            {
                ValidateStock.Text = "Please enter the number of items";
                numOfStock.BackColor = Color.Red;
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
            float price = float.Parse(txtPrice.Text);
            int stock = Convert.ToInt32(numOfStock.Value);
            int proID;

            if (!validateData(name, price, stock))
            {
                useAddProducts = new UseDatabase.UseDatabase();
                useAddProducts.ConnectToDB();
                string queryString = @"INSERT INTO PRODUCTS(name, price) VALUES ('" + name + "', " + price + ")";
                if (useAddProducts.ExecuteCommand(queryString))
                {
                    MessageBox.Show("YOU HAVE ENTERED YOU PRODUCT ITEM");
                }
                else
                {
                    MessageBox.Show("OOPS... SOEMTHING WENT WRONG!");
                }

                try
                {
                    string expression = "name='" + name + "'";
                    DataRow[] foundRow = getRow(expression);
                    proID = Convert.ToInt32(foundRow[0]["proID"]);

                    queryString = @"INSERT INTO AVAILABLESTOCK(stock, proId) VALUES (" + stock + ", " + proID + ")";
                    if (useAddProducts.ExecuteCommand(queryString))
                    {
                        MessageBox.Show("YOUR STOCK WILL BE UPDATED");
                        this.Close();
                    }
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
                }
                finally
                {
                    useAddProducts.DisconnectToDB();
                }
            }
        }

        private DataRow[] getRow(string filterExpression)
        {
            DataTable dt = useAddProducts.getProduct().Tables[0];
            string expression = filterExpression;
            DataRow[] rowFound = dt.Select(expression);
            return rowFound;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
            txtPrice.Text = string.Format("{0:#.##}", txtPrice.Text);
        }

        private void AddProductItem_Activated(object sender, EventArgs e)
        {
            ValidateStock.Text = "";
            ValidatePrice.Text = "";
            ValidateName.Text = "";
        }

        private void numOfStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
