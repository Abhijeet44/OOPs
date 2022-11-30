using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Mehods
{
    class CheckBinary
    {
        void BinaryChk(int num)
        {
            bool isBinary = true;
            int copynum = num;
            while (num != 0)
            {
                int temp = num % 10;
                if (temp > 1)
                {
                    isBinary = false;
                    break;
                }
                else
                {
                    copynum = copynum / 10;
                }
            }
            if (isBinary)
                Console.WriteLine("Binary Number");
            else
                Console.WriteLine("NOT a Binary Number");
        }
        static void Main(string[] args)
        {
            CheckBinary o = new CheckBinary();
            Console.Write("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());
            o.BinaryChk(n);
        }
    }
}
