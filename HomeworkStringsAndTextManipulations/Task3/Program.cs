using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("The word occurs " + CountString(text, word) + " time/s in the text.");
        }

        public static int CountString(string text, string word)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            return count;
        }
    }
}
