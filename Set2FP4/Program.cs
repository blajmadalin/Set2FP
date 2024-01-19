using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, x, k = 0, a, pozA = -1;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == a)
                {
                    pozA = k; Console.Write(pozA); return;
                }
                k++;
            }
            Console.Write(pozA);
        }
    }
}
