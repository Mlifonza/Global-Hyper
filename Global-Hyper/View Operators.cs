using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UseDatabase;

namespace Global_Hyper
{
    public partial class View_Operators : Form
    {
        public View_Operators()
        {
            InitializeComponent();
        }

        private void View_Operators_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'globalHyperDataSet3.WORKER' table. You can move, or remove it, as needed.
            //this.wORKERTableAdapter1.Fill(this.globalHyperDataSet3.WORKER);
            //// TODO: This line of code loads data into the 'globalHyperDataSet.WORKER' table. You can move, or remove it, as needed.
            //this.wORKERTableAdapter.Fill(this.globalHyperDataSet.WORKER);
            //// TODO: This line of code loads data into the 'globalHyperDataSet1.WORKER' table. You can move, or remove it, as needed.

            UseDatabase.UseDatabase viewOperator = new UseDatabase.UseDatabase();
            viewOperator.ConnectToDB();

            DataTable dt = viewOperator.getWorker().Tables[0];
            dataGridView1.DataSource = dt;

            viewOperator.DisconnectToDB();

        }
    }
}
