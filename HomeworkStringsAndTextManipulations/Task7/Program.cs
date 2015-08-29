using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader original = new StreamReader("Text.txt"))
            {
                string line = original.ReadLine();

                int lineNumber = 0;
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        StreamWriter even = new StreamWriter("Even.txt", true);
                        {
                          even.WriteLine(line);
                        } even.Close();
                    }
                    else
                    {
                        StreamWriter odd = new StreamWriter("Odd.txt", true);
                        {
                          odd.WriteLine(line);
                        } odd.Close();
                    }
                    line = original.ReadLine();
                }
            } 
        }
    }
}
