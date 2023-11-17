using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите начало диапазона: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Введите конец диапазона: ");
        int n2 = int.Parse(Console.ReadLine());
        int st = 0;
        for (int t = n1; t <= n2; t++)
        {
            if (t % 2 == 0)
            {
                st += 1;
            }
        }
        Console.WriteLine($"Сумма четных чисел: {st} ");
    }
}