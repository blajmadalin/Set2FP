using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i ++)
            {
                s = s + i;
            }
            Console.WriteLine(s);
        }
    }
}
