using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class TwoDimensionalArray
    {
        static void Main(string[] args)
        {
            int[,] array;
            int row, column;

            Console.WriteLine("Enter the row value : ");

            row = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the column value : ");

            column = int.Parse(Console.ReadLine());

            array = new int[row, column];

            Console.WriteLine("\nEnter the elements of 2d array : ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe elements of 2d array are : ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}