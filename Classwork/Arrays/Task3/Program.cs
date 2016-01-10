using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[4, 4];

            for (int i = 0; i < myArray.GetLength(0); i++)
			{
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number:");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
			}

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (myArray[i,j] % 2 == 1)
                    {
                        myArray [i,j] = myArray[i, j] * 2;
                    }
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
