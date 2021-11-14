using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class SwitchCaseProgram
    {
        static void Main(string[] args)
        {

            int option = 3;
            switch (option)
            {
                case 0:
                    Console.WriteLine("Case 0");

                    break;
                case 1:
                    Console.WriteLine("Case 1");

                    break;
                case 2:
                    Console.WriteLine("Case 2");

                    break;

                case 4 - 1:
                    Console.WriteLine("Case 3");

                    break;

                default:
                    Console.WriteLine("Default case (optional)");

                    break;
            }

            Console.ReadKey();
        }
    }
}