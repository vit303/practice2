using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list = ReverseOutput.Output(6);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}   ");
            }
            Console.WriteLine();

            Square square = new Square();
            int rows = 6;
            int columns = 7;
            List<List<int>> spiralMatrix = square.CreateSpiralMatrix(rows, columns);
            square.PrintMatrix(spiralMatrix);

            Pyramid square2 = new Pyramid();
            square2.Print(5);
        }
    }
}
