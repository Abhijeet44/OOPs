using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance_Test
{
    class TwinPrime
    {
         bool CheckPrime(int n)
         {
            int count = 0;
            for(int i=2; i<=n/2; i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
            }
            if (count > 0)
                return true;
            else
                return false;
        }

        bool CheckTwinPrime(int a, int b)
        {
            if (CheckPrime(a) && CheckPrime(b) && (a - b == 2))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            TwinPrime t = new TwinPrime();

            Console.WriteLine("Enter Two Numbers : ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(t.CheckTwinPrime(x,y))
                Console.WriteLine("Twin Prime");
            else
                Console.WriteLine("NOT Twin Prime");
        }
    }
}
