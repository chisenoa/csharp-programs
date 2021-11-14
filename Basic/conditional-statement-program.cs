using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class ConditionalStatementProgram
    {
        static void Main()
        {
            int number;

            number = 0;

            if (number == 0)
            {
                Console.WriteLine("The number is 0");
            }

            if (number < 0)
            {
                Console.WriteLine("The number is less than 0");
            }
            else
            {
                Console.WriteLine("The number is greater than or equal to 0");
            }

            if (number < 0)
            {
                Console.WriteLine("The number is less than 0");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number is greater than 0");
            }
            else
            {
                Console.WriteLine("The number is 0");
            }

            Console.ReadKey();

        }
    }
}