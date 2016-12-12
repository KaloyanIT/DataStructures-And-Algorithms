using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRecursion
{
    class Program
    {
        static void Rec(int stepsLeft)
        {
            //Tree!!!!!
            if (stepsLeft == 0)
            {
                return;
            }
            Console.WriteLine("Calling Rec() at step {0}", stepsLeft);
            Rec(stepsLeft - 1);
            Console.WriteLine("Between calls at step {0}", stepsLeft);
            Rec(stepsLeft - 1);
            Console.WriteLine("Exiting Rec() at step {0}", stepsLeft);
        }

        static long Factotial(int n)
        {
            // F(5) = 5 * (4 * (3 * (2 *(1 * F(0)))));
            if (n == 0)
            {
                return 1;
            }
            return n * Factotial(n - 1);
        }

        static void BinaryVectors(int n, string vector = "")
        {
            if (n == 0)
            {
                Console.WriteLine(vector);
                return;
            }
           
            BinaryVectors(n - 1, vector + "0");
            BinaryVectors(n - 1, vector + "1");
        }

        static long Queens(int n, bool[,] table)
        {
            if (n == 0)
            {
                return 1;
            }
            long total = 0;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    bool canPlaceQueen = true;
                    //check
                    int[] dx = {1, -1, 0, 0, 1, 1, -1, -1};
                    int[] dy = {0, 0, 1, -1, -1, 1, -1, 1};

                    for (int di = 0; canPlaceQueen && di < dx.Length; di++)
                    {
                        int x = i;
                        int y = j;
                        while (x >= 0 && x < table.GetLength(0) && y >= 0 && y < table.GetLength(1))
                        {
                            if (table[x, y])
                            {
                                canPlaceQueen = false;
                                break;
                            }

                            x += dx[di];
                            y += dy[di];
                        }
                    }

                    if (canPlaceQueen)
                    {
                        table[i, j] = true;
                        total += Queens(n - 1, table);
                        table[i, j] = false;
                    }
                }
            }

            return total;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello before");
            //Rec(3);
            //Console.WriteLine("Hello after");
            //Console.WriteLine(Factotial(6));
            //BinaryVectors(5);
            Console.WriteLine(Queens(8, new bool[8,8]));
        }
    }
}
