using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowMuchMarkUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblItemSell_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double itemCost;
            double sellPrice;

            double markupPercent;

            //markup= (sellingprice-cost) over (cost) TIMES 100

            itemCost = double.Parse(txtbItemCost.Text);
            sellPrice = double.Parse(txtbItemSell.Text);

            markupPercent = (sellPrice - itemCost) / itemCost * 100;

            txtbPercent.Text = (markupPercent.ToString());

        }
    }
}
