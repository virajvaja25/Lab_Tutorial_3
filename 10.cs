using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tutorial_3
{
    class Employee
    {
        private int empId;
        private string empName;
        private double basicSalary;
        private double netSalary;

        public Employee(int id, string name, double salary)
        {
            empId = id;
            empName = name;
            basicSalary = salary;
        }

        public void CalculateNetSalary()
        {
            double hra = 0.1 * basicSalary; // HRA is 10% of basic salary
            double da = 0.2 * basicSalary;  // DA is 20% of basic salary
            netSalary = basicSalary + hra + da;
        }

        public void Display()
        {
            Console.WriteLine("------Employee Details------");
            Console.WriteLine("\nEmployee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Net Salary: " + netSalary);
        }

    }

    class TestEmployee
    {
        static void Main()
        {
            Console.WriteLine("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Basic Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(id, name, salary);

            emp.CalculateNetSalary();
            emp.Display();
            Console.Read();
            
        }
    }
}
