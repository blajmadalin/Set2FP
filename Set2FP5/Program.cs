using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, x, k = 0, pozegalnr = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == k)
                {
                    pozegalnr++;
                }
                k++;
            }
            Console.Write(pozegalnr);
        }
    }
}
