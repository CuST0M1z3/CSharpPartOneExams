using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstDots = 0;
        int centerDots = 0;
        int slash = 1;
        int backslash = 1;
        int forwardslash = 1;

        int len = (n / 2) - 1;

        for (int i = 0; i < n/2; i++)
        {
            firstDots = i;
            centerDots = len;

            Console.Write(new String('.', firstDots));
            Console.Write(new String('\\',backslash));
            Console.Write(new String('.', centerDots));
            Console.Write(new String('|', slash));
            Console.Write(new String('.', centerDots));
            Console.Write(new String('/', forwardslash));
            Console.Write(new String('.', firstDots));
            Console.WriteLine();

            len--;
        }

        int dash = n / 2;
        int star = 1;

        Console.Write(new String('-', dash));
        Console.Write(new String('*', star));
        Console.Write(new String('-', dash));
        Console.WriteLine();

        len = 0;
        for (int i = (n/2 - 1); i >= 0; i--)
        {
            firstDots = i;
            centerDots = len;

            Console.Write(new String('.', firstDots));
            Console.Write(new String('/', forwardslash));            
            Console.Write(new String('.', centerDots));
            Console.Write(new String('|', slash));
            Console.Write(new String('.', centerDots));
            Console.Write(new String('\\', backslash));
            Console.Write(new String('.', firstDots));
            Console.WriteLine();

            len++;
        }

    }
}

