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
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            string text2 = text.Replace(word, word.ToUpper());

            Console.WriteLine(text2);

        }
    }
}
