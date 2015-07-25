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
            Console.WriteLine("Enter a phrase:");
            string a = Console.ReadLine();
            
            Console.WriteLine("Enter a phrase:");
            string b = Console.ReadLine();
            
            string result = (a + "|" + b);
            Console.WriteLine(result);
        }
    }
}
