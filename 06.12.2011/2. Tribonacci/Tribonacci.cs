using System;
using System.Numerics;


class Tribonacci
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());

        BigInteger[] numbers = new BigInteger[n];
       

        BigInteger result = 0;

        if (n == 1)
        {
            Console.WriteLine(t1);
        }
        else if (n == 2)
        {
            Console.WriteLine(t2);
        }
        else if (n == 3)
        {
            Console.WriteLine(t3);
        }
        else
        {
            numbers[0] = t1;
            numbers[1] = t2;
            numbers[2] = t3;

            for (int i = 3; i < n; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
                if (i == (n - 1))
                {
                    result = numbers[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
