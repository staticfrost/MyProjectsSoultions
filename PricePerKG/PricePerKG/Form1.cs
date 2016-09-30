using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PricePerKG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalKG; // ask customer how much weight they want(this should be a double incase they want less than a KG)
            double pricePerKG = 16.91; // this is static. 
            
            double total; // this is a double cause price has decimals.

            totalKG = double.Parse(txtbKG.Text); //should be a double.Prase as it it's a double going into this variable... derp

            total = totalKG * pricePerKG;

            txtbTotal.Text = (total.ToString());

            //22kg * $16.91 = $372.02
            //200g (0.2) * $16.91 = $3.382

        }
    }
}
