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
            Console.WriteLine("Enter a number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number:");
            int b = int.Parse(Console.ReadLine());

            double result = a / b;
            Console.WriteLine("The result of the partition is: " + result);
        }
    }
}
