using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Oops_Concepts
{
    interface Icalculator
    {
        int add(int a, int b);
        int sub(int x, int y);
    }

    class I : Icalculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public override string ToString()
        {
            return "Adddition : " + add(2,3) + "|" + "Substraction : " + sub(5,2);
        }
    }

    class MainClass2
    {
        static void Main(string[] args)
        {
            Icalculator obj = new I();
            Console.WriteLine(obj.ToString());

        }
    }
}
