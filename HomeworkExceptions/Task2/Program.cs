using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FinishLine();
            }
            catch (SentenceNotCompletedException)
            {
                Console.WriteLine("The text is not correctly written. Check the punctuation!");
            }

            finally
            {
                Console.WriteLine("Exception handling passed!");
            }
        }

        static void FinishLine()
        {
            using (StreamReader text = new StreamReader("Text.txt"))
            {
                int lineNumber = 0;
                bool symbol = false;
                string line = text.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    if (line.LastIndexOf('.') == line.Length - 1)
                    {
                        symbol = true;
                        line = text.ReadLine();
                        continue;
                    }
                    else if (line.LastIndexOf('?') == line.Length - 1)
                    {
                        symbol = true;
                        line = text.ReadLine();
                        continue;
                    }
                    else if (line.LastIndexOf('!') == line.Length - 1)
                    {
                        symbol = true;
                        line = text.ReadLine();
                        continue;
                    }
                    else
                    {
                        symbol = false;
                        break;
                    }
                }

                if (symbol == true)
                {
                    Console.WriteLine("The punctuation of the text is correct!");
                }
                else
                {
                    throw new SentenceNotCompletedException();
                }
            }
        }
    }
}