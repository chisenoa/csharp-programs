using System;

namespace Chisenoa
{
    class MatrixAddition
    {
        static void Main(string[] args)
        {
            int m, n, i, j;

            Console.WriteLine("Enter number of rows and columns of the matrix : ");

            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[m, n];

            Console.WriteLine("Enter the First Matrix : ");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First Matrix : ");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int[,] B = new int[m, n];

            Console.WriteLine("Enter the Second Matrix : ");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Second Matrix : ");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int[,] C = new int[m, n];

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("Matrix Addition :");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}