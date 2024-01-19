using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, x, cateneg = 0, catezero = 0, catepozitive = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0) cateneg++;
                else if(x > 0) catepozitive++;
                else if(x == 0) catezero++;
            }
            Console.WriteLine($"avem {cateneg} numere negative, {catepozitive} numere pozitive si {catezero} numere egale cu 0" );
        }
    }
}
