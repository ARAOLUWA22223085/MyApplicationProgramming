using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Araoluwa  version 0.1
    /// </author>
    public class DistanceConverter
    {

        private double Miles;
        private double Feet;

        private double Multiplier = 5280;

        /// <Summary>
        /// Runs the appropriate classes
        ///</Summary>
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
            Feet = Miles * Multiplier;
        }
        /// <Summary>
        /// Outputs the converted value now in Feet
        ///</Summary>
        private void OutputFeet()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(Feet + " feet");
            Console.WriteLine();

        }

    }
}
