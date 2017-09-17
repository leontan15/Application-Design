using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanceCalculator
{
    public partial class distanceForm : Form
    {
        public distanceForm()
        {
            InitializeComponent();
        }
        

        private void calculateValues_Click(object sender, EventArgs e)
        {
			try
            {
                //Clear listbox
                
                distantListBox.Items.Clear();

                // To calculate Total Distance

                // To hold Vehicle Speed
                int vehSp;
                //Get Vehicle Speed
                int.TryParse(vSpeed.Text, out vehSp);
                
                // To hold Hours traveled
                int hoursTrav;
                // Get Hours Traveled
                int.TryParse(vHours.Text, out hoursTrav);

                // Loop Counter, initialized with 1
                int count = 1;
                //Calculation for distance
                int distance;
                // Ensures the Speed is with reasonable range
                if ((vehSp >= 401))
                {
                    //Message indicating inputs are invalid
                    MessageBox.Show("Vehicle Speed must not exceed 400kmh");
                    Application.Restart();
                }
                // Restricts Hours to 500
                else if ((hoursTrav >= 501))
                {
                    //Message indicating inputs are invalid
                    MessageBox.Show("Hours must not exceed 500");
                    Application.Restart();
                }
                // Ensures the kph is not 0 or negative
                else if ((vehSp <= 0))
                {
                    //Message indicating inputs are invalid
                    MessageBox.Show("Vehicle speed must be more than 0");
                    Application.Restart();
                }
                // Ensures the hours is not 0 or negative
                else if ((hoursTrav <= 0))
                {
                    //Message indicating inputs are invalid
                    MessageBox.Show("Hours must be more than 0");
                    Application.Restart();
                }


                //Calculate Distance
                while (count <= hoursTrav)
                {
                    // Calc Add this hour to the balance
                    distance = (vehSp * count);

                    //Add this hour to distance in distance traveled
                    distantListBox.Items.Add(" The distance "+" for " + count.ToString() + " hour is " + distance.ToString() + " km ");
                    
                    // Add to Loop
                    count = count + 1;
                }
                
                
            }
            catch
            {
                MessageBox.Show("Invalid Data entered");
            }

        }

       
    
        private void exitProgram_Click(object sender, EventArgs e)
        {
            // Close the program
            Close();
        }
    }
}
