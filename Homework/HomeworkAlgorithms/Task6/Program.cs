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
            string text = "It has no physical location, or even office, no paid staff or editors, but books in the Original Series are published in the first place to satisfy subscriptions paid by individuals or institutions.";
            Console.WriteLine("The text is:");
            Console.WriteLine();
            Console.WriteLine(text);

            char[] marks = new char[] { '.', ',', '-', '!', '?', '(', ')', '"', ';', ':' };
            string newText = "";
            string[] tempText = text.Split(marks);

            for (int i = 0; i < tempText.Length; i++)
            {
                newText += tempText[i];
            } text = newText;

            string[] words = text.Split(' ');

            Array.Sort<string>(words);

            Console.WriteLine();
            Console.WriteLine("The words in alphabetical order are:");

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            } 
        }
    }
}
