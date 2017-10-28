namespace SalesAnalysis
{
    public partial class salesAnalysisForm : Form
    {
        public salesAnalysisForm()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            //Clear Fields
            Close();

        }
        private void Average()
        {
            // Create an array.
            double[] scores = { 92.5, 81.6, 65.7, 72.8 };

            // Declare and initialize an accumulator variable.
            double total = 0.0;

            // Declare a variable to hold the average.
            double average;

            // Step through the array, adding each element to
            // the accumulator.
            for (int index = 0; index < scores.Length; index++)
            {
                total += scores[index];
            }

            // Calculate the average.
            average = total / scores.Length;

            // Display the average.
            salesListBox.Items.Add("");
            salesListBox.Items.Add("The average is " +average);
        }
        private void HighNumb()
        {
            // Create an array.
            int[] numbers = { 8, 1, 12, 6, 2 };
            
            // Declare a variable to hold the highest value, and
            // initialize it with the first value in the array.
            int highest = numbers[0];
            
            // Step through the rest of the array, beginning at
            // element 1. When a value greater than highest is found,
            // assign that value to highest.
            for (int index = 1; index < numbers.Length; index++)
                {
                 if (numbers[index] > highest)
                     {
                     highest = numbers[index];
                     }
                }
            // Display the highest value.
            salesListBox.Items.Add("");
            salesListBox.Items.Add("The highest value is" +highest);

        }
        private void LowestNumber()
        {

            // Create an array.
            int[] numbers = { 8, 1, 12, 6, 2 };
            
            // Declare a variable to hold the lowest value, and
            // initialize it with the first value in the array.
            int lowest = numbers[0];
            
            // Step through the rest of the array, beginning at
            // element 1. When a value less than lowest is found,
            // assign that value to lowest.
            for (int index = 1; index < numbers.Length; index++)
                {
                 if (numbers[index] < lowest)
                    {
                    lowest = numbers[index];
                    }
                 }

            // Display the lowest value.
            salesListBox.Items.Add("");
            salesListBox.Items.Add("The lowest value is " +lowest);

        }
        public void ReadFile()
        {
            //open dialog
            if (readOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the lowest value.
                salesListBox.Items.Add("Sales from file");
                salesListBox.Items.Add("");
                //create varible
                StreamReader inputfile;
                // hold file in varible
                inputfile = File.OpenText(readOpenFileDialog.FileName);
                // set varibles
                string line = "";
                double sum = 0;


                while (!inputfile.EndOfStream)
                {

                    // hold line
                    line = inputfile.ReadLine();
                    // add line to listbox
                    salesListBox.Items.Add(line);

                    
                    double currentNum = 0.0;

                    if (double.TryParse(line, out currentNum))
                    {
                        sum = sum + currentNum;
                    }
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Use method to open file
                ReadFile();
                Average();
                HighNumb();
                LowestNumber();
            }
            catch
            {
                MessageBox.Show("Wrong Imput, Please try again");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           //Clear text box
           salesListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //perform method to clear listbox
            Clear();
        }
    }
}
