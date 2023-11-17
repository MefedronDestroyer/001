using System;
class Program
{
    static void Main()
    {
        int n1 = 0, n2 = 1;
        Console.Write("Первые 10 чисел Фибоначчи: ");
        for (int t = 1; t <= 10; t++)
        {
            Console.Write($"{n1} ");
            int q = n1 + n2;
            n1 = n2;
            n2 = q;
        }
        Console.WriteLine();
    }
}