using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase:");
            string a = Console.ReadLine();

            Console.WriteLine("Enter a phrase:");
            string b = Console.ReadLine();

            bool result = (a.Contains(b));
            Console.WriteLine(result);
        }
    }
}
