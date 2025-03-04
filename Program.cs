using System;

class Program
{
    static void Main()
    {
        Console.Write("Düzbucaqlının enini daxil edin");
        double en = Convert.ToDouble(Console.ReadLine());

        Console.Write("Düzbucaqlının uzunluğunu daxil edin");
        double uzunluq = Convert.ToDouble(Console.ReadLine());

        double sahe = en * uzunluq;
        double perimetr = 2 * (en + uzunluq);

        Console.WriteLine(sahe);
        Console.WriteLine(perimetr);
    }
}
