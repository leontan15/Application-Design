using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace randNumbFileWrite
{
    public partial class randomNumberForm : Form
    {
        public randomNumberForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Hold input from quantity textbox
                int qty;

                // 
                int.TryParse(randAmountTextbox.Text, out qty);
                //Start loop Counter at 1
                int count = 1;
                
                // Restrict file name type in save dialog
                saveRandFileDiag.Filter = "Text Files | *.txt";
                // Set file default name to text type in dialog
                saveRandFileDiag.DefaultExt = "txt";
                
                //Generate random numbers 
                Random rand = new Random();


                // Hold text files varible
                StreamWriter outputFile;
                // Catch incorrect data entry 
                if (qty <= 0)
                        {
                            // Show user message 
                            MessageBox.Show("Invalid Data Entered, please try again");
                            // Clear input in randamount text box
                            randAmountTextbox.Clear();
                            // Restarts program
                            Application.Restart();
                        }


                // User operates save dialog box
                else if (saveRandFileDiag.ShowDialog() == DialogResult.OK)
                {
                    
                    // create a flie
                    outputFile = File.CreateText(saveRandFileDiag.FileName);
                    

                    // Write Loop random numbers
                    while (count <= qty)
                    {
                        


                        // Add items to listbox
                        outputFile.WriteLine(rand.Next(100));


                        // Add to Loop
                        count = count + 1;
                                                
                    }
                    //Close file once saved
                    outputFile.Close();
                }
                else
                {
                    // Message to show save to file cancel 
                    MessageBox.Show(" The operation was cancelled ");
                }

            }
            catch
            {
                // Catch block to reduce instabili              
                MessageBox.Show("Invalid Input");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear input in randamount text box
            randAmountTextbox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            Close();
        }
    }
}
