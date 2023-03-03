using System;
using System.Threading;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// An application that requests fo the user an input for their weight in two types of units
    /// and based on the input is able to inform them of their BMI as well as what that woulld class
    /// as in terms of what that measn for their state.
    /// </summary>
    /// <author>
    /// Araoluwa Olatunji version 0.1
    /// </author>
    public class BMICalculator
    {
        public double bmi;

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("welcome to Ara's advanced BMI calculator!");
            Console.WriteLine();

            //request the unit the user would like to use to input a weight into the system
            Console.WriteLine();
            Console.WriteLine("Please select The weight you would like to use");
            Console.WriteLine("1. Imperial (lbs and Inches)");
            Console.WriteLine("2. Metric (Kg and Metres)");
            Console.WriteLine();

            double Units = Convert.ToDouble(Console.ReadLine());

            if (Units == 1) 
            {
                Console.WriteLine();
                Console.WriteLine("You have selected Imperial Units!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Imperial();
            }

            else if (Units == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You have selected Metric Units!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Metric();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Please Input a valid instruction!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Run();
            }
        
        }

        private void Imperial()
        {
            Console.WriteLine();
            Console.WriteLine("Please input your Weight in lbs");
            double WeightLbs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please input your Height in Inches");
            double HeightInches = Convert.ToDouble(Console.ReadLine());

            double BMI = WeightLbs / (HeightInches * HeightInches) * 703;
            bmi = Convert.ToDouble(BMI);

            Console.WriteLine("Your BMI is " + BMI + ".");
/*            BMIIndicator();
*/            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Run();
        }

        private void Metric()
        {
            Console.WriteLine();
            Console.WriteLine("Please input your Weight in Kg");
            double WeightKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input your Height in M");
            double HeightM = Convert.ToDouble(Console.ReadLine());

            double BMI = WeightKg / (HeightM * HeightM);

            Console.WriteLine("Your BMI is " + BMI + ".");
/*            BMIIndicator();
*/            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Run();
        }
/*        private void BMIIndicator()
        {
            if (bmi > 30)
            {
                Console.WriteLine("you're in the obese range");
            }

            else if (30 > bmi)
            {
                Console.WriteLine("you're in the overweight range");
            }

            else if (24.9 > bmi)
            {
                Console.WriteLine("you're in the healthy weight range");
            }

            else if(18.5 > bmi)
            {
                Console.WriteLine("you're in the underweight range");
            }
        }*/
    }
}
