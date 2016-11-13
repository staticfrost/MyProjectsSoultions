using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolCharge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* A gas company measures the amount of gas its customers use in hundreds of cubic feet (ccf) and charges them
            according to the following schedule:
            first 8 ccf 50 cents each //change this to 5KM
            more than 8 ccf 30 cents each // 5KM
            Note that the 30 cent rate applies only to usage above 8 ccf. A customer who uses 10 ccf is charged 50 cents for the
            first 8 ccf and 30 cents for the next 2 ccf. Write a program to calculate customer’s bills.*/

        private void button1_Click(object sender, EventArgs e)
        {
            int distance;
            distance = int.Parse(txtboxDistance.Text);
            double price = 0;
                        
            if (distance <= 8)
            {
                price = distance * 0.50;
            }
            else if (distance > 8)
            {
                price = 8 * 0.50 + (distance-8) * .30; 
            }
                        
            price = double.Parse(price.ToString());
            txtboxCost.Text = price.ToString();
        }
    }
}
