using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int grade;
            grade = int.Parse(textBox1.Text);
            /*
             0 <= mark < 50 F
            50 <= mark < 60 D
            60 <= mark < 70 C
            70 <= mark < 80 B
            80 <= mark < 100 A */



            if (grade < 50)
            {
                label3.Text = ("F".ToString());
                
                label3.Visible = true;
            }
            else if (grade >= 51 && grade <= 60)
            {
                label3.Text = ("D".ToString());
                
                label3.Visible = true;
            }
            else if (grade >= 61 && grade <= 70)
            {
                label3.Text = ("C".ToString());
                
                label3.Visible = true;
            }
            else if (grade >= 71 && grade < 80)
            {
                label3.Text = ("B".ToString());
                
                label3.Visible = true;
            }
            else if (grade > 80 && grade <= 101)
            {
                label3.Text = ("A".ToString());
                label3.Visible = true;
            }

            
            else label3.Visible = true;
            //label3.Text = "Enter a Number for Grading";
        }
        }
    }

