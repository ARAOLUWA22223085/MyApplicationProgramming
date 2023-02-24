using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {

        private double Miles;
        private double Feet;

        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <Summary>
        /// Prompts user for Input value in Miles
        /// Input value for Miles as a double number
        ///</Summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of Miles > ");
            string miles = Console.ReadLine();
            Miles = Convert.ToDouble(miles);
        }
        /// <Summary>
        /// Applies multiplier for conversion of Miles to Feet
        ///</Summary>
        private void CalculateFeet()
            {

            }
        /// <Summary>
        /// Outputs the converted value now in Feet
        ///</Summary>
        private void OutputFeet()
            {

            }
        
    }
}
