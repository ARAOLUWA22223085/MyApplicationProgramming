﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Araoluwa Olatunji 24/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine();
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine();

            double Selection = Convert.ToDouble(Console.ReadLine());

            DistanceConverter converter = new DistanceConverter();
            BMICalculator bmi = new BMICalculator();


            if (Selection == 1)
            {
                converter.Run();
            }

            else if (Selection == 2)
            {
                bmi.Run();
            }
            
            else
            {
                Console.WriteLine("Please input a valid instruction!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }

        }
    }
}
