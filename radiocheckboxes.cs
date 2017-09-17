using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appleWeightPriceDeterminer
{
    public partial class AppleQualityDeterminer : Form
    {
        public AppleQualityDeterminer()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // try catch block to ensure the program 'catches' errors.
            try
            {
                // Declaration of variables
                // input weight of apples
                decimal applesWeight;

                // static price of apples
                decimal staticApplePrice = 2.50m;

                // Radio button 'A' bonus
                decimal aBonus = 1.15m;

                // Radio button 'B' bonus
                decimal bBonus = 1.05m;

                // Radio button 'B' bonus
                decimal cBonus = 1.00m;

                // output price 
                decimal finalPrice;

                // String to integer for user input
                applesWeight = decimal.Parse(weightInputLabel.Text);

                // Checks to determine adequate data input
                if (!(aRadio.Checked) && !(bRadio.Checked) && !(cRadio.Checked))
                {
                    MessageBox.Show("Please select a bonus.");
                }


                // If else to determine the price for each radio box selection                
                if (aRadio.Checked)
                {
                    finalPrice = (applesWeight * staticApplePrice) * aBonus;
                    finalPriceOutput.Text = finalPrice.ToString("c");
                }

                if (bRadio.Checked)
                { 
                    finalPrice = (applesWeight * staticApplePrice) * bBonus;
                    finalPriceOutput.Text = finalPrice.ToString("c");
                }

                if (cRadio.Checked)
               {
                    finalPrice = (applesWeight * staticApplePrice) * cBonus;
                    finalPriceOutput.Text = finalPrice.ToString("c");
                }

            
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void exitFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearInputLabelButton_Click(object sender, EventArgs e)
        {
            weightInputLabel.Text = "";
        }
    }
    
}
