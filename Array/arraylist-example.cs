using System;
using System.Collections;

namespace Chisenoa
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            ArrayList.al = new ArrayList();

            al.Add("Java");
            al.Add("C");
            al.Add("C++");
            al.Add("php");

            Console.Write("Contents of ArrayList: ");

            foreach (String str in al)
            {
                Console.Write("\n" + str);
            }

            Console.ReadLine();
        }
    }
}
