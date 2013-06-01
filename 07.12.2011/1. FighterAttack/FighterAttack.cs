using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FighterAttack
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());
        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int maxX = Math.Max(pX1, pX2);
        int maxY = Math.Max(pY1, pY2);
        int minX = Math.Min(pX1, pX2);
        int minY = Math.Min(pY1, pY2);

        int hitX = fX + d;

        int damage = 0;

        if (hitX >= minX && hitX <= maxX && fY <= maxY && fY >= minY)
        {
            damage += 100;
        }
        if ((hitX + 1) >= minX && (hitX + 1) <= maxX && fY <= maxY && fY >= minY)
        {
            damage += 75;
        }
        if (hitX >= minX && hitX <= maxX && (fY + 1) <= maxY && (fY + 1) >= minY)
        {
            damage += 50;
        }
        if (hitX >= minX && hitX <= maxX && (fY - 1) <= maxY && (fY - 1) >= minY)
        {
            damage += 50;
        }
        
        Console.WriteLine(damage + "" + "%");
    }
}

