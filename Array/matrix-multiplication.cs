using System;

namespace Chisenoa
{
    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            int i, j, row, col;

            Console.WriteLine("Enter the Number of Rows and Columns for First Matrix : ");

            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[row, col];

            Console.WriteLine("Enter the First Matrix : ");

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First matrix :");

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the Number of Rows and Columns for Second Matrix : ");

            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] b = new int[m, n];

            Console.WriteLine("Enter the Second Matrix : ");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Second Matrix :");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Matrix Multiplication :");

            int[,] c = new int[row, n];
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}