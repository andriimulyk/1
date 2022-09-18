using System;
namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int Ndigit = (((number / 10 ^ n - 1) % 10));
            Console.WriteLine(Ndigit);
        }
    }
}