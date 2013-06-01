using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());


        DateTime time = new DateTime(year, month, day);
        time = time.AddDays(1);
        string format = "d.M.yyyy";        
        Console.WriteLine(time.ToString(format)); 
    }
}
