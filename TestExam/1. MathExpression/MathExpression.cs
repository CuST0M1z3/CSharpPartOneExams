using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class MathExpression
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double resultOne = n * n;
        double resultTwo = 1.0/(m*p);
        double resultThree = 128.523123123 * p;
        double resultFour = n - resultThree;

        double finalResult = 0;

        finalResult = ((resultOne + resultTwo + 1337.0) / resultFour) + (Math.Sin((int)m % 180));

        Console.WriteLine("{0:F6}", finalResult);

    }
}

