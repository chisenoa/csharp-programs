using System;
using System.Collections.Generic;

namespace Chisenoa
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            int[] a;
            int size;

            Console.Write("Enter the size of array : ");

            size = int.Parse(Console.ReadLine());

            a = new int[size];

            Console.Write("\nEnter the elements of array : ");

            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nBefore Sorting, Elements of array is : \n");

            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }

            int temp = 0;

            for (int write = 0; write < size; write++)
            {
                for (int sort = 0; sort < size - 1; sort++)
                {
                    if (a[sort] < a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                }
            }

            Console.Write("\n\nAfter Sorting, Elements of array in descending order is : \n");

            for (int i = 0; i < size; i++)
                Console.Write(a[i] + " ");

            Console.ReadKey();
        }
    }
}