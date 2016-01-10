using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mathemathical expression with brackets: ");
            string expression = Console.ReadLine();
            bool brackets = true;
            int open = 0;
            int close = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char bracket = expression[i];

                if (bracket == '(')
                {
                    open++;
                }
                else if (bracket == ')')
                {
                    close++;

                    if (close > open)
                    {
                        brackets = false;
                        break;
                    }
                }
                else if (bracket == expression.Length - 1 && (close == open))
                {
                    brackets = true;
                }
            }
            Console.WriteLine("Is the expression correct? " + brackets);
        }
    }
}
