using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class Program
    {
        public static void Main()
        {
            List<string> names = new List<string>();
            names.Add("Ram");
            names.Add("Rose");
            names.Add("Abs");
            names.Add("Edward");
            names.Add("Sita");

            Console.WriteLine("Array without sorting..");

            foreach (string s in names)
                Console.WriteLine(s);

            names.Sort();

            Console.WriteLine("\nArray after sorting..");

            foreach (string s in names)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}