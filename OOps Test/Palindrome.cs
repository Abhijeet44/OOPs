using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class Palindrome
    {
        int temp;

        bool isPalindrome(int n)
        {
            int sum = 0;
            temp = n;
            while(n > 0)
            {
                int a = n % 10;
                sum = (sum * 10) + a;
                n = n / 10;
            }
            if (temp == sum)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.Write("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(p.isPalindrome(num));

        }
    }
}
