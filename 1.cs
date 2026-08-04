using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    class Student1

    {
        //Declaring private data members
        private int enroll;
        private string name;
        private string branch;


        //static Method
        public void AcceptData(int e, string n, string b)
        {
            enroll = e;
            name = n;
            branch = b;
        }
        //static method
        public void Display()
        {
            Console.WriteLine("------Student Details------");
            Console.WriteLine("Enrollment No: " + enroll);
            Console.WriteLine("Name is : " + name);
            Console.WriteLine("Branch is : " + branch);
        }   
    }

   class Class1
    {
        public static void Student1Main()
        {

            Student1 s1 = new Student1();
            Student1 s2 = new Student1();

            s1.AcceptData(101, "John", "CSE");
            s1.Display();


            s2.AcceptData(102, "Jane", "ECE");
            s2.Display();

            Console.ReadLine();
        }
    }
}
