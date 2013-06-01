using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int i = 1;

        for (int row = n; row > 1; row--)
        {
            int dots = (row - 2);
            int asteriks = i;
            Console.Write(new String('.', dots));
            Console.Write(new String('*', asteriks));
            Console.Write(new String('.', dots));
            Console.WriteLine();
            i += 2;
        }

            int dots1 = (n - 2);
            int asteriks1 = 1;
            Console.Write(new String('.', dots1));
            Console.Write(new String('*', asteriks1));
            Console.Write(new String('.', dots1));
            Console.WriteLine();
                             
    }
}

