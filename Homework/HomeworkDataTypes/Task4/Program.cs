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
            Console.WriteLine("Enter side A of the rectangle:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side B of the rectangle:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the rectangle is: " + (a * b));
        }
    }
}
