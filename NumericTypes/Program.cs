using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width?");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("The area of this rectangle is " + area);
        }
    }
}
