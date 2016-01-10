using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix:");
            int x = int.Parse(Console.ReadLine());
            int[,] matrix = new int[x, x];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Version 1 of the matrix:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("   " + matrix[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Version 2 of the matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("   " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
