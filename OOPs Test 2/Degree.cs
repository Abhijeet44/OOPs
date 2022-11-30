using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class Degree
    {
        public void GetDegree()
        {
            Console.WriteLine("I got a degree..........");
        }
    }

    class UnderGraduate : Degree
    {
        public void GetDegree()
        {
            Console.WriteLine("I got a UnderGraduate.........");
        }

    }

    class PostGraduate : Degree
    {
        public void GetDegree()
        {
            Console.WriteLine("I got a Postgraduate...........");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Degree d = new Degree();
            d.GetDegree();
            UnderGraduate d1 = new UnderGraduate();
            d1.GetDegree();
            PostGraduate d2 = new PostGraduate();
            d2.GetDegree();

        }
    }
}
