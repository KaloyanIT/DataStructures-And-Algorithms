using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace _04.Permutations
{
    class StartUp
    {
        private static int level = -1;
        static void Print(int[] values, int size)
        {
            if (values.Length != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(values[i]);
                }
                Console.WriteLine();
            }
        }

        static void Permutate(int[] values, int n, int k)
        {
            level = level + 1;
            values[k] = level;

            if (level == n)
            {
                Print(values, n);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (values[i] == 0)
                    {
                        Permutate(values, n, i);
                    }
                }
            }

            level = level - 1;
            values[k] = 0;
        }

        static void Main(string[] args)
        {
            int n = 5;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = 0;
            }

            Permutate(numbers, n, 0);
        }
    }
}
