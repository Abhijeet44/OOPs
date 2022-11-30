using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance_Test
{
    class Employee
    {
        int id;
        String name;
        Dept d;

        public Employee()
        {

        }

        public Employee(int id, string name, Dept d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public String Name
        {
            set { name = value; }
            get { return name;  }
        }

        public Dept D
        {
            set { d = value; }
            get { return d; }
        }
    }

    class Dept
    {
        int deptid;
        String dName;

        public Dept()
        {

        }

        public Dept(int deptid, string dName)
        {
            this.deptid = deptid;
            this.dName = dName;
        }

        public int Deptid
        {
            set { deptid = value; }
            get { return deptid; }
        }

        public String DName
        {
            set { dName = value; }
            get { return dName; }
        }
    }

    class Main
    {
        Employee e = new Employee();
        Dept d = new Dept();


            

    }
}
