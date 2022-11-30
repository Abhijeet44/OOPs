using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance_Test
{
    abstract class Teacher
    {
        int tId;
        String tName;
        long mobileNo;

        public Teacher()
        {

        }

        public Teacher(int tId, string tName, long mobileNo)
        {
            this.tId = tId;
            this.tName = tName;
            this.mobileNo = mobileNo;
        }

        public abstract void Salary();
    }

    class Hourlybased : Teacher
    {
        int rate_per_hr;
        int hrs;

        public Hourlybased()
        {

        }

        public Hourlybased(int rate_per_hr, int hrs)
        {
            this.rate_per_hr = rate_per_hr;
            this.hrs = hrs;
        }

        public override void Salary()
        {
            Console.WriteLine("Hourly based Salary");
        }
    }

    class SalaryBased : Teacher
    {
        int salary;

        public SalaryBased()
        {

        }

        public SalaryBased(int salary)
        {
            this.salary = salary;
        }

        public override void Salary()
        {
            Console.WriteLine("Salary based ");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Hourlybased h = new Hourlybased();
            h.Salary();
            SalaryBased s = new SalaryBased();
            s.Salary();
        }
    }
}
