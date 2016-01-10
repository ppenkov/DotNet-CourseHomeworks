using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 to 9:");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 0: Console.WriteLine("Нула"); break;
                case 1: Console.WriteLine("Едно"); break;
                case 2: Console.WriteLine("Две"); break;
                case 3: Console.WriteLine("Три"); break;
                case 4: Console.WriteLine("Четири"); break;
                case 5: Console.WriteLine("Пет"); break;
                case 6: Console.WriteLine("Шест"); break;
                case 7: Console.WriteLine("Седем"); break;
                case 8: Console.WriteLine("Осем"); break;
                case 9: Console.WriteLine("Девет"); break;

                default: Console.WriteLine("Числото не е в посочения интервал!");
                    break;
            }
        }
    }
}
