using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avggrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int mark1, mark2, mark3, mark4, average;
            mark1 = int.Parse(txtBox1.Text);
            mark2 = int.Parse(txtBox1.Text);
            mark3 = int.Parse(txtBox1.Text);
            mark4 = int.Parse(txtBox1.Text);

            average = (mark1 + mark2 + mark3 + mark4) / 4;

            txtBoxAverage.Text = (average.ToString());

            if (average >= 51)
            {
                lblPorF.Text = "Well done you've passed";
            }
            else lblPorF.Text = "You've failed";

            //lblPorF.Text = (average.ToString());
            lblPorF.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
