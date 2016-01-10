using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            int count = 0;
            int currentIndex = 0;
            Console.WriteLine();

            if (n > 0 && n <= 100)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                } Console.WriteLine();

                for (int i = 0; i < myArray.Length; i++)
                {       
                    if (myArray[i] == myArray[currentIndex])
                    {
                        count++;
                    }
                    if (n == 1)
                    {
                        currentIndex = i;
                        count = 1;
                    }
                }
                Console.WriteLine("Most frequent number is " + myArray[currentIndex] + " and occurs " + count + " times.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Enter valid or lower length!");
                Console.WriteLine();
            }
        }
    }
}
