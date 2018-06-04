using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 23-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Min Value
 * This program randomly generates 10 numbers then adds them to an array. 
 * The function GetMinValue then compares all of the number in the array to find the smallest one.
*/

namespace FindMinValueTivaR
{
    public partial class FindMinValueForm : Form
    {
        public FindMinValueForm()
        {
            InitializeComponent();
        }

        // Function: GetMinValue
        // Input: int[] tmpArrayOfIntegers - assume all values in the array are smaller than than 501
        // Output: the min value in the array 
        // Description: This function accepts an array of integers,...
        // ... scans the array and returns the minimum value in the array.
        private int GetMinValue(int[] tmpArrayOfIntegers)
        {
            // Variables
            int tmpMinValue = 500;
            const int MAX_ARRAY_SIZE = 10;

            // To cycle through array until it is all compared
            foreach ([] in tmpArrayOfIntegers)
            /*
            for (int counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                if (tmpMinValue > tmpArrayOfIntegers[counter])
                {
                    // Set the max value to be equal to the current number
                    tmpMinValue = tmpArrayOfIntegers[counter];
                }
            }
            */

            return tmpMinValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants 
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;
            Random randomNumberGenerator = new Random();

            // Clear list box
            this.lstNumberSet.Items.Clear();

            // To generate the numbers
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // Assign the random number to the cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                // add the random number to the list 
                this.lstNumberSet.Items.Add(randomNumber);

                // Refresh the form to display the new item in the list box
                this.Refresh();

                // To get the Max Value in the array
                minValue = GetMinValue(arrayOfIntegers);

                // Display the max value in the label
                this.lblMinValue.Text = "The minimum value is: " + minValue;
            }
        }
    }
}
