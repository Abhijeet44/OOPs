using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interface
{
    interface Cake
    {
        void bake();
    }

    class Strawaberry : Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking Stwaberry cake....... ");
        }
    }

    class Blakforrest:Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking BlakForrest cake.........");
        }
    }

    class MainClass3
    {
        static void Main(string[] args)
        {
            Strawaberry s = new Strawaberry();
            s.bake();
            Blakforrest b = new Blakforrest();
            b.bake();

        }
    }
}
