using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Hyper
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'globalHyperDataSet2.productInfo' table. You can move, or remove it, as needed.
            //this.productInfoTableAdapter.Fill(this.globalHyperDataSet2.productInfo);
            //// TODO: This line of code loads data into the 'globalHyperDataSet1.PRODUCTS' table. You can move, or remove it, as needed.
            //this.pRODUCTSTableAdapter.Fill(this.globalHyperDataSet1.PRODUCTS);
            //// TODO: This line of code loads data into the 'globalHyperDataSet.productInfo' table. You can move, or remove it, as needed.

            UseDatabase.UseDatabase useProducts = new UseDatabase.UseDatabase();
            useProducts.ConnectToDB();

            DataTable dt = useProducts.viewProduct().Tables[0];
            ProductsDataGrid.DataSource = dt;

            useProducts.DisconnectToDB();

        }
    }
}
