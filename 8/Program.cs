using System;
namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число:");
            int c = int.Parse(Console.ReadLine());
            double average = (a + b + c) / 3;
            Console.WriteLine(average);
        }
    }
}