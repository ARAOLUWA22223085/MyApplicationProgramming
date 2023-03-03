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
    public class BMI
    {

        public void run()
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
                run();
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

            Console.WriteLine("Your BMI is " + BMI + ".");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            run();
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            run();
        }

    }
}
