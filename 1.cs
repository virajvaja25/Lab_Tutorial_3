using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    class Student1

    {
        private int enroll;
        private string name;
        private string branch;

        public static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.enroll = 123;
            s1.name = "John Doe";
            s1.branch = "Computer Science";
            Console.WriteLine("Enrollment Number: " + s1.enroll);
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Branch: " + s1.branch);
        }
    }
}
