using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrenheitToCelsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double fahOne;
        private double fahTwo;
        private double fahThree;
        private double celsiusOne;
        private double celsiusTwo;
        private double celsiusThree;
        private double average;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            fahOne = Convert.ToDouble(txtInputOne.Text);
            fahTwo = Convert.ToDouble(txtInputTwo.Text);
            fahThree = Convert.ToDouble(txtInputThree.Text);

            celsiusOne = Math.Round(((fahOne - 32) / 1.8), 2);
            celsiusTwo = Math.Round(((fahTwo - 32) / 1.8), 2);
            celsiusThree = Math.Round(((fahThree - 32) / 1.8), 2);
            average = Math.Round(((celsiusOne + celsiusTwo + celsiusThree) / 3), 2);

            lblOutputOne.Text = "It is " + celsiusOne + " degrees Celsius";
            lblOutputTwo.Text = "It is " + celsiusTwo + " degrees Celsius";
            lblOutputThree.Text = "It is " + celsiusThree + " degrees Celsius";
            lblAverage.Text = "The average temperature is " + average + " degrees Celsius";
            lblUnitIn.Text = "Temperature in Fahrenheit";
            lblUnitOut.Text = "Temperature in Celsius";

            pcToC.Visible = true;
            pcToF.Visible = false;

            if (average < 0)
            {
                lblWord.Text = "It's freezing";
            }

            else if (average > 37)
            {
                lblWord.Text = "Warning, heat wave";
            }

            else
            {
                lblWord.Text = "Nice";
            }

            
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            celsiusOne = Convert.ToDouble(txtInputOne.Text);
            celsiusTwo = Convert.ToDouble(txtInputTwo.Text);
            celsiusThree = Convert.ToDouble(txtInputThree.Text);

            fahOne = Math.Round(((celsiusOne * 1.8) + 32), 2);
            fahTwo = Math.Round(((celsiusTwo * 1.8) + 32), 2);
            fahThree = Math.Round(((celsiusThree * 1.8) + 32), 2);
            average = Math.Round(((fahOne + fahTwo + fahThree) / 3), 2);

            lblOutputOne.Text = "It is " + fahOne + " degrees Fahrenheit";
            lblOutputTwo.Text = "It is " + fahTwo + " degrees Fahrenheit";
            lblOutputThree.Text = "It is " + fahThree + " degrees Fahrenheit";
            lblAverage.Text = "The average temperature is " + average + " degrees Fahrenheit";
            lblUnitIn.Text = "Temperature in Celsius";
            lblUnitOut.Text = "Temperature in Fahrenheit";


            pcToC.Visible = false;
            pcToF.Visible = true;

            if (average < 32)
            {
                lblWord.Text = "It's freezing";
            }

            else if (average > 100)
            {
                lblWord.Text = "Warning, heat wave";
            }

            else
            {
                lblWord.Text = "Nice";
            }


        }
    }
}
