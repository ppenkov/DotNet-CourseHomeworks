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
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Print(name);
        }
        private static void Print(string name)
        {
            Console.WriteLine("Greetings, " + name + "!");
        }
    }
}
