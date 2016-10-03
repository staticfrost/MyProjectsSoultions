using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            /*Write a program which accepts an employees name, rate of pay and hours worked. The
            following values should then be calculated: Gross pay, Taxes (20 % of gross pay), and net
            pay.*/
            string name;
            double hourlyRate;
            int hoursWorked;

            double grossPay;
            double taxes;
            double netPay;

            name = txtbName.Text;
            hourlyRate = double.Parse(txtbHourlyRate.Text); //convert string to double from the text box
            hoursWorked = int.Parse(txtbHoursWorked.Text); //convert string to int from the text box
            grossPay = hourlyRate * hoursWorked; // Gross pay is hourly rate * hours worked.
            txtbGrossPay.Text = (grossPay.ToString()); // print gross pay to text box

            //taxes are 20% of the gross pay.
            taxes = grossPay * 0.20;
            txtbTaxes.Text = (taxes.ToString());

            //net pay is gross pay - taxes
            netPay = grossPay - taxes;
            txtbNetPay.Text = (netPay.ToString());


        }
    }
}
