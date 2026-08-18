using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    class StudentDetails
    {
        public int enrollNO { get; set; }
        public string name { get; set; }
    }
    public class _12
    {
        public static void _12Main()
        {
            StudentDetails s = new StudentDetails();

            Console.WriteLine("Enrollment Number: ");
            s.enrollNO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            s.name = Console.ReadLine();

            Console.WriteLine("--------Student Details--------");
            Console.WriteLine("Enrollment Number: " + s.enrollNO);
            Console.WriteLine("Student Name is: " + s.name);
            Console.ReadLine();
        }
    }
}
