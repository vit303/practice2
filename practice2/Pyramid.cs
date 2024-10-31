using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class Pyramid
    {
        public void Print(int N)
        {
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == 1 || i == 2)
                    {
                        array[i, j] = 1;
                    }
                    if (j <= i - 2)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = 1;
                    }

                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
