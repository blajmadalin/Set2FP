using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            double n, x, sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                sum = sum + (1 / x);
                
            }
            Console.WriteLine(sum);

        }
    }
}
