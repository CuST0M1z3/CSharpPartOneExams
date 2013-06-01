using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sheets
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int[] m = new int[11];

        List<string> k = new List<string>();

        m[10] = 1;
        for (int i = m.Length - 2; i >= 0; i--)
        {
            m[i] = m[i + 1] * 2;
        }
        int sum = n;

        for (int i = 0; i < m.Length; i++)
        {
            sum -= m[i];
            if (sum < 0)
            {
                k.Add('A' + "" + i);
                sum += m[i];
            }
            else if ((sum == 0) && (i < (m.Length - 1)))
            {
                continue;
            }
            else if ((sum == 0) && (i == (m.Length - 1)))
            {
                break;
            }
        }
        for (int i = 0; i < k.Count; i++)
        {
            Console.WriteLine(k[i]);
        }                                         
    }
}


