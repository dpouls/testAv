using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DPTestAv
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// We will create variables and store them for the input in the three test score entry fields. Then we will add the 3 test scores and divide by 3 to get the average. We assign the average to a variable and change the LblResults text to the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAverage_Clicked(object sender, EventArgs e)
        {
            // Variables for test scores and average
            double test1, test2, test3, average;
            //Store variables from user input

            try
            {
            test1 = double.Parse(EntryTest1.Text);
            test2 = double.Parse(EntryTest2.Text);
            test3 = double.Parse(EntryTest3.Text);
            // Calculate average 
            average = (test1 + test2 + test3) / 3;
            // Display results
            LblResults.Text = average.ToString("p2");

            }
            catch
            {
                //If there was an error we will notify the user and ask them to try again.
                DisplayAlert("Invalid Input", "Please ONLY enter numbers for the test scores", "Close");
            };
        }
        /// <summary>
        /// Clears the text inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            //Clears all the test score inputs
            EntryTest1.ClearValue(Entry.TextColorProperty);
            EntryTest2.ClearValue(Entry.TextColorProperty);
            EntryTest3.ClearValue(Entry.TextColorProperty);
            // returns the LblResults text back to Results...
            LblResults.Text = "Results...";
        }

    }
}
