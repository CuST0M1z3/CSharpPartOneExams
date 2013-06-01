using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        List<int> m = new List<int>();

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            long nextNum = long.Parse(Console.ReadLine());            
            bool oneFound = false;
            count = 0;
            for (int bitNum = 31; bitNum >= 0; bitNum--)
            {
                
                long bitValue = (nextNum >> bitNum) & 1;
                if (bitValue == 1)
                {
                    oneFound = true;
                }
                if (oneFound)
                {
                    if (bitValue == b)
                    {
                        count++;
                    }                    
                }                               
            }
            m.Add(count);
        }
        foreach (var num in m)
        {
            Console.WriteLine(num);
        }

    }
}

