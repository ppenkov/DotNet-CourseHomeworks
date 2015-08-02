using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int c = int.Parse(Console.ReadLine());

            Check(a, b, c);
        }
        private static void Check(int a, int b, int c)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("The first number is even!");
            }
            else
            {
                Console.WriteLine("The first number is odd!");
            }
            if (b % 2 == 0)
            {
                Console.WriteLine("The second number is even!");
            }
            else
            {
                Console.WriteLine("The second number is odd!");
            }
            if (c % 2 == 0)
            {
                Console.WriteLine("The third number is even!");
            }
            else
            {
                Console.WriteLine("The third number is odd!");
            }
        }
    }
}