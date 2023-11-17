using System;
namespace _002
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите 1е число: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2е число: ");
            int n2 = int.Parse(Console.ReadLine());
            int sr = n1 + n2;
            int srz = sr / 2;
            Console.WriteLine($"Среднее арифметическое =  {srz}");
        }
    }
}
