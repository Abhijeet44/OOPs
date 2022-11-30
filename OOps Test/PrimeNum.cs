using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class PrimeNum
    {
        bool isPrime(int num)
        {
            int count = 0;
            for(int i=2; i<=num/2; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count > 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            PrimeNum p = new PrimeNum();
            Console.Write("Enter a Number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(p.isPrime(a));

            for(int i=2; i<=500; i++)
            {
                if (p.isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
