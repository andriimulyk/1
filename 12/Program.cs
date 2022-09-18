using System;
namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = true;
            if (n > 20 && n % 10 == 1)
            {



                result = true;
                Console.WriteLine(result);
            }

            else
            {
                result = false;
                Console.WriteLine(result);
            }


        }
    }
}
