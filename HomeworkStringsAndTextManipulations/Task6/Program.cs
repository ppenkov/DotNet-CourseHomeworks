using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader original = new StreamReader("Text.txt"))
            {
                string text = original.ReadToEnd();

                using (StreamWriter copy = new StreamWriter("Text2.txt"))
                {
                    char[] mark = new char[] { '.', ',', '-', '!', '?', '(', ')', '"', ';', ':' };

                    string[] split = text.Split(mark);

                    for (int i = 0; i < split.Length; i++)
                    {
                        copy.Write(split[i]);
                    } 
                }
            } 
        }
    }
}
