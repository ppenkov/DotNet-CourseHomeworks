using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 23, 56, 99, 104, 501};

            int[] myArray2 = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray2[i] = myArray[i];
                Console.WriteLine(myArray2[i]);
            }
        }
    }
}
