using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TribonacciTriangle
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        int l = int.Parse(Console.ReadLine());

        int length = 0;

        for (int i = l; i > 0; i--)
        {
            length += i;
        }


        long[] arr = new long[length];

        arr[0] = a;
        arr[1] = b;
        arr[2] = c;

        for (int i = 3; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];

        }
        int count = 0;
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (count == (arr.Length - 1))
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

