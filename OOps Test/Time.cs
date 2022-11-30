using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class Time
    {
        int hour;
        int min;
        int sec;
        
        void Set_time()
        {
            Console.WriteLine("Enter Hours : ");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minutes : ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second : ");
            sec = int.Parse(Console.ReadLine());
        }

        void Show_time()
        {
            Console.WriteLine("Time : " + hour + ":" + min + ":" + sec);
        }
        static void Main(string[] args)
        {
            Time t = new Time();
            t.Set_time();
            t.Show_time();
        }
    }
}
