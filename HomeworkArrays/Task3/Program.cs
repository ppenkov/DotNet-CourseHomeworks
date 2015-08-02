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
            int[] N = new int[10];
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = i * 10;
            }
            foreach (int item in N)
            {
                Console.WriteLine(item);
            }  
        }
    }
}
