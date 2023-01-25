using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivisionDecVSMod_MunaShabab
{
    //Author: Muna Shabab
    //ID: 624191
    //Date:11-2-19
    //Goal: to show integer division with remainder using modular division and decimal division with user input
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clacButton_Click(object sender, EventArgs e)
        {
            //declare variables 
            int dividend, divisor, quotient, remainder;
            decimal decimalDivResult;
            

            //get the numbers from the textboxes with validation
            if(int.TryParse(dividendTextBox.Text,out dividend))
            {
                //if the dividend is valid proceed to validate the divisor
                if((int.TryParse(divisorTextBox.Text,out divisor))&&(divisor!=0))
                {
                    //perform the calculations
                    quotient = dividend / divisor;
                    remainder = dividend % divisor;
                    decimalDivResult = (decimal)dividend / (decimal)divisor;

                    //display the results
                    quotientLabel.Text = quotient.ToString();
                    remainderLabel.Text = remainder.ToString();
                    decimalDivLabel.Text = decimalDivResult.ToString("n4");


                }

                //display an error message for the divisor
                else
                {
                    MessageBox.Show("Please enter an integer not equal to zero for the divisor");
                    divisorTextBox.Focus();
                }
            }


            //display an error message for the dividend
            else
            {
                MessageBox.Show("Please enter an integer for the dividend");
                dividendTextBox.Focus();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all the numbers
            dividendTextBox.Text = "";
            divisorTextBox.Text = "";
            quotientLabel.Text = "";
            remainderLabel.Text = "";
            decimalDivLabel.Text = "";
        }
    }
}
