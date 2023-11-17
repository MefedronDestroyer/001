namespace _001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n1 = int.Parse(Console.ReadLine());
            int kv = n1 * n1;
            int cu = n1 * n1 * n1;
            Console.WriteLine($" {n1} в квадрате =  {kv}");

            Console.WriteLine($"{n1} в кубе =  {cu}");
        }
    }
}
