using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple_Grading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Set Varible for grade
                string grade;
                // Hold Weight
                decimal weight;
                //Hold Varible for Price
                decimal price;
                //Base price
                decimal basePrice = 2.50;

                // Hold excess for grade A
                decimal a = 

                //Retreave weight number
                decimal.TryParse(weightTextBox.Text, out weight);

                // Calculation of price according to weight
                price = (weight * basePrice);
                // Calcuate price according to grade


                // Detect Grade A
                if (appleGradeComboBox.SelectedIndex != -1) ;
                { 
                // Get Selected Item
                grade = appleGradeComboBox.SelectedItem.ToString();

                    //Determine the grade
                    if (grade = string A)
                    {
                        case "a":
                            priceTextBox.Text = "test";

                     }

              else
                    {
                        MessageBox.Show("Select a grade.");
                    }
                }
            }
        }
    }
}
