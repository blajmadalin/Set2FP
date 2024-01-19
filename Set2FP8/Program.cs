using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, x1 = 1, x2 = 1, x = 1  ;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i <= n; i++)
            {
                x = x1 + x2;
                x1 = x2;
                x2 = x;
            }
            Console.WriteLine(x);
        }
    }
}
