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
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            string[] split = text.Split('.');

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Contains(word))
                {
                    Console.Write(split[i] + ".");
                }
            } Console.WriteLine();
        }
    }
}
