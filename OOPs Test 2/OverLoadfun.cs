using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class OverLoadfun
    {
        void num_calc(int num, char ch)
        {
            if (ch == 's')
            {
                Console.WriteLine("Square : " + num * num);
            }
            else
            {
                Console.WriteLine("Cube : " + num * num * num);
            }
        }

        void num_calc(int a, int b, char ch)
        {
            Console.WriteLine("Enter the Choice : ");
            if (ch == 'p')
            {
                Console.WriteLine("Product : " + a * b);
            }
            else
            {
                Console.WriteLine("Addition : " + a + b);
            }

        }
        static void Main(string[] args)
        {
            OverLoadfun o = new OverLoadfun();
            o.num_calc(2, 's');
        }
    }
}
