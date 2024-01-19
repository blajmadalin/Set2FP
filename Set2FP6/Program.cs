using System;

namespace Probleme
{
    class Solutie
    {
        static void Main(string[] args)
        {
            int n, x, maxx = -1, ok = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x < maxx) {ok = 0; }
                if (x >= maxx) maxx = x;
                
            }
            if(ok == 1)Console.WriteLine("DA");
            else { Console.WriteLine("NU"); }
        }
    }
}
