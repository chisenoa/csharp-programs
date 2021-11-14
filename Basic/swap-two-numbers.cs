using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;

            Console.Write("Enter first number : ");

            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter second number : ");

            number2 = int.Parse(Console.ReadLine());

            Console.Write("\nBefore Swapping :");
            Console.Write("\nFirst Number = " + number1 + "\nSecond Number = " + number2);

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("\n\nAfter Swapping : ");
            Console.Write("\nFirst Number = " + number1 + "\nSecond Number = " + number2);

            Console.ReadLine();
        }
    }
}