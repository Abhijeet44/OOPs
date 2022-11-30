using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class TrimorphicNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numbber To Check : ");
            int num = int.Parse(Console.ReadLine());

            int cube = num * num * num;

            if (cube % 10 == num % 10) 
                Console.WriteLine("TRIMORPHIC");
            else
                Console.WriteLine("NOT TRIMORTHIC");
        }
    }
}
