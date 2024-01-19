using System;
using System.Runtime.InteropServices;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, sumproduse = 0, produse = 1 ;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                produse = produse * i;
                sumproduse = sumproduse + produse;
            }
            Console.WriteLine(sumproduse);
        }
    }
}