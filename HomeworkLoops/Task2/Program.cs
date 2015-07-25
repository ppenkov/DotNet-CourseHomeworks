using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int A = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= A; counter++)
            {
                if (counter % 3 == 0 && counter % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }
        }
    }
}
