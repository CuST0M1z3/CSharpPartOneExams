using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asteriks = n;
        int dots = 0;

        for (int row = 0; row < (n/2 + 1); row++)
        {
            dots = row;

            Console.Write(new String('.', dots));
            Console.Write(new String('*', asteriks));
            Console.Write(new String('.', dots));
            Console.WriteLine();
            asteriks -= 2;
        }
        asteriks = 3;
        for (int row = (n/2 - 1); row >= 0; row--)
        {
            dots = row;

            Console.Write(new String('.', dots));
            Console.Write(new String('*', asteriks));
            Console.Write(new String('.', dots));
            Console.WriteLine();
            asteriks += 2;
        }
    }
}

