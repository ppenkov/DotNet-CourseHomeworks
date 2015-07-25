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
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Enter how much numbers you want to compare:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter a number: ");
                int b = int.Parse(Console.ReadLine());

                if (b < min)
                {
                    min = b;                    
                }

                if (b > max)
                {
                    max = b;
                }
            }
            Console.WriteLine("The highest number is: " + max);
            Console.WriteLine("The lowest number is: " + min);
        }
    }
}
