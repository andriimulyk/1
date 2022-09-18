using System;
namespace Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int F = 1;

            for (int c = n; c > 1; c--)
                F = F * c;
            Console.WriteLine("Факторіал  = " + F);


            Console.ReadLine();
        }
    }
}
