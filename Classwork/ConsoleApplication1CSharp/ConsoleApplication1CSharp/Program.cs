using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x<=5)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("The number is even!");
                }
                else
                {
                    Console.WriteLine("The number is odd!");
                }
            }
            else if (x >= 6 && x <= 15)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                if (x >= 0)
                {
                    Console.WriteLine("The nuber is out of range and is positive!");
                }
                else if (x <= 0)
                {
                    Console.WriteLine("The number is out of the range and is negative!");
                }
                else if (x == 0)
                {
                    Console.WriteLine("The number is null!");
                }
            }
        }
    }
}
