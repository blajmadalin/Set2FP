using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, a, b, secv = 1, secvmax = -1;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if(a != b)
                {
                    if (secv > secvmax) secvmax = secv;
                    secv = 1;
                } 
                if (a == b) secv++;
                a = b;
  
            }
            Console.WriteLine(secvmax);
            
        }
    }
}
