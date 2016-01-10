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
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine(sentence.StartsWith("John"));
            Console.WriteLine(sentence.EndsWith("!"));
            Console.WriteLine(sentence.Contains("party"));
        }
    }
}
