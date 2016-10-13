using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosttoSendMsg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Assume that the cost, not including tax, for sending a telegram from Hamilton to Montreal is $4.50 for the first twenty
            words or less, plus $.17 for each additional word beyond twenty. Write a program which accepts the number of words
            and then determines the total cost. */
            double telegram = 4.5;
            double extra = 0.17;

            int words;
            int word2;
            double cost;
            words = int.Parse(txtboxWords.Text);

            if (words >= 20)
            {
                word2 = words - 20;
                cost = telegram + (word2 * extra);
                
                txtboxPrice.Text = (cost.ToString());

            }
            else if (words <= 20)
            {
                cost = telegram;
                txtboxPrice.Text = (cost.ToString());
               
            }

        }
    }
}
