using System;

namespace CalcRoom // area cost calculation.-average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr 
{
    class CalcRoom
    {
        public static void Main()
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
    }
}