using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class Rectangle
    {
        int length;
        int breadth;
        int area;
        int perimeter;

        void Input()
        {
            Console.Write("Enter Length : ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Enter Breadth :");
            breadth = int.Parse(Console.ReadLine());

        }

        void Calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }

        void Display()
        {
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Perimeter :" + perimeter);
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Input();
            r.Calculate();
            r.Display();

        }
    }
}
