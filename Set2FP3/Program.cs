using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, suma = 0, produs = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                suma = suma + i;
                produs = produs * i;
            }
            Console.WriteLine($"Suma sirului este {suma}, iar produsul {produs}");
        }
    }
}
