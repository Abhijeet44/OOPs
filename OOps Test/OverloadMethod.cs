using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class OverloadMethod
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
                if(s % 2 == 0)
                {
                    sum = sum + s;
                }
                n1 = n1 / 10;
            }
        }
        static void Main(string[] args)
        {
            OverloadMethod o = new OverloadMethod();
            o.Number(1212211, 1);
        }
    }
}
