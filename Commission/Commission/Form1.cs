using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sales;
            double commsionPercent = 0.14; //14% (always move the decimale two places to the left.)
            //if make version two of this make it so the user enters the value of percentage.
            //ensure find away to move the decimal two places when a user enters a number.
            //for now not sure how to do that, might meed to be if loop? if 14 int else double 0.x???
            double commsionOnSales;

            sales = double.Parse(txtbSalesAmt.Text);
            //commsionOnSales = double.Parse(txtbCommision.Text); its already a double so i don't need to parse it as a double again?... huh?
            //commission ammount = pecenter(14%) or 0.14 * sales (always move the decimale two places to the left.)
            //how i worked it out - https://www.youtube.com/watch?v=qy9wVhUCvr4
            commsionOnSales = commsionPercent * sales;
            

            txtbCommision.Text = (commsionOnSales.ToString());
        }
    }
}
