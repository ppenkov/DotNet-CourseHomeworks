using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.Write("Enter a number: ");
            int A = int.Parse(Console.ReadLine());
            int[] array = new int[100];
            int i;

            for (i = 1; i <= A; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Permutations:");
            Permutate(1, A, array);
        }
        
        static void Permutate(int k, int n, int[] nums)
        {
            int i, j, tmp;
            if (k <= n)
            {
                for (i = k; i <= n; i++)
                {
                    tmp = nums[i];
                    for (j = i; j > k; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[k] = tmp;
                    Permutate(k + 1, n, nums);
                    for (j = k; j < i; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[i] = tmp;
                }
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", nums[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
