using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            for (int i = 1; ; i++)
            {
                Console.WriteLine("Enter a number:");
                int x = int.Parse(Console.ReadLine());
                y = x + y;
                
                Console.WriteLine(y);
                if (x == 0)
                {
                    break;
                }
            }
        }
    }
}
