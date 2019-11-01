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
using System.Collections;

namespace Global_Hyper
{
    public partial class Start_Form : Form
    {
        UseDatabase.UseDatabase useStart;
        string expression;
        DataTable dt;
        double total = 0;
        string username;
        string password;

        ArrayList itemsArray = new ArrayList();

        public Start_Form()
        {
            InitializeComponent();
            this.username = LoginForm.sUsername;
            this.password = LoginForm.sPassword;
        }

        private DataRow[] getRow(string filterExpression)
        {
            string expression = filterExpression;
            DataRow[] rowFound = dt.Select(expression);
            return rowFound;
        }

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
        }

        private void btnStandby_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text != string.Empty)
            {
                useStart = new UseDatabase.UseDatabase();
                useStart.ConnectToDB();
                try
                {
                    int itemNum = Int32.Parse(txtNumbers.Text);
                    expression = "proID=" + itemNum;
                    DataRow[] foundRow = getRow(expression);
                    if (foundRow != null)
                    {
                        try
                        {
                            double price = Convert.ToDouble(foundRow[0]["price"]);
                            string name = foundRow[0]["name"].ToString();

                            itemsArray.Add(itemNum);

                            lstItems.Items.Add(name + "         R" + price);

                            total += Convert.ToDouble(foundRow[0]["price"]);
                            lblPrice.Text = "Price  R" + price;
                        }
                        catch (IndexOutOfRangeException sql)
                        {
                            lblNotification.Text = "The item you entered is not available";
                        }
                    }
                    else
                    {
                        lblNotification.Text = "The item you entered is not available";
                    }

                    txtNumbers.Clear();
                    txtNumbers.Focus();
                    //lblNotification.Text = "Notification";
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
                }
                finally
                {
                    useStart.DisconnectToDB();
                }
            }
            else
            {
                lblNotification.Text = "Please enter a valid item number";
            }
        }

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {
            txtNumbers.Focus();

            DateTime date = DateTime.Now;
            lblTime.Text = date.ToString();

            txtNumbers.Focus();

            useStart = new UseDatabase.UseDatabase();
            useStart.ConnectToDB();
            try
            {
                dt = useStart.getProduct().Tables[0];
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                useStart.DisconnectToDB();
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lstItems.Items.Add("");
            lstItems.Items.Add("TOTAL                               R" + total);
            lblPrice.Text = "Total  R" + total;

            btnTotal.Enabled = false;
            gpbNumbers.Enabled = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            useStart = new UseDatabase.UseDatabase();
            useStart.ConnectToDB();
            try
            {
                string queryString = "SELECT * FROM WORKER WHERE username='" + username + "' AND iPassword='" + password + "'";
                SqlDataReader reader = useStart.ExecuteQuery(queryString);

                if (reader != null && reader.HasRows)
                {
                    reader.Close();
                    queryString = "UPDATE WORKER SET balance = balance + " + total + " WHERE username='" + username + "' AND iPassword='" + password + "'";
                    if (useStart.ExecuteCommand(queryString))
                    {
                        lstItems.Items.Add("");
                        lstItems.Items.Add("");
                        lstItems.Items.Add("THANK YOU FOR SHOPPING WITH GLOBAL_HYPER");
                    }

                    for (int i = 0; i < itemsArray.Count; i++)
                    {
                        queryString = "UPDATE AVAILABLESTOCK SET stock = stock - 1 WHERE proID=" + itemsArray[0];
                        if (useStart.ExecuteCommand(queryString))
                        {
                            lstItems.Items.Add("HAVE A NICE DAY");
                        }
                    }

                    itemsArray.Clear();
                    btnCancel.Text = "Clear";
                    gpbNumbers.Enabled = true;
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                useStart.DisconnectToDB();
            }

            btnTotal.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Text = "Cancel";
            ArrayList index = new ArrayList();

            if (lstItems.Items != null)
            {
                if (lstItems.SelectedItem == null)
                {
                    lstItems.Items.Clear();
                    btnTotal.Enabled = true;
                    gpbNumbers.Enabled = true;
                }
                else
                {
                    int numOfItems = lstItems.Items.Count;

                    if (lstItems.SelectedIndex != numOfItems - 1)
                    {
                        lstItems.Items.RemoveAt(lstItems.SelectedIndex);
                    }
                }
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumbers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn1.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn0.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn2.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btn3.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn4.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btn5.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn6.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn7.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btn8.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn9.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnSend.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnBackspace.BackColor = Color.Red;
            }
        }

        private void txtNumbers_KeyUp(object sender, KeyEventArgs e)
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn0.BackColor = Color.White;
            btnBackspace.BackColor = Color.White;
            btnSend.BackColor = Color.White;
        }

        private void Start_Form_Activated(object sender, EventArgs e)
        {
            txtNumbers.Text = "";
            txtNumbers.Focus();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int point = txtNumbers.SelectionStart;
            string text = txtNumbers.Text;

            if (txtNumbers.TextLength != point)
            {
                StringBuilder makeString = new StringBuilder();
                ArrayList getChar = new ArrayList();
                string number = "";

                for (int i = 0; i < text.Length - 1; i++)
                {
                    getChar.Add(text[i]);

                    MessageBox.Show(getChar[i].ToString());
                }

                getChar.RemoveAt(point - 1);

                for (int i = 0; i < getChar.Count; i++)
                {
                    number = makeString.Append(getChar[i]).ToString();
                    MessageBox.Show("number is : " + number);
                }

                txtNumbers.Text = number;
            }
        }

        private void btnBackspace_MouseDown(object sender, MouseEventArgs e)
        {
            btnBackspace.BackColor = Color.Red;
        }

        private void btnBackspace_MouseUp(object sender, MouseEventArgs e)
        {
            btnBackspace.BackColor = Color.White;
        }

        private void addNumber(int num)
        {
            StringBuilder someText = new StringBuilder();
            someText.Append(txtNumbers.Text);
            someText.Append(num);
            txtNumbers.Text = someText.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addNumber(0);
        }

        private void btn0_MouseDown(object sender, MouseEventArgs e)
        {
            btn0.BackColor = Color.Red;
        }

        private void btn0_MouseUp(object sender, MouseEventArgs e)
        {
            btn0.BackColor = Color.White;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addNumber(1);
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            btn1.BackColor = Color.Red;
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            btn1.BackColor = Color.White;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addNumber(2);
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.BackColor = Color.Red;
        }

        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            btn2.BackColor = Color.White;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addNumber(3);
        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            btn3.BackColor = Color.Red;
        }

        private void btn3_MouseUp(object sender, MouseEventArgs e)
        {
            btn3.BackColor = Color.White;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addNumber(4);
        }

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            btn4.BackColor = Color.Red;
        }

        private void btn4_MouseUp(object sender, MouseEventArgs e)
        {
            btn4.BackColor = Color.White;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addNumber(5);
        }

        private void btn5_MouseDown(object sender, MouseEventArgs e)
        {
            btn5.BackColor = Color.Red;
        }

        private void btn5_MouseUp(object sender, MouseEventArgs e)
        {
            btn5.BackColor = Color.White;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addNumber(6);
        }

        private void btn6_MouseDown(object sender, MouseEventArgs e)
        {
            btn6.BackColor = Color.Red;
        }

        private void btn6_MouseUp(object sender, MouseEventArgs e)
        {
            btn6.BackColor = Color.White;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addNumber(7);
        }

        private void btn7_MouseDown(object sender, MouseEventArgs e)
        {
            btn7.BackColor = Color.Red;
        }

        private void btn7_MouseUp(object sender, MouseEventArgs e)
        {
            btn7.BackColor = Color.White;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addNumber(8);
        }

        private void btn8_MouseDown(object sender, MouseEventArgs e)
        {
            btn8.BackColor = Color.Red;
        }

        private void btn8_MouseUp(object sender, MouseEventArgs e)
        {
            btn8.BackColor = Color.White;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addNumber(9);
        }

        private void btn9_MouseDown(object sender, MouseEventArgs e)
        {
            btn9.BackColor = Color.Red;
        }

        private void btn9_MouseUp(object sender, MouseEventArgs e)
        {
            btn9.BackColor = Color.White;
        }

        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {
            btnSend.BackColor = Color.Red;
        }

        private void btnSend_MouseUp(object sender, MouseEventArgs e)
        {
            btnSend.BackColor = Color.White;
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
