using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 14;
            int[] numbers = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };

            bool[] checkSum = new bool[s + 1];
            int checker = int.MinValue;
            foreach (int item in numbers)
            {
                if (item > s)
                {
                    continue;
                }
                checkSum[item] = true;
                for (int i = 0; i < checkSum.Length; i++)
                {            
                    if (checkSum [i] == true && checker !=i)
                    {
                        checkSum[i + item] = true;
                        checker = i + item;
                    }
                }
                checkSum[item] = true;
            }
        }
    }
}
