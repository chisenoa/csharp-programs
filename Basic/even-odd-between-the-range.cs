using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class EvenOddBetweeentheRange
    {
        static void Main(string[] args)
        {
            int start_range, end_range, i;

            Console.Write("Even and odd numbers between the given Range ");

            Console.Write("\nEnter the start value of the range ");

            start_range = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the end value of the range ");

            end_range = int.Parse(Console.ReadLine());

            Console.Write("\nEven Numbers between the range " + start_range + " - " + end_range + " are \n");

            for (i = start_range; i <= end_range; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.Write("\n\nOdd Numbers between the range " + start_range + " - " + end_range + " are \n");

            for (i = start_range; i <= end_range; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.Read();
        }
    }
}