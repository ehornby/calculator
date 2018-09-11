using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        double FirstNumber;
        string Operation;
        double Mem = 0;
        public Calc()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "1";
            }
            else
            {
                display.Text = display.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "2";
            }
            else
            {
                display.Text = display.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "3";
            }
            else
            {
                display.Text = display.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "4";
            }
            else
            {
                display.Text = display.Text + "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "5";
            }
            else
            {
                display.Text = display.Text + "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "6";
            }
            else
            {
                display.Text = display.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "7";
            }
            else
            {
                display.Text = display.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "8";
            }
            else
            {
                display.Text = display.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "9";
            }
            else
            {
                display.Text = display.Text + "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text + "0";
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "-";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "/";                
        }

        private void bc_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void beq_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(display.Text);

            switch (Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    break;
                case "/":
                    if (SecondNumber == 0)
                    {
                        display.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        Result = FirstNumber / SecondNumber;
                        display.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    break;
            }
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            FirstNumber = Math.Sin(Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(FirstNumber);
        }

        private void bcos_Click(object sender, EventArgs e)
        {
            FirstNumber = Math.Cos(Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(FirstNumber);
        }

        private void btan_Click(object sender, EventArgs e)
        {
            FirstNumber = Math.Tan(Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(FirstNumber);
        }

        private void bmstore_Click(object sender, EventArgs e)
        {
            Mem = Convert.ToDouble(display.Text);
            bmrec.Enabled = true;
        }

        private void bmadd_Click(object sender, EventArgs e)
        {
            Mem += Convert.ToDouble(display.Text);
            bmrec.Enabled = true; 
        }

        private void bmsub_Click(object sender, EventArgs e)
        {
            Mem -= Convert.ToDouble(display.Text);
            bmrec.Enabled = true; 
        }

        private void bmclr_Click(object sender, EventArgs e)
        {
            bmrec.Enabled = false;
            Mem = 0;
        }

        private void bmrec_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
            {
                display.Text = Convert.ToString(Mem);
            }
        }
    }
}
