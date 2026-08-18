using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
   class Student2
    {
     public string course { get; set; }
     
     public string department { get; set; }

     public void DisplayStudentDetails()
        {
            Console.WriteLine("--------Student Details--------");
            Console.WriteLine("Course is : " + course);
            Console.WriteLine("Department is : " + department);
        }

    }
    class Person : Student2
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("--------Person Details--------");
            Console.WriteLine("Name is : " + Name);
            Console.WriteLine("Id is : " + Id);
        }

    }
    public class _15
    {
        public static void _15Main()
        {
            Person p = new Person();
            Console.WriteLine("Enter Your Name Of The Person : ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Enter your Age Of Person : ");
            p.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your course Of The Person : ");
            p.course = Console.ReadLine();
            Console.WriteLine("Enter your department Of The Person : ");
            p.department = Console.ReadLine();

            p.DisplayPersonDetails();
            p.DisplayStudentDetails();
            Console.ReadLine();
        }
    }
}
