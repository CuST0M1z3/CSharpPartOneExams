using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShipDamage
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());

        int minX = Math.Min(sx1, sx2);
        int maxX = Math.Max(sx1, sx2);
        int minY = Math.Min(sy1, sy2);
        int maxY = Math.Max(sy1, sy2);

        int damagec1 = 0;
        int damagec2 = 0;
        int damagec3 = 0;

        int hcy1 = h - cy1;
        int hitcy1 = h + hcy1;

        int hcy2 = h - cy2;
        int hitcy2 = h + hcy2;

        int hcy3 = h - cy3;
        int hitcy3 = h + hcy3;


        if ((hitcy3 == minY && cx3 == maxX) || (hitcy3 == minY && cx3 == minX) || (hitcy3 == maxY && cx3 == maxX) || (hitcy3 == maxY && cx3 == minX))
        {
            damagec3 += 25;
        }
        if ((hitcy2 == minY && cx2 == maxX) || (hitcy2 == minY && cx2 == minX) || (hitcy2 == maxY && cx2 == maxX) || (hitcy2 == maxY && cx2 == minX))
        {
            damagec2 += 25;
        }
        if ((hitcy1 == minY && cx1 == maxX) || (hitcy1 == minY && cx1 == minX) || (hitcy1 == maxY && cx1 == maxX) || (hitcy1 == maxY && cx1 == minX))
        {
            damagec1 += 25;
        }

        if (cx1 > minX && cx1 < maxX && hitcy1 < maxY && hitcy1 > minY)
        {
            damagec1 += 100;
        }
        if (cx2 > minX && cx2 < maxX && hitcy2 < maxY && hitcy2 > minY)
        {
            damagec2 += 100;
        }
        if (cx3 > minX && cx3 < maxX && hitcy3 < maxY && hitcy3 > minY)
        {
            damagec3 += 100;
        }

        if ((hitcy1 == minY && cx1 < maxX && cx1 > minX) || (hitcy1 == maxY && cx1 < maxX && cx1 > minX) || (hitcy1 == maxX && cx1 < maxY && cx1 > minY) || (hitcy1 == minX && cx1 < maxY && cx1 > minY))
        {
            damagec1 += 50;
        }
        if ((hitcy2 == minY && cx2 < maxX && cx2 > minX) || (hitcy2 == maxY && cx2 < maxX && cx2 > minX) || (hitcy2 == maxX && cx2 < maxY && cx2 > minY) || (hitcy2 == minX && cx2 < maxY && cx2 > minY))
        {
            damagec2 += 50;
        }
        if ((hitcy3 == minY && cx3 < maxX && cx3 > minX) || (hitcy3 == maxY && cx3 < maxX && cx3 > minX) || (hitcy3 == maxX && cx3 < maxY && cx3 > minY) || (hitcy3 == minX && cx3 < maxY && cx3 > minY))
        {
            damagec3 += 50;
        }

        Console.WriteLine(damagec1 + damagec2 + damagec3 + "" + '%');

    }
}

