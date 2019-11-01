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
    public partial class DigitalPad : Form
    {
        public static float numEntered;
        StringBuilder sb = new StringBuilder();

        public DigitalPad()
        {
            InitializeComponent();
        }

        public StringBuilder createString(int num)
        {
            sb.Append(num);
            return sb;
        }

        public void changeToString(StringBuilder str)
        {
            txtNumbers.Text = str.ToString();
        }

        private void DigitalPad_Load(object sender, EventArgs e)
        {
            txtNumbers.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text != string.Empty)
            {
                try
                {
                    numEntered = float.Parse(txtNumbers.Text);
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Make sure you have typed a numerical number not a character or letter");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a numerical value or exit the window");
            }

            this.Hide();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            changeToString(createString(0));
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            changeToString(createString(1));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            changeToString(createString(2));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            changeToString(createString(3));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            changeToString(createString(4));
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            changeToString(createString(5));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            changeToString(createString(6));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            changeToString(createString(7));
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            changeToString(createString(8));
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            changeToString(createString(9));
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
        }

        private void txtNumbers_TextChanged(object sender, EventArgs e)
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
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Delete)
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
            btnDot.BackColor = Color.White;
            btnBackspace.BackColor = Color.White;
            btnSend.BackColor = Color.White;
        }

        private void DigitalPad_Activated(object sender, EventArgs e)
        {
            txtNumbers.Text = "";
            txtNumbers.Focus();
        }
    }
}
