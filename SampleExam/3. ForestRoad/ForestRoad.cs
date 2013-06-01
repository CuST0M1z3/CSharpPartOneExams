using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = (2 * n - 1);

        for (int row = 0; row < ((2*n)/2); row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int row = ((2 * n) / 2) - 1; row > 0; row--)
        {
            for (int col = 1; col <= n; col++)
            {
                if (row == col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

    }
}

