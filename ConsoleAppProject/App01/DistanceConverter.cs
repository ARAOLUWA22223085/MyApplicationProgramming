using System;
using System.Threading;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The app will prompt the user to choose from a range of possible conversion between 
    /// metres, feet and miles and will provide converted distance values for the selected choice.
    /// </summary>
    /// <author>
    /// Araoluwa  version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const double MilesToFeetMultiplier = 5280;
        public const double MilesToMetresMultiplier = 1609.34;
        public const double FeetToMilesMultiplier = 0.000189394;
        public const double FeetToMetresMultiplier = 0.3048;
        public const double MetresToFeetMultiplier = 3.28084;
        public const double MetresToMilesMultiplier = 0.000621371;

        private double conversion = 0;

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

            string Conversion = Console.ReadLine();
            conversion = Convert.ToDouble(Conversion);
            Thread.Sleep(1000);

            if (conversion == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Miles to Feet");
                Console.WriteLine();
                InputMiles();
                CalculateMilesToFeet();
                MilesToFeet();
            }

            else if (conversion == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Miles to Metres");
                Console.WriteLine();
                InputMiles();
                CalculateMilesToMetres();
                MilesToMetres();
            }

            else if (conversion == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Feet to Miles");
                Console.WriteLine();
                InputFeet();
                CalculateFeetToMiles();
                FeetToMiles();
            }

            else if (conversion == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Feet to Metres");
                Console.WriteLine();
                InputFeet();
                CalculateFeetToMetres();
                FeetToMetres();
            }

            else if (conversion == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Metres to Feet");
                Console.WriteLine();
                InputMetres();
                CalculateMetresToFeet();
                MetresToFeet();
            }

            else if (conversion == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Metres to Miles");
                Console.WriteLine();
                InputMetres();
                CalculateMetresToMiles();
                MetresToMiles();
            }


            else if (conversion == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Converting Metres to Miles");
                Console.WriteLine();
                InputMetres();
                CalculateMetresToMiles();
                MetresToMiles();
            }
            else
            {
                Console.WriteLine("Please input a valid number!");
                Thread.Sleep(1500);
                ConversionType();

            }
        }

        /// <Summary>
        /// Prompts user for Input value in specified unit
        /// Input value for unit as a double number
        ///</Summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of Miles > ");
            string miles = Console.ReadLine();
            Miles = Convert.ToDouble(miles);
        }

        private void InputMetres()
        {
            Console.Write("Please enter the number of Metres > ");
            string metres = Console.ReadLine();
            Metres = Convert.ToDouble(metres);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of Feet > ");
            string feet = Console.ReadLine();
            Feet = Convert.ToDouble(feet);
        }
        
        /// <summary>
        /// Manages the conversion between various units
        /// by applying multipliers defined at the top
        /// </summary>
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
        /// Outputs the converted value in the target unit of measurement
        ///</Summary>
        private void MilesToFeet()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMilesToFeet + " feet");
            Console.WriteLine();
            Console.WriteLine();

        }
        private void MilesToMetres()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMilesToMetres + " metres");
            Console.WriteLine();
            Console.WriteLine();

        }
        private void FeetToMetres()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputFeetToMetres + " metres");
            Console.WriteLine();
            Console.WriteLine();

        }
        private void FeetToMiles()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputFeetToMiles + " miles");
            Console.WriteLine();
            Console.WriteLine();

        }
        private void MetresToFeet()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMetresToFeet + " feet");
            Console.WriteLine();
            Console.WriteLine();


        }
        private void MetresToMiles()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("The converted Length is; ");
            Console.Write(OutputMetresToMiles + " miles");
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}
