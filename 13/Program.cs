using System;
namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = true;

            if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            {
                result = true;

                Console.WriteLine(result);
            }

            else
            {
                result = false;
                Console.WriteLine("False");
            }
        }
    }
}
