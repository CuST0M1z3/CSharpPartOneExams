using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] m = new int[n];

        int[] cats = new int[11];

        for (int i = 0; i < n; i++)
        {
            m[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < m.Length; i++)
        {
            cats[m[i]]++;
        }

        int max = 0;
        int maxKey = 1;
        for (var i = 1; i < cats.Length; i++)
        {
            if (cats[i] > max)
            {
                max = cats[i];
                maxKey = i;
            }
            if (cats[i] == max && i < maxKey)
            {
                max = cats[i];
                maxKey = i;
            }
        }
        Console.WriteLine(maxKey);
    }
}

