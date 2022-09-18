using System;
namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int n = int.Parse(Console.ReadLine());
            int LastDigit = n % 10;
            Console.WriteLine(LastDigit);
        }
    }
}