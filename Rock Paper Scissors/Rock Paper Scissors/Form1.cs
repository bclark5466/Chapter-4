using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rock = 1;
            CalculateWinner(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lblChosen.Text = "2";
            CalculateWinner(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            lblChosen.Text = "3";
            CalculateWinner(3);
        }

        private void CalculateWinner(int theDecision)
        {
            int min = 1;
            int max = 4;
            string result = null;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            if (theDecision == randomNumber)
            {
                result = ("You tied");
            }

            else if (randomNumber == 1)
            {
                if (theDecision == 2)
                {
                    result = "You beat the Rock";
                }
                else if (theDecision == 3)
                {
                    result = "You lost to the Rock";
                }
            }

            else if (randomNumber == 2)
            {
                if (theDecision == 1)
                {
                    result = "The Rock broke the scissors. You win";
                }
                else if (theDecision == 3)
                {
                    result = "Those scissors chopped you up";
                }
            }
            else if (randomNumber == 3)
            {
                if (theDecision == 1)
                {
                    result = "The Rock was smothered by paper. You lose";
                }
                else if (theDecision == 2)
                {
                    result = "You chopped up the paper. Nice";
                }
            }

            lblResult.Text = result; 
        }
    }
}
