using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you consumed?");
            int gallons = int.Parse(Console.ReadLine());
            int milesPerGallon = miles / gallons;
            Console.WriteLine("Your miles per gallon is " + milesPerGallon);
        }
    }
}
