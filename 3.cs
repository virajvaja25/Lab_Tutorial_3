using System;

namespace Lab_Tutorial_3
{
    class Student3
    {
        public int id;
        public string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student3()
        {
            name = "Unknown";
        }

        public Student3(int i, string n)
        {
            id = i;
            name = n;
        }

        public void Display()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Name: " + name);
        }
    }

    class class3
    {
        public static void _pro3Main(string[] args)
        {
            Student3 student = new Student3(101, "Viraj");

            student.Display();

            Console.ReadLine();
        }
    }
}