using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class Method_Overload
    {
        void Number(int num, int d)
        {
            int count = 0;
            while (num > 0)
            {
                int s = num % 10;
                if (s == d)
                {
                    count++;
                }
                num = num / 10;
            }
            Console.WriteLine(count);
        }

        void Number(int n1)
        {
            int sum = 0;
            while (n1 > 0)
            {
                int s = n1 % 10;
                if (s % 2 == 0)
                {
                    sum = sum + s;
                }
                n1 = n1 / 10;
            }
            Console.WriteLine("Sum of Even Digits : " + sum);
        }
        static void Main(string[] args)
        {
            Method_Overload o = new Method_Overload();
            o.Number(2435);
        }
    }
}
