using System;
class Program
{
    static void Main()
    {
        int s = 0;
        for (int t = 1; t <= 150; t++)
        {
            if (t % 5 == 0 || t % 7 == 0)
            {
                s += 1;
            }
        }
        Console.WriteLine($"Сумма чисел кратнах 5 и 7: {s}");
    }
}