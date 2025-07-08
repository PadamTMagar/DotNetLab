using System;

namespace DotNetLab
{
    public class Lab1q11
    {
        public static void Run()
        {
            Console.WriteLine("Enter dimensions for Matrix A (rows and columns):");
            int rowsA = Convert.ToInt32(Console.ReadLine());
            int colsA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter dimensions for Matrix B (rows and columns):");
            int rowsB = Convert.ToInt32(Console.ReadLine());
            int colsB = Convert.ToInt32(Console.ReadLine());

            // Check if multiplication is possible
            if (colsA != rowsB)
            {
                Console.WriteLine("Matrix multiplication not possible. Columns of A must equal rows of B.");
                return;
            }

            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsB, colsB];
            int[,] result = new int[rowsA, colsB];

            Console.WriteLine("Enter elements for Matrix A:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for Matrix B:");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Matrix multiplication
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            // Print the result
            Console.WriteLine("Result of Matrix Multiplication:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
