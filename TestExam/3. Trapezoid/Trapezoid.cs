using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = n;
        int asteriks = n;
        Console.Write(new String('.', dots));
        Console.Write(new String('*', asteriks));
        Console.WriteLine();

        int firstDots = 0;
        int secondDots = 0;
        int innerAsteriks = 1;
        int dot = n - 2;

        for (int row = n - 1; row > 0; row--)
        {
            dot++;
            if (row == n - 1)
            {
                firstDots = row;
                secondDots = row;
                Console.Write(new String('.', firstDots));
                Console.Write(new String('*', innerAsteriks));
                Console.Write(new String('.', secondDots));
                Console.Write(new String('*', innerAsteriks));
                Console.WriteLine();
            }
            else
            {
                firstDots = row;                
                Console.Write(new String('.', firstDots));
                Console.Write(new String('*', innerAsteriks));
                Console.Write(new String('.', dot));
                Console.Write(new String('*', innerAsteriks));
                Console.WriteLine();
            }            
        }

        int finalAsteriks = n * 2;
        Console.Write(new String('*', finalAsteriks));
        Console.WriteLine();
    }
}

