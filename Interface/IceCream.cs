using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interface
{
    interface IceCream
    {
        void eat();

        void melt()
        {
            Console.WriteLine("Melting..........");
        }

    }

    interface Juice
    {
        void drink();
    }

    class Mastani : IceCream, Juice
    {

        public void eat()
        {
            Console.WriteLine("Eating Ice-Cream.......");
        }
        public void drink()
        {
            Console.WriteLine("Drinking Juice.........");
        }
    }

    class MainClass1
    {
        static void Main(string[] args)
        {
            Mastani m = new Mastani();
            m.eat();
            m.drink();
            IceCream i = new Mastani();
            i.melt();
        }
    }
}
