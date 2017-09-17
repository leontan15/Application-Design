using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintJobEstimator
{
    public partial class paintJobEstimateForm : Form
    {
        public paintJobEstimateForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //To Calculate Litres Required

                    //To hold Square Meters Required
                    decimal sqMReq;
                    //To hold Liter of Paint Required
                    decimal ltOfPaintReq;
                    //Declare the value of wallSpace
                    decimal wallSpace = 115;

                    //Get Square meters required and assign it to sqMreg
                    sqMReq = decimal.Parse(squareMReqTextBox.Text);

                    //Calculate Litres Required
                    ltOfPaintReq = sqMReq / wallSpace;

                    //Display Calculate in the litrePaintReqAnswer label
                    litrePaintReqAnswer.Text = ltOfPaintReq.ToString();
                       

                // Calculate Labour Hours Required

                    //Delcare the value of Labour Hours per Litre
                    decimal labourHours = 8;
                    //To hold labour hours required
                    decimal labourHoursReq;
               
                    //To Calculate Labour hours
                    labourHoursReq = ltOfPaintReq * labourHours;

                    //Display Calculation in hoursLabReqAnswer Label
                    hoursLabReqAnswer.Text = labourHoursReq.ToString();


                //Calculate the Cost of Paint

                    //To hold cost of paint
                    decimal costOfPaint;
               
                    //Get Price of Paint and assign to pricePerLitre
                    costOfPaint = decimal.Parse(pricePaintPerSqMTextBox.Text);
                            
                    //Calculation
                    costOfPaint = ltOfPaintReq * costOfPaint;

                    //Display
                    costOfPtAnswer.Text = costOfPaint.ToString("c");

               
                //Calculate the Labour Charge

                    //To declare labour rate per hour
                    decimal labourRate = 20;
                    // To hold labour charge
                    decimal labourCharge;

                    //To Calculate Labour Charge
                    labourCharge = labourHoursReq * labourRate;

                    //To display calculation
                    labourCharAnswer.Text = labourCharge.ToString("C");


                //Calculate Total Cost
                    //To hold total cost
                    decimal totalCost;

                    //Calculate Total Cost
                    totalCost = costOfPaint + labourCharge;

                    //Display cost of Paint
                    totalCostAnswer.Text = totalCost.ToString("c");

            // Ensures the total cost is not 0 or negative
                if ((totalCost <= 0))
                {
                    //Message indicating inputs are invalid
                    MessageBox.Show("'Square Meters Required' and 'Price of Paint Per Litre' must be more than 0");
                    Application.Restart();
                }

            }
            //Catch Block
            catch
            {
                //Display an error message when invalid inputs are entered.
                MessageBox.Show("Invalid Entry, please check your inputs");
            }
                            
   
        }
        //Closes the program with exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
