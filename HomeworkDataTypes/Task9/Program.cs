using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase or a number:");
            string a = Console.ReadLine();

            Console.WriteLine("Enter the position of the symbol:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("The symbol is: " + a[N]);
        }
    }
}
