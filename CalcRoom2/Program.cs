﻿
//June 26th, 2023-Start 

using System;

namespace CalcRoom2  
{
    class CalcRoom
    {
        public static void Main()
            // Square room:
        //{
        //    Console.Write("Enter length of room in feet: ");
        //    double length = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Enter width of room in feet:");
        //    double width = Convert.ToDouble(Console.ReadLine());
        //    double area = length * width;
        //    Console.Write("Enter price of square feet: ");
        //    double price = Convert.ToDouble(Console.ReadLine());
        //    double cost = (length * width) * price;
        //    Console.WriteLine($"Floor is {area} square feet.");
        //    Console.WriteLine($"Cost for room is {cost} .");
        //    Console.ReadLine();
        //}
        // Circular room:
        {
            Console.Write("Enter diameter of room in feet: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;
            double radius = (diameter / 2);
            double area = radius * pi;
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