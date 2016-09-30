using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumnCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void TxtBLength_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void TxtBWidth_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TxtBHeight_TextChanged(object sender, EventArgs e)
        {
            
        }


        public void BtnCalculate_Click(object sender, EventArgs e)
        {
            //LenghtxWidthxHeight
            //Need to work out how to read out the text box string to int - 
            //Answer from here: http://www.homeandlearn.co.uk/csharp/csharp_s2p14.html

            int Length;
            int Width;
            int Height;
            int Answer;

            Length = int.Parse(TxtBLength.Text); //This converts the TextBox .Text's to Intergers from Strings
            Width = int.Parse(TxtBWidth.Text);
            Height = int.Parse(TxtBHeight.Text);

            Answer = Length * Width * Height;

            //MessageBox.Show(int.Parse(TxtBLength.Text) * int.Parse(TxtBWidth.Text) * int.Parse(TxtBHeight.Text));
            //MessageBox.Show(TxtBLength.Text * TxtBWidth.Text * TxtBHeight.Text);
            //MessageBox.Show(TxtBLength.Text * TxtBWidth.Text);

            //MessageBox.Show(Answer.ToString());  //Could use a messsage box to show answer, but i have a text box.

            //TxtBAnswer.Text = (Answer.ToString()); does the text box really need to be converted to string?
            //lets find out

            //YES id does


            TxtBAnswer.Text = (Answer.ToString());


        }

        private void TxtBAnswer_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}
