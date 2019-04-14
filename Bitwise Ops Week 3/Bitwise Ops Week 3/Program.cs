using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Ops_Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to an exercise in C# Bitwise Operators.");
            Console.WriteLine();
            // This program will take two integer inputs and use bitwise operators for output.
            Console.Write("Enter a number for x: ");
            string xInt = Console.ReadLine();
            int x = Convert.ToInt32(xInt);
            Console.Write("Enter a number for y: ");
            string yInt = Console.ReadLine();
            int y = Convert.ToInt32(yInt);
            int AND = x & y;
            // Compares two bits and generates a result of 1 if both bits are 1; otherwise, it returns 0.
            int inclOR = x | y;
            // Compares two bits and generates a result of 1 if the bits are complementary; otherwise, it returns 0.
            int exclOR = x ^ y;
            // Compares two bits and returns 1 if either of the bits are 1, otherwise, it returns 0.
            Console.WriteLine();
            Console.WriteLine($"The AND value of {xInt} and {yInt} is: {AND}");
            Console.WriteLine($"The inclusive OR value of {xInt} and {yInt} is: {inclOR}");
            Console.WriteLine($"The exclusive OR value of {xInt} and {yInt} is: {exclOR}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}