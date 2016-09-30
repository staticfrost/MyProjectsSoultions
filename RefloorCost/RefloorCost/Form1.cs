using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefloorCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Rlength;
            double Rwidth;
            int pricePerM = 12; //static $12perM
            double squareM;
            double price;

            //work out price per square meter length x width.
            //Multiply the length and width together. multiply them together to get the measurement of the area in square meters.
            //2.35m x 1.08m = 2.538 square meters (m2).

            Rlength = double.Parse(txtbLength.Text); //convert string to int
            Rwidth = double.Parse(txtbWidth.Text);   //convert string to int
            //convert the dimensions of the room into square meters
            squareM = Rlength * Rwidth;
            //work out the price
            price = squareM * pricePerM;

            //display the price
            txtbPrice.Text = ("$ " + price.ToString());

        }
    }
}
