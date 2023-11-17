using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write($"Делители числа {n1}: ");
        for (int t = 1; t <= n1; t++)
        {
            if (n1 % t == 0)
            {
                Console.Write($"{t} ");
            }
        }
        Console.WriteLine();
    }
}