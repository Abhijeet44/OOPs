using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class Calculator
    {
        int a, b, c;

        void Readdata()
        {
            Console.WriteLine("Enter value of a and b : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        int add()
        {
            c = a + b;
            Console.WriteLine(c);
            return c;
        }

        void sub()
        {
            c = b - a;
            Console.WriteLine(c);
        }

        int mul()
        {
            c = a * b;
            Console.WriteLine(c);
            return c;
        }

        float div()
        {
            c = a / b;
            Console.WriteLine(c);
            return c;

        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Readdata();

            int sum = c.add();
            Console.WriteLine(sum);

            c.sub();

            int p = c.mul();
            Console.WriteLine(p);
           float f = c.div();
            Console.WriteLine(f);

        }
    }
}
