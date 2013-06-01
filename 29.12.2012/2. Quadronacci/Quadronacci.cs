using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Quadronacci
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int length = row * col;

        long[] arr = new long[length];

        arr[0] = a;
        arr[1] = b;
        arr[2] = c;
        arr[3] = d;

        for (int i = 4; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3] + arr[i - 4];
        }
        int count = 0;

        for (int r = 0; r < row; r++)
        {
            for (int cl = 0; cl < col; cl++)
            {
                if (count == (col - 1))
                {
                    Console.Write("{0}", arr[count]);
                }
                else
                {
                    Console.Write("{0} ", arr[count]);
                }

                count++;
            }
            Console.WriteLine();
        }    
    }
}

