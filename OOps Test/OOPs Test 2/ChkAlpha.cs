using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class ChkAlpha
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Alphabet : ");
            char c = Convert.ToChar(Console.ReadLine());

            if(c >= 'a' && c <= 'z')
            {
                Console.WriteLine("Lower case");
            }
            else if(c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("Upper case");
            }
            else
            {
                Console.WriteLine("NOT an Alphabet");
            }
        }
    }
}
