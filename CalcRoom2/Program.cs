﻿
//June 26th, 2023-Start 
//average flooring team can only put in 20
//square feet of flooring per hour at a cost of $86.00/hr

using System;

namespace CalcRoom2
{
    class CalcRoom
    {
        public static void Main()//user question to get room shape
        {  
            Console.Write("Welcome to the Room CALC2! ");
            Console.Write("Which room shape you wanna calculate. Enter R (ectangle) or C (ircle) ");
            string roomShape = Console.ReadLine();


            if (roomShape == "R")// Square room:
            {
                Console.Write("Enter length of room in feet: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter width of room in feet:");
                double width = Convert.ToDouble(Console.ReadLine());
                double area = length * width;

                Console.Write("Enter price of square feet: ");
                double price = Convert.ToDouble(Console.ReadLine());
                double cost = (length * width) * price;

                Console.WriteLine($"Floor is {area} square feet.");
                Console.WriteLine($"Cost for room is {cost} .");
                Console.ReadLine();

            }
            if (roomShape == "C") // Circular room:
            {
                Console.Write("Enter diameter of room in feet: ");
                double diameter = Convert.ToDouble(Console.ReadLine());
                double radius = (diameter / 2);
                double area = Math.Round(radius * Math.PI, 2);

                Console.Write("Enter price of square feet: ");
                double price = Convert.ToDouble(Console.ReadLine());
                double cost = area * price;

                Console.WriteLine($"Floor is {area} square feet.");
                Console.WriteLine($"Cost for room is {cost}.");
                Console.ReadLine();
            }


        }
    }

}