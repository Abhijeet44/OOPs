using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class AreaOfShapes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Choice : " + "\n1:Circle" + "\n:Square" + "\n3:Rectangle" );
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the Radius of Circle : ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area is : " + (3.14*r*r));
                    break;

                case 2:
                    Console.WriteLine("Enter the Side of Squre : ");
                    int s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area is : " + s*s);
                    break;

                case 3:
                    Console.WriteLine("Enter Length : ");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Breadth : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area : " + l*b);
                    break;

                default:
                    Console.WriteLine("Enter a Valid Choice");
                    break;
            }
        }
    }
}
