using System;
using System.Threading;

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
        public const double MilesToFeetMultiplier = 5280;
        public const double MilesToMetresMultiplier = 5280;
        public const double FeetToMilesMultiplier = 5280;
        public const double FeetToMetresMultiplier = 5280;
        public const double MetresToFeetMultiplier = 5280;
        public const double MetresToMilesMultiplier = 5280;

        private double conversion;

        private double Miles;
        private double Feet;
        private double Metres;

        private double OutputMilesToFeet;
        private double OutputMilesToMetres;
        private double OutputFeetToMiles;
        private double OutputFeetToMetres;
        private double OutputMetresToFeet;
        private double OutputMetresToMiles;


        /// <Summary>
        /// Runs the appropriate classes
        ///</Summary>
        public void Run()
        {
            OutputHeading();
            ConversionType();
        }

        private void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("           Distance converter Application         ");
            Console.WriteLine("                By Araoluwa Olatunji              ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }

        private void ConversionType()
        {
            Console.WriteLine();
            Console.WriteLine("1. Miles to Feet");
            Console.WriteLine("2. Miles to Metres");
            Console.WriteLine("3. Feet to Miles");
            Console.WriteLine("4. Feet to Metres");
            Console.WriteLine("5. Metres to Feet");
            Console.WriteLine("6. Metres to Miles");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Please select the number corresponding to the conversion type required > ");
            Console.WriteLine();

            double conversion = Console.Read();

            if (conversion == 1)
            {
                Console.WriteLine("Miles to Feet");
                InputMiles();
                CalculateMilesToFeet();
                MilesToFeet();
            }

            else if (conversion == 2)
            {
                Console.WriteLine("Miles to Metres");
                InputMiles();
                CalculateMilesToMetres();
                MilesToMetres();
            }

            else if (conversion == 3)
            {
                Console.WriteLine("Feet to Miles");
                InputFeet();
                CalculateFeetToMiles();
                FeetToMiles();
            }

            else if (conversion == 4)
            {
                Console.WriteLine("Feet to Metres");
                InputFeet();
                CalculateFeetToMetres();
                FeetToMetres();
            }

            else if (conversion == 5)
            {
                Console.WriteLine("Metres to Feet");
                InputMetres();
                CalculateMetresToFeet();
                MetresToFeet();
            }

            else if (conversion == 6)
            {
                Console.WriteLine("Metres to Miles");
                InputMetres();
                CalculateMetresToMiles();
                MetresToMiles();
            }

            else
            {
                Console.WriteLine("Please input a valid number!");
/*                Thread.Sleep(1500);
                ConversionType();*/

            }
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
        /// Prompts user for Input value in Metres
        /// Input value for Metres as a double number
        ///</Summary>
        private void InputMetres()
        {
            Console.Write("Please enter the number of Metres > ");
            string metres = Console.ReadLine();
            Metres = Convert.ToDouble(metres);
        }

        /// <Summary>
        /// Prompts user for Input value in Feet
        /// Input value for Feet as a double number
        ///</Summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of Feet > ");
            string feet = Console.ReadLine();
            Feet = Convert.ToDouble(feet);
        }

        /// <Summary>
        /// Applies multiplier for conversion of Miles to Feet
        ///</Summary>
        
        private void CalculateMilesToFeet()
        {
            OutputMilesToFeet = Miles * MilesToFeetMultiplier;
        }

        private void CalculateMilesToMetres()
        {
            OutputMilesToMetres = Miles * MilesToMetresMultiplier;
        }

        private void CalculateFeetToMiles()
        {
            OutputFeetToMiles = Feet * FeetToMilesMultiplier;
        }

        private void CalculateFeetToMetres()
        {
            OutputFeetToMetres = Feet * FeetToMetresMultiplier;
        }

        private void CalculateMetresToFeet()
        {
            OutputMetresToFeet = Metres * MetresToFeetMultiplier;
        }

        private void CalculateMetresToMiles()
        {
            OutputMetresToMiles = Metres * MetresToMilesMultiplier;
        }



        /// <Summary>
        /// Outputs the converted value now in Feet
        ///</Summary>
        private void MilesToFeet()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMilesToFeet + " feet");
            Console.WriteLine();

        }
        private void MilesToMetres()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMilesToMetres + " metres");
            Console.WriteLine();

        }
        private void FeetToMetres()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputFeetToMetres + " metres");
            Console.WriteLine();

        }
        private void FeetToMiles()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputFeetToMiles + " miles");
            Console.WriteLine();

        }
        private void MetresToFeet()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMetresToFeet + " feet");
            Console.WriteLine();

        }
        private void MetresToMiles()
        {
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMetresToMiles + " miles");
            Console.WriteLine();

        }

    }
}
