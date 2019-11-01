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
    public partial class Admin_DigitalPad : Form
    {
        public static float amount;
        public static string operatorUsername;

        public Admin_DigitalPad()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if ((txtNumbers.Text != string.Empty) && (txtUsername.Text != string.Empty))
            {
                amount = float.Parse(txtNumbers.Text);
                operatorUsername = txtUsername.Text;

                this.Close();
            }
            else
            {
                txtUsername.BackColor = Color.Red;
                txtNumbers.BackColor = Color.Red;
                lblResults.Text = "Your Amount or Username field cannot be empty";
            }
        }

        private void Admin_DigitalPad_Load(object sender, EventArgs e)
        {
            txtNumbers.Focus();
            txtNumbers.Clear();
            txtAmount.Clear();
            txtUsername.Clear();
        }

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //if (e.KeyChar == '1')
            //{
            //    btn1.BackColor = Color.Red;
            //}
            //else
            //{
            //    btn1.BackColor = Color.White;
            //}
        }

        private void txtNumbers_TextChanged(object sender, EventArgs e)
        {
            txtNumbers.BackColor = Color.White;
            txtAmount.Text = "R" + txtNumbers.Text;

            //var num = float.Parse(txtNumbers.Text);
            //txtNumbers.Text = float.Round(num, 2).ToString();
        }

        private void Admin_DigitalPad_Activated(object sender, EventArgs e)
        {
            lblResults.Text = "";
            txtNumbers.Text = "";
            txtNumbers.Focus();
            txtNumbers.TabIndex = 0;
            txtUsername.TabIndex = 1;
            btnProcess.TabIndex = 2;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.LightGray;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumbers.Text = txtNumbers.Text + "1";
        }

        private void btn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.D1)
            //{
            //    btn1.BackColor = Color.Red;
            //}
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.D1)
            //{
            //    btn1.BackColor = Color.Red;
            //}
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
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Decimal)
            {
                btnDot.BackColor = Color.Red;
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
            btnDot.BackColor = Color.White;
            btnBackspace.BackColor = Color.White;
            
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnProcess.BackColor = Color.Red;
            }
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            btnProcess.BackColor = Color.White;
        }

        private void btn0_MouseDown(object sender, MouseEventArgs e)
        {
            btn0.BackColor = Color.Red;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumbers.Text = txtNumbers.Text + "0";
        }

        private void btn0_MouseUp(object sender, MouseEventArgs e)
        {
            btn0.BackColor = Color.White;
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
            txtNumbers.Text = txtNumbers.Text + "2";
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
            txtNumbers.Text = txtNumbers.Text + "3";
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
            txtNumbers.Text = txtNumbers.Text + "4";
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
            txtNumbers.Text = txtNumbers.Text + "5";
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
            txtNumbers.Text = txtNumbers.Text + "6";
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
            txtNumbers.Text = txtNumbers.Text + "7";
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
            txtNumbers.Text = txtNumbers.Text + "8";
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
            txtNumbers.Text = txtNumbers.Text + "9";
        }

        private void btn9_MouseDown(object sender, MouseEventArgs e)
        {
            btn9.BackColor = Color.Red;
        }

        private void btn9_MouseUp(object sender, MouseEventArgs e)
        {
            btn9.BackColor = Color.White;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtNumbers.Text = txtNumbers.Text + ".";
        }

        private void btnDot_MouseDown(object sender, MouseEventArgs e)
        {
            btnDot.BackColor = Color.Red;
        }

        private void btnDot_MouseUp(object sender, MouseEventArgs e)
        {
            btnDot.BackColor = Color.White;
        }

        private void btnProcess_MouseDown(object sender, MouseEventArgs e)
        {
            btnProcess.BackColor = Color.Red;
        }

        private void btnProcess_MouseUp(object sender, MouseEventArgs e)
        {
            btnProcess.BackColor = Color.White;
        }
    }
}
