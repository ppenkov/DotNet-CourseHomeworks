using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile("Text.txt");


            Console.WriteLine("Enter the name of the file:");
            string name = Console.ReadLine() + ".txt";
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            WriteFile(name, word);
        }

        static void ReadFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = reader.ReadToEnd();
                Console.WriteLine(line);
            }
        }

        static void WriteFile(string filename2, string word)
        {
            using (StreamWriter writer = new StreamWriter(filename2))
            {
                writer.WriteLine(word);
            }
        }
    }
}
