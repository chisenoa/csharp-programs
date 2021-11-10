using System;

namespace Chisenoa
{
    class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSum: " + (a + b));
            Console.WriteLine("Difference: " + (a - b));
            Console.WriteLine("Product: " + (a * b));
            Console.WriteLine("Quotient: " + (a / b));
            Console.WriteLine("Integer Quotient: " + (a / b));
            Console.WriteLine("Remainder: " + (a % b));
            Console.WriteLine("Exponent: " + Math.Pow(a, b));

            Console.Read();
        }
    }
}
