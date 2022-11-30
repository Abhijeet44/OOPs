using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interface
{
    interface A1
    {
        void show();
    }

    interface A2
    {
        void show();
    }

    class Implements : A1, A2
    {
        void A1.show()          // Public modifier is not aplicable for this 
        {
            Console.WriteLine("Implementing class calling A1's Show");
        }

        void A2.show()
        {
            Console.WriteLine("Implementing class calling A2's Show");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            A1 obj1 = new Implements();
            obj1.show();

            A2 obj2 = new Implements();
            obj2.show();
        }
    }
}
