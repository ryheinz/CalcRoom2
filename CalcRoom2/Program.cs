﻿
//June 26th, 2023-Start 

using System;


namespace CalcRoom2
{
    class CalcRoom
    {
        public static void Main()
        //user question to get room shape
        bool answerY = true;
        {
            Console.WriteLine("Welcome to the Room CALC2! ");
            Console.Write("Do you want to get cost for a square room? Please enter Y for Yes or N for No. ");
            bool answerY = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();
        }
        

        If(answerY = true)// Square room:

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
        Else(answerY = false)
        // Circular room:
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
        //average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr

    }

}