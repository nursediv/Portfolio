using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_final_practice
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            //void 
        }

        private void btnMR_Click(object sender, EventArgs e)
        {

        }

        private void btnMM_Click(object sender, EventArgs e)
        {

        }

        private void btnOp1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtAnswer.Text);
            txtAnswer.Text = "0";
            Operation = "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtAnswer.Text);
            txtAnswer.Text = "";
            Operation = "*";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "7" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "7";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "8" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "8";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "9" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "9";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "9";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtAnswer.Text);
            txtAnswer.Text = "";
            Operation = "-";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "4" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "4";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "4";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "5" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "5";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "6" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "6";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "6";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtAnswer.Text);
            txtAnswer.Text = "";
            Operation = "+";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == "" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "1";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "2" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "2";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "3" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "3";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "3";
            }

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result; 

            SecondNumber = Convert.ToDouble(txtAnswer.Text);

            if(Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
                txtAnswer.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = FirstNumber - SecondNumber;
                txtAnswer.Text += Convert.ToString(Result);
                FirstNumber = Result;
            }

            if(Operation == "*")
            {
                Result = FirstNumber * SecondNumber;
                txtAnswer.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtAnswer.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = FirstNumber / SecondNumber;
                    txtAnswer.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "0" && txtAnswer.Text != null)
            {
                txtAnswer.Text = "0";
            }
            else
            {
                txtAnswer.Text = txtAnswer.Text + "";
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + ".";

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
