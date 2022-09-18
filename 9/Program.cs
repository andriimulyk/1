using System;
namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число:");
            int h = Convert.ToInt32(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine(area);
        }

    }
}