using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int number1, number2, sum;

            Console.Write("Enter first number : ");

            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter second number : ");

            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.Write("\nSum of the 2 numbers is : " + sum);

            Console.ReadLine();
        }
    }
}