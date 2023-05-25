// C# program to demonstrate the working
// of Binary Arithmetic Operators
using System;
namespace Arithmetic
{
    class GFG
    {

        // Main Function
        static void Main(string[] args)
        {

            int result;
            int x = 29, y = 14;

            // Addition
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);

            // Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);

            // Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            // Division
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);

            // Modulo
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
        }
    }
}