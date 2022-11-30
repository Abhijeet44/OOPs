using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance_Test
{
    class IMEINum
    {
        int sumDigit(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            return sum;
        }

        bool CheckImei(long n)
        {
            String s = n.ToString();
            int length = s.Length;

            if (length != 15)
                return false;

            int sum = 0;
            for(int i=length; i>=1; i--)
            {
                int d = (int)(n % 10);

                if (i % 2 == 0)
                    d = 2 * d;

                sum += sumDigit(d);
                n = n / 10;
            }
            return (sum % 10 == 0);

        }
        static void Main(string[] args)
        {
            IMEINum i = new IMEINum();

            Console.WriteLine("Enter a Number : ");
            long number = long.Parse(Console.ReadLine());

            if(i.CheckImei(number))
                Console.WriteLine("Valid IMEI Number");
            else
                Console.WriteLine("Invalid IMEI Number");
        }
    }
}
