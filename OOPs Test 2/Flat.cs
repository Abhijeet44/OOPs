using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPs_Test_2
{
    class Flat
    {
        int flatNo;
        String wingName;
        Member member;

        public Flat()
        {

        }

        public Flat(int flatNo, string wingName, Member member)
        {
            this.flatNo = flatNo;
            this.wingName = wingName;
            this.member = member;
        }

        public int FlatNo
        {
            set { flatNo = value; }
            get { return flatNo; }
        }

        public String WingName
        {
            set { wingName = value; }
            get { return wingName; }
        }

        public Member Member
        {
            set { member = value; }
            get { return member; }
        }
    }

    class Member
    {
        int memberId;
        String membername;
        String profession;
        int age;

        public Member()
        {

        }

        public Member(int memberId, string membername, string profession, int age)
        {
            this.memberId = memberId;
            this.membername = membername;
            this.profession = profession;
            this.age = age;
        }

        public int MemberId
        {
            set { MemberId = value; }
            get { return MemberId; }
        }

        public String Membername
        {
            set { membername = value; }
            get { return membername; }
        }

        public String Profession
        {
            set { profession = value; }
            get { return profession; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }

    class MainClass1
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.FlatNo = 100;
            f1.WingName = "A Wing";

            Console.WriteLine("Flat No. : " + f1.FlatNo);
            Console.WriteLine("Wing Name : " + f1.WingName);

            f1.Member.MemberId = 1001;
            f1.Member.Membername = "AB";
            f1.Member.Profession = "Software Developer";
            f1.Member.Age = 25;

            Console.WriteLine("Member Id : " + f1.Member.MemberId);
            Console.WriteLine("Member Name : " + f1.Member.MemberId);
            Console.WriteLine("Profession : " + f1.Member.Profession);
            Console.WriteLine("Age : " + f1.Member.Age);

        }
    }
}
