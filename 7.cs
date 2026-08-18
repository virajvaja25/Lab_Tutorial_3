using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    class Student
    {
        // Data Members
        private int enrolmentNo;
        private string name;

        // Constructor
        public Student()
        {
            enrolmentNo = 0;
            name = "Unknown";
        }

        // Parameterized Constructor    
        public Student(int eno, string nm)
        {
            enrolmentNo = eno;
            name = nm;
        }

        // EnrolmentNo Property
        public int EnrolmentNo
        {
            get
            {
                return enrolmentNo;
            }
            set
            {
                enrolmentNo = value;
            }
        }

        // Name Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Method
        public void Display()
        {
            Console.WriteLine("Enrolment No : " + EnrolmentNo);
            Console.WriteLine("Name         : " + Name);
        }
    }

    class TestStudent
    {
        public static void _7Main(string[] args)
        {
            // Creating object using parameterized constructor
            Student s1 = new Student(101, "Viraj");

            // Display student details
            s1.Display();

            // Using properties to change values
            s1.EnrolmentNo = 102;
            s1.Name = "om";

            Console.WriteLine("\nAfter changing properties:");
            s1.Display();

            Console.ReadKey();
        }
    }
}


