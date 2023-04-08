// Lab 3
// Cis 199-50
// Due: 09/26/2021
// By: S5034

// This program shows diameter, surface area, and volume of a circle from a given radius.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) // Execute function when user clicks the "Calculate" button.
        {
            //Get User Input
            double radius; 
            radius = Convert.ToDouble(inputTextBox.Text); 

            //Calculate Diameter
            double diameter; 
            diameter = radius * 2; 
            diameter = Math.Round(diameter, 2); 

            // Calculate Surface Area
            double surfaceArea; 
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2); 
            surfaceArea = Math.Round(surfaceArea, 2); 


            //Calculate Volume
            double volume; 
            volume = 4 * Math.PI * Math.Pow(radius, 3) / 3; 
            volume = Math.Round(volume, 2); 

            //Display Calculations
            diameterTextBox.Text = diameter.ToString("F2"); 
            surfaceAreaTextBox.Text = surfaceArea.ToString("F2"); 
            volumeTextBox.Text = volume.ToString("F2"); 

        }
    }
}
