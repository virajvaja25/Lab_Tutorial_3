using System;

namespace Lab_Tutorial_3
{
    class Student8
    {
        // Data Members
        private int enrolmentNo;
        private string name;
        private string branch;
        private int semester;

        // Constructor
        public Student8(int eno, string nm, string br, int sem)
        {
            enrolmentNo = eno;
            name = nm;
            branch = br;
            semester = sem;
        }

        // Method
        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Enrolment No : " + enrolmentNo);
            Console.WriteLine("Name         : " + name);
            Console.WriteLine("Branch       : " + branch);
            Console.WriteLine("Semester     : " + semester);
        }
    }

    class TestStudent8
    {
        public static void _8Main(string[] args)
        {
            // Accept student details
            Console.Write("Enter Enrolment No: ");
            int eno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string nm = Console.ReadLine();

            Console.Write("Enter Branch: ");
            string br = Console.ReadLine();

            Console.Write("Enter Semester: ");
            int sem = Convert.ToInt32(Console.ReadLine());

            // Create object
            Student8 s = new Student8(eno, nm, br, sem);

            // Display details
            s.Display();

            Console.ReadKey();
        }
    }
}