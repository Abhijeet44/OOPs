using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class EvenNumber
    {

        bool isEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            EvenNumber obj = new EvenNumber();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(obj.isEven(a));
        }
    }
}
