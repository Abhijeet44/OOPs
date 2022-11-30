using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    //    1
    //   222
    //  33333
    // 4444444

    class Pattern3
    {
        static void Main(string[] args)                  
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 3; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}