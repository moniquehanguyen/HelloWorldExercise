﻿using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you consumed?");
            int gallons = Convert.ToInt32(Console.ReadLine());
            int milesPerGallon = miles / gallons;
            Console.WriteLine("Your miles per gallon is " + milesPerGallon);
        }
    }
}
